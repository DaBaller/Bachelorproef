using System;
using System.Collections.Generic;
using System.Text;
using DataGatherer.Models.DAL;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;

namespace DataGatherer.Models.Domain
{
    public class ChampionStore
    {

        public Dictionary<long, MyChampion> Champions { get; set; }

        private DataGathererContext context;

        public ChampionStore()
        {
            Champions = new Dictionary<long, MyChampion>();
            context = new DataGathererContext();
            foreach (MyChampion c in context.Champions)
            {
                this.Champions.Add(c.ChampId, c);
            }
        }

        public ChampionStore(DataGathererContext context)
        {
            this.context = context;
            Champions = new Dictionary<long, MyChampion>();
            foreach (MyChampion c in context.Champions)
            {
                this.Champions.Add(c.ChampId, c);
            }
        }

        public void Add(MyChampion champion)
        {
            if (!Champions.ContainsKey(champion.ChampId))
            {
                Champions.Add(champion.ChampId, champion);
                context.Champions.Add(champion);
                context.SaveChanges();
            }
        }
    }
}
