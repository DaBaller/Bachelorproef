using DataGatherer.Models.DAL;
using RiotSharp.Endpoints.MatchEndpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGatherer
{
    class MatchStore
    {
        public Dictionary<long, MyMatch> Matches { get; private set; }

        public MatchStore()
        {
            Matches = new Dictionary<long, MyMatch>();   
        }

        public MatchStore(DataGathererContext context)
        {
            Matches = new Dictionary<long, MyMatch>(); 
            foreach(MyMatch match in context.Matches)
            {
                this.Matches.Add(match.MatchId, match); 
            }
        }

        public void AddMatch(MyMatch match)
        {
            long matchid = match.MatchId;
            if (Matches.ContainsKey(matchid))
            {
                Matches.Add(matchid, match);
            }
        }

    }
}
