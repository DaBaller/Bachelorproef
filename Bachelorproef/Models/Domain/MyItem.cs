using RiotSharp.Endpoints.StaticDataEndpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Models.Domain
{
    class MyItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int BasePrice { get; set; }
        public long ImageId { get; set; }

        public int HP { get; set; }
        public int Armor { get; set; }
        public int MR { get; set; }
        public int HP5 { get; set; }
        public int HealShieldPower { get; set; }
        public int Tenacity { get; set; }
        public int SlowResist { get; set; }

        public int AD { get; set; }
        public int Lethality { get; set; }
        public int ArmorPenetration { get; set; }
        public int AS { get; set; } 
        public int LifeSteal { get; set; }
        public int CritChance { get; set; }
        public int CritDamage { get; set; }
        public int AP { get; set; }
        public int MagicPenetration { get; set; }

        public int CDR { get; set; }
        public int Mana { get; set; }
        public int ManaP5 { get; set; }

        public int MS { get; set; }


    }
}
