using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Domain
{
    class ChampionStore
    {

        public Dictionary<int, MyChampionWithStats> Champions { get; set; } 

        public ChampionStore()
        {
            Champions = new Dictionary<int, MyChampionWithStats>();
        }
    }
}
