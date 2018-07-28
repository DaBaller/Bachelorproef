using RiotSharp.Endpoints.SummonerEndpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer
{
    class MySummoner
    {
        public long Id { get; set; }
        public long SummonerId { get; set; }
        public string SummonerName { get; set; }
        public List<MyMatch> MatchHistory { get; set; }
        public string Tier { get; set; }

        public MySummoner()
        {
            Id = 0;
            MatchHistory = new List<MyMatch>();
        }

        public MySummoner(int summonerId, string summonerName, List<MyMatch> matchHistory, string tier)
        {
            Id = 0; 
            SummonerId = summonerId;
            SummonerName = summonerName;
            this.MatchHistory = matchHistory;
            Tier = tier;
        }

        public MySummoner(Summoner summoner)
        {
            Id = 0;
            SummonerId = summoner.Id;
            SummonerName = summoner.Name;

            MatchHistory = new List<MyMatch>();
        }

        public void AddMatchToHistory(MyMatch match)
        {
            MatchHistory.Add(match);
        }
    }
}
