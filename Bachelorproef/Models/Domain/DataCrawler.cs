using RiotSharp;
using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Text;
using DataGatherer.Models.DAL;
using RiotSharp.Endpoints.MatchEndpoint;
using System.Threading.Tasks;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;
using RiotSharp.Endpoints.StaticDataEndpoint.Item;
using DataGatherer.Models.Domain;

namespace DataGatherer.Models.Domain
{
    class DataCrawler
    {
        public static SummonerStore Summoners { get; set; }
        public static MatchStore Matches { get; set; }
        public ChampionStore Champions { get; set; }
        public ItemStore Items { get; set; }
        private List<APIKey> Keys { get; set; }
        public const long startSummonerId = 24775482; //29658879;//29277692;
        private static List<long> summonersCompletedList = new List<long>();
        private static List<long> matchCompletedList = new List<long>();
        private static HashSet<long> seedList = new HashSet<long>();
        private static Queue<MySummoner> seedQueue = new Queue<MySummoner>();
        private static DataGathererContext context = new DataGathererContext();
        private RiotApi api; 

        public DataCrawler()
        {
            Summoners = new SummonerStore(context);
            Matches = new MatchStore(context);
            Champions = new ChampionStore(context);
            Items = new ItemStore(context);
        }

        public DataCrawler(List<APIKey> keys) : base()
        {
            Summoners = new SummonerStore(context);
            Matches = new MatchStore(context);
            Champions = new ChampionStore(context);
            //Items = new ItemStore(context);
            this.Keys = keys;
        }

        private void InitiateSeedList()
        {
            seedQueue.Clear();
            ChooseApiKey();
            if(Summoners.Count() == 0) seedQueue.Enqueue(new MySummoner(Task.Run(async () => { return await api.Summoner.GetSummonerBySummonerIdAsync(Region.euw, startSummonerId);}).Result));  //seedList.Add(startSummonerId);
            else
            {
                foreach(KeyValuePair<long, MySummoner> entry in Summoners.Summoners)
                {
                    //seedList.Add(entry.Key);
                    if (!entry.Value.IsCompleted) seedQueue.Enqueue(entry.Value);
                    else summonersCompletedList.Add(entry.Key);
                }
                foreach(KeyValuePair<long, MyMatch> entry in Matches.Matches)
                {
                    if (entry.Value.IsCompleted) matchCompletedList.Add(entry.Key);
                }
            }
        }

        //public void StartCrawl(Region region, int numberOfSummoners = 50)
        //{
        //    InitiateSeedList();
        //    using(context){
        //        while (Summoners.Count() < numberOfSummoners)
        //        {
        //            foreach (long summonerid in seedList)
        //            {
        //                Console.WriteLine("Get Match history");
        //                ChooseApiKey();
        //                var matchHistory = Task.Run(async () => { return await api.Match.GetMatchListAsync(region, summonerid, queues: new List<int> { 420 }, beginTime: DateTime.Now.AddDays(-5)); }).Result;
        //                Console.WriteLine("Match history retrieved");
                                                    
        //                    foreach (MatchReference mr in matchHistory.Matches)
        //                    {
        //                        ChooseApiKey();
        //                        Match match = Task.Run(async () => { return await api.Match.GetMatchAsync(region, mr.GameId); }).Result;
        //                        MyMatch matchToComplete = new MyMatch(match); 
        //                        context.Matches.Add(matchToComplete);
        //                        context.SaveChanges();
        //                        Console.WriteLine("Match started");
        //                        if (!matchCompletedList.Contains(matchToComplete.MatchId))
        //                        {
        //                            CompleteMatch(region, matchToComplete);
        //                        }
        //                    }                     
        //            }
        //            StartCrawl(region);
        //        }
                
        //    }      
        //}

        public void StartCrawlQueue(Region region, int numberOfMatches = 50)
        {
            InitiateSeedList();
            try
            {
                using (context)
                {
                    while (Matches.Count() < numberOfMatches)
                    {
                        while (seedQueue.Count != 0)
                        {
                            Console.WriteLine("Get Match history");
                            MySummoner summoner = seedQueue.Dequeue();
                            if (!summonersCompletedList.Contains(summoner.SummonerId))
                            {
                                ChooseApiKey();
                                System.Threading.Thread.Sleep(500);
                                var matchHistory = Task.Run(async () => { return await api.Match.GetMatchListAsync(region, summoner.AccountId, queues: new List<int> { 420 }, beginTime: DateTime.Now.AddDays(-5)); }).Result;
                                Console.WriteLine("Match history retrieved");

                                foreach (MatchReference mr in matchHistory.Matches)
                                {
                                    ChooseApiKey();
                                    System.Threading.Thread.Sleep(500);
                                    Match match = Task.Run(async () => { return await api.Match.GetMatchAsync(region, mr.GameId); }).Result;
                                    MyMatch matchToComplete = new MyMatch(match);
                                    Matches.AddMatch(matchToComplete);
                                    Console.WriteLine("Match started");
                                    if (!matchCompletedList.Contains(matchToComplete.MatchId))
                                    {
                                        CompleteMatch(region, matchToComplete);
                                    }
                                }
                                Summoners.CompleteSummoner(summoner);
                                Console.WriteLine("Match History complete");
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Application restarted with error: "+ e.Message +"\n"+e.StackTrace);
                StartCrawlQueue(region, numberOfMatches);

            }
        }

        private void CompleteMatch(Region region, MyMatch match)
        {

            foreach(MyParticipant p in match.Participants)
            {
                ChooseApiKey();
                System.Threading.Thread.Sleep(500);
                MySummoner sum = new MySummoner(Task.Run(async () => { return await api.Summoner.GetSummonerBySummonerIdAsync(region, p.SummonerId); }).Result);
                if (!summonersCompletedList.Contains(sum.SummonerId))
                {
                    Summoners.AddSummoner(sum);
                    seedQueue.Enqueue(sum);
                    Console.WriteLine("Summoner added!");
                }
            }
            matchCompletedList.Add(match.MatchId);
            Matches.CompleteMatch(match);
            Console.WriteLine("Match added");
        }

        private void ChooseApiKey()
        {
            foreach(APIKey k in Keys)
            {
                if ((DateTime.Now - k.LastTimeCalled).TotalMilliseconds > 900)
                {
                    api = RiotApi.GetDevelopmentInstance(k.Key);
                    k.CallKey();
                    break;
                }
            }    
        }

        public void CrawlStaticData(Region region)
        {
            ChooseApiKey();
            ChampionListStatic champions = Task.Run(async () => { return await api.StaticData.Champions.GetAllAsync("8.15.1"); }).Result;
            foreach (string k in champions.Champions.Keys)
            {
                ChampionStatic champ;
                champions.Champions.TryGetValue(k, out champ);
                MyChampion championToAdd = new MyChampion(champ);
                Champions.Add(championToAdd);
                Console.WriteLine(champ.Name + " added");
            }
            //ChooseApiKey();
            //ItemListStatic items = Task.Run(async () => { return await api.StaticData.Items.GetAllAsync("8.15.1"); }).Result;
            //foreach(int k in items.Items.Keys)
            //{
            //    ItemStatic item;
            //    items.Items.TryGetValue(k, out item);
            //    MyItem itemToAdd = new MyItem(item);
            //    itemToAdd.ItemId = k; 
            //    Items.Add(itemToAdd);
            //    Console.WriteLine(item.Name +" added");
            //}
        }
    }  
}
