using RiotSharp;
using RiotSharp.Endpoints.ChampionEndpoint;
using RiotSharp.Endpoints.MatchEndpoint;
using RiotSharp.Endpoints.MatchEndpoint.Enums;
using RiotSharp.Misc;
using RiotSharp.Endpoints.StaticDataEndpoint;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;
using System;
using System.Collections.Generic;
using System.Linq;
using DataGatherer.Models.Domain;

namespace DataGatherer
{
    class Program
    {
        static void Main(string[] args)
        {
            //string apikey1 = "RGAPI-dbdc6620-4ad4-4c60-bc06-b93bb1470af3";  
            string apikey2 = "RGAPI-1b4e65ed-70f0-4d6e-838e-f9795d5161f3";
            //string apikey3 = "RGAPI-fe8602fe-7b09-4475-829c-50d388b9baab";
            //string apikey4 = "RGAPI-dc65cd48-e38e-4cb3-bfc4-e4d2ec4b67b6";
            //string apikey5 = "RGAPI-daaeb7c8-e7ba-47fa-9537-4269b6b89549";
            //string apikey6 = "RGAPI-5ee00a51-0355-43dd-b2a6-abaf580ddf0f";
            //string apikey7 = "RGAPI-520fca93-f8e1-4b72-b095-13a10e8f1883";
            //string apikey8 = "RGAPI-49dbeac0-2cfc-4fec-b264-0e570793c9dd";
            //string apikey9 = "RGAPI-3165320e-48f0-4b10-abdf-5456bbaedd33";
            //string apikey10 = "RGAPI-e54978a2-37ee-4656-9a50-1ba9db464da0";
            //string apikey11 = "RGAPI-5dfb65be-b2fd-4ebc-a94b-044b9f4d3ac9";
            //string apikey12 = "RGAPI-c4b1a730-ffc7-4222-a222-46c8da37b53e";





            List<APIKey> keys = new List<APIKey>() { /*new APIKey(apikey1),*/ new APIKey(apikey2)/*, new APIKey(apikey3), new APIKey(apikey4), new APIKey(apikey5), new APIKey(apikey6), new APIKey(apikey7) }; /*, new APIKey(apikey8) , new APIKey(apikey9), new APIKey(apikey10), new APIKey(apikey11), new APIKey(apikey12)*/ };

            DataCrawler crawler = new DataCrawler(keys);
            Console.WriteLine("Crawler Initiated");
            Region region = Region.euw;
            int numberofsummoners = 20000;
            //try
            //{
                Console.WriteLine("start crawling");
                crawler.CrawlStaticData(region);
                //crawler.StartCrawlQueue(region, numberofsummoners);
                Console.WriteLine("Crawl stopped");
                Console.ReadLine();
            //}

            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message + " "+ e.TargetSite+ " "+ e.Source);
            //    Console.ReadLine();
            //}






            //List<long> champids = new List<long>();
            //List<long> summonersEU = SummonerGatherer.GetSummonersPerRegion(api, Region.euw);
            //List<long> summonersNA = SummonerGatherer.GetSummonersPerRegion(api, Region.na);
            //List<long> summonersKR = SummonerGatherer.GetSummonersPerRegion(api, Region.kr);

            //List<long> summonersGlobal = SummonerGatherer.GetSummonersPerRegion(api, Region.global);

            //var champs = api.GetChampions(Region.euw);





        }
    }

}
