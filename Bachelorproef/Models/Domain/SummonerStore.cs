using DataGatherer.Models.DAL;
using RiotSharp.Endpoints.SummonerEndpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGatherer.Models.Domain
{
    class SummonerStore
    {
        public Dictionary<long, MySummoner> Summoners { get; private set; }

        private DataGathererContext context;

        public SummonerStore() 
        {
            Summoners = new Dictionary<long, MySummoner>();
        }

        public SummonerStore(DataGathererContext context)
        {
            this.context = context;
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
                context.Summoners.Add(summoner);
                context.SaveChanges();
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

        internal void CompleteSummoner(MySummoner summoner)
        {
            summoner.SummonerCompleted();
            MySummoner sumtoupdate = context.Summoners.Where(s => s.SummonerId == summoner.SummonerId).FirstOrDefault();
            context.Entry(sumtoupdate).CurrentValues.SetValues(summoner);
        }
    }
}
