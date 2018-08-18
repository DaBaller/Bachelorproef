using RiotSharp.Endpoints.SummonerEndpoint;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataGatherer.Models.Domain
{
    public class MySummoner
    {

        public long SummonerId { get; set; }
        public long AccountId { get; set; }
        public string SummonerName { get; set; }
        public virtual List<MyMatch> MatchHistory { get; set; }
        public string Tier { get; set; }
        public bool IsCompleted { get; set; }

        public MySummoner()
        {
            MatchHistory = new List<MyMatch>();
        }

        public MySummoner(int summonerId, long accountid, string summonerName, List<MyMatch> matchHistory, string tier)
        {
 
            SummonerId = summonerId;
            AccountId = accountid;
            SummonerName = summonerName;
            this.MatchHistory = matchHistory;
            Tier = tier;
            IsCompleted = false;
        }

        public MySummoner(Summoner summoner)
        {
            SummonerId = summoner.Id;
            AccountId = summoner.AccountId;
            SummonerName = summoner.Name;
            IsCompleted = false;


            MatchHistory = new List<MyMatch>();
        }

        public void AddMatchToHistory(MyMatch match)
        {
            MatchHistory.Add(match);
        }

        public void SummonerCompleted()
        {
            IsCompleted = true;
        }
    }
}
