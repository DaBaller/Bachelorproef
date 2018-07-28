using DataGatherer.Models.DAL;
using RiotSharp.Endpoints.SummonerEndpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer
{
    class SummonerStore
    {
        public Dictionary<long, MySummoner> Summoners { get; private set; }

        public SummonerStore()
        {
            Summoners = new Dictionary<long, MySummoner>();
        }

        public SummonerStore(DataGathererContext context)
        {
            Summoners = new Dictionary<long, MySummoner>(); 
            foreach(MySummoner sum in context.Summoners)
            {
                this.Summoners.Add(sum.SummonerId, sum);
            }
        }

        public void AddSummoner(MySummoner summoner)
        {
            long summonerid = summoner.SummonerId;
            if (!Summoners.ContainsKey(summonerid))
            {
                Summoners.Add(summonerid, summoner);
            }    
        }

        public int Count()
        {
            return Summoners.Count;
        }

        public void AddMatchToMatchHistory(long summonerid, MyMatch match)
        {
            if (Summoners.ContainsKey(summonerid))
            {
                MySummoner sum;
                Summoners.TryGetValue(summonerid, out sum);
                sum.AddMatchToHistory(match);
            }
            
        }

    }
}
