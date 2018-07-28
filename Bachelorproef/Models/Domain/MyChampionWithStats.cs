using RiotSharp.Endpoints.ChampionEndpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Domain
{
    class MyChampionWithStats
    {

        
        public long ChampionStatsId { get; set; }
        

        public virtual MyChampion Champion { get; set; }

        public virtual List<MyParticipant> MatchesWithChamp { get; set; }
   
        public double Armor { get; set; }
        public double HP { get; set; }
        public double HP5 { get; set; }
        public double MR { get; set; }
        public double HealAndShieldPower { get; set; }
        public double Tenacity { get; set; }
        public double SlowResist { get; set; }

        public MyChampionWithStats()
        {

        }

        public MyChampionWithStats(long id, MyChampion champion)
        {
            this.ChampionStatsId = id;
            this.Champion = champion;
        }


    }
}
