using RiotSharp;
using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Text;
using DataGatherer.Models.DAL;
using RiotSharp.Endpoints.MatchEndpoint;
using System.Threading.Tasks;

namespace DataGatherer.Domain
{
    class DataCrawler
    {
        public static SummonerStore Summoners { get; set; }
        public static MatchStore Matches { get; set; }
        public ChampionStore Champions { get; set; }
        public const long startSummonerId = 24328420;//29658879;//29277692;
        private static List<long> matchCompletedList = new List<long>();
        private static HashSet<long> seedList = new HashSet<long>();
        private static Queue<long> seedQueue = new Queue<long>();
        private static DataGathererContext context = new DataGathererContext();

        public DataCrawler()
        {
            Summoners = new SummonerStore(context);
            Matches = new MatchStore(context);
        }

        private void InitiateSeedList()
        {
            seedQueue.Clear();
            seedQueue.Enqueue(startSummonerId);
            if(Summoners.Count() == 0) seedList.Add(startSummonerId);
            else
            {
                foreach(KeyValuePair<long, MySummoner> entry in Summoners.Summoners)
                {
                    //seedList.Add(entry.Key);
                   seedQueue.Enqueue(entry.Key);
                }
            }
        }

        public void StartCrawl(RiotApi api, Region region, int numberOfSummoners = 50)
        {
            InitiateSeedList();
            using(context){
                while (Summoners.Count() < numberOfSummoners)
                {
                    foreach (long summonerid in seedList)
                    {
                        Console.WriteLine("Get Match history");       
                        var matchHistory = Task.Run(async () => { return await api.Match.GetMatchListAsync(region, summonerid, queues: new List<int> { 420 }, beginTime: DateTime.Now.AddDays(-5)); }).Result;
                        Console.WriteLine("Match history retrieved");
                                                    
                            foreach (MatchReference mr in matchHistory.Matches)
                            {
                                Match match = Task.Run(async () => { return await api.Match.GetMatchAsync(region, mr.GameId); }).Result;
                                MyMatch matchToComplete = new MyMatch(match); 
                                context.Matches.Add(matchToComplete);
                                context.SaveChanges();
                                Console.WriteLine("Match started");
                                if (!matchCompletedList.Contains(matchToComplete.MatchId))
                                {
                                    CompleteMatch(api, region, matchToComplete);
                                }
                            }                     
                    }
                    StartCrawl(api, region);
                }
                
            }      
        }

        public void StartCrawlQueue(RiotApi api, Region region, int numberOfSummoners = 50)
        {
            InitiateSeedList();
            using (context)
            {
                while (Summoners.Count() < numberOfSummoners)
                {
                    while (seedQueue.Count != 0)
                    {
                        Console.WriteLine("Get Match history");
                        long summonerid = seedQueue.Dequeue();
                        var matchHistory = Task.Run(async () => { return await api.Match.GetMatchListAsync(region, summonerid, queues: new List<int> { 420 }, beginTime: DateTime.Now.AddDays(-5)); }).Result;
                        Console.WriteLine("Match history retrieved");

                        foreach (MatchReference mr in matchHistory.Matches)
                        {
                            Match match = Task.Run(async () => { return await api.Match.GetMatchAsync(region, mr.GameId); }).Result;
                            MyMatch matchToComplete = new MyMatch(match);
                            context.Matches.Add(matchToComplete);
                            context.SaveChanges();
                            Console.WriteLine("Match started");
                            if (!matchCompletedList.Contains(matchToComplete.MatchId))
                            {
                                CompleteMatch(api, region, matchToComplete);
                            }
                        }
                    }
                }
            }
        }

        private void CompleteMatch(RiotApi api, Region region, MyMatch match)
        {

            foreach(MyParticipant p in match.Participants)
            {
                MySummoner sum = new MySummoner(Task.Run(async () => { return await api.Summoner.GetSummonerBySummonerIdAsync(region, p.SummonerId); }).Result);
                Summoners.AddSummoner(sum);
                seedQueue.Enqueue(sum.SummonerId);
                context.Summoners.Add(sum);
                context.SaveChanges();
                Console.WriteLine("Summoner added!");
            }

            matchCompletedList.Add(match.MatchId);
            Console.WriteLine("Match added");
        }
    }  
}
