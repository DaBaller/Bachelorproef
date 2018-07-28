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
using DataGatherer.Domain;

namespace DataGatherer
{
    class Program
    {
        static void Main(string[] args)
        {
            string apikeydev = "RGAPI-77b5bc80-8161-453d-9268-d3f79068f76c";  
            string apikeylive = "RGAPI-1b4e65ed-70f0-4d6e-838e-f9795d5161f3";
            var api = RiotApi.GetDevelopmentInstance(apikeylive);
            Console.WriteLine("Api acces retrieved");

            DataCrawler crawler = new DataCrawler();
            Console.WriteLine("Crawler Initiated");
            Region region = Region.euw;
            int numberofsummoners = 1000;
            //try
            //{
                Console.WriteLine("start crawling");
                crawler.StartCrawlQueue(api, region, numberofsummoners);
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
