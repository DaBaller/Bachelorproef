using DataGatherer.Models.DAL;
using System.Collections.Generic;
using System.Linq;


namespace DataGatherer.Models.Domain
{
    class MatchStore
    {
        public Dictionary<long, MyMatch> Matches { get; set; }

        private DataGathererContext context;

        public MatchStore()
        {
            Matches = new Dictionary<long, MyMatch>();   
        }

        public MatchStore(DataGathererContext context)
        {
            this.context = context;
            Matches = new Dictionary<long, MyMatch>(); 
            foreach(MyMatch match in context.Matches)
            {
                this.Matches.Add(match.MatchId, match); 
            }
        }

        public void AddMatch(MyMatch match)
        {
            long matchid = match.MatchId;
            if (!Matches.ContainsKey(matchid))
            {
                Matches.Add(matchid, match);
                context.Matches.Add(match);
                context.SaveChanges();
            }
        }

        public int Count()
        {
            return Matches.Count;
        }


        internal void CompleteMatch(MyMatch match)
        {
            match.MatchCompleted();
            MyMatch matchtoupdate = context.Matches.Where(m => m.MatchId == match.MatchId).FirstOrDefault();
            context.Entry(matchtoupdate).CurrentValues.SetValues(match);
        }
    }
}
