using DataGatherer.Models.DAL;
using DataGatherer.Models.Domain;
using System.Collections.Generic;

namespace DataAnalyzer.Domain
{
    public class ChampionWithStatsStore
    {

        public Dictionary<long, MyChampionWithStats> ChampionsWithStats { get; set; }

        private DataGathererContext context;

        public ChampionWithStatsStore()
        {
            ChampionsWithStats = new Dictionary<long, MyChampionWithStats>();
        }

        public ChampionWithStatsStore(DataGathererContext context)
        {
            this.context = context;
            ChampionsWithStats = new Dictionary<long, MyChampionWithStats>();
            foreach (MyChampionWithStats c in context.ChampionsWithStats)
            {
                this.ChampionsWithStats.Add(c.ChampionId, c);
            }
        }

        public void Add(MyChampionWithStats champion)
        {
            if (!ChampionsWithStats.ContainsKey(champion.ChampionId))
            {
                ChampionsWithStats.Add(champion.ChampionId, champion);
                context.ChampionsWithStats.Add(champion);
                context.SaveChanges();
            }
        }
    }
}