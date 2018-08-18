using DataGatherer.Models.DAL;
using DataGatherer.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyzer.Domain
{
    public class Analyzer
    {

        public ParticipantStore participantStore { get; set; }
        public ChampionWithStatsStore championWithStatsStore { get; set; }
        public ChampionStore champStore { get; set; }
        public ItemStore Items { get; set; }
        public Dictionary<MyChampion, int> counter = new Dictionary<MyChampion,int>(); 

        private DataGathererContext context = new DataGathererContext();
        

        public Analyzer()
        {
            participantStore = new ParticipantStore();
            championWithStatsStore = new ChampionWithStatsStore(context);
            champStore = new ChampionStore(context);
            Items = new ItemStore(context);
        }


        private void GatherChampionStats(MyChampion champ)
        {
            List<MyParticipant> matches = participantStore.GetParticipantsWithChamp(champ.ChampId);
            counter.Add(champ, matches.Count);

            List<KeyValuePair<MyChampion, int>> counter2 = counter.OrderByDescending(t => t.Value).ToList();

            foreach(KeyValuePair<MyChampion, int> c in counter2)
            {
                Console.WriteLine(c.Value + " matches with" + c.Key.Name);
            }

            //Console.WriteLine(matches.Count+"matches with champion "+ champ.Name +" found");
            //MyChampionWithStats championWithStats = new MyChampionWithStats(champ, matches,Items);
            //championWithStatsStore.Add(championWithStats);
        }

        public void GatherStats()
        {
            foreach (MyChampion c in champStore.Champions.Values)
            {
                GatherChampionStats(c);
                Console.WriteLine("Stats gathered for "+ c.Name);
            }
        }
    }
}
