using RiotSharp.Endpoints.StaticDataEndpoint;
using RiotSharp.Endpoints.StaticDataEndpoint.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Models.Domain
{
    public class MyItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int TotalPrice { get; set; }
        public int BasePrice { get; set; }
        public string ImageId { get; set; }

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

        public int MaxMs { get; set; }
        public int PercentMagicPen { get; set; }
        public int PercentMs { get; set; }
        public int GoldRegen { get; set; }
        public int OnHit { get; set; }
        public int OnHitPercent {get; set ;}
        public bool Melee { get; set; }
        public bool GrievousWounds { get; set; }

        MyItem()
        {

        }

        public MyItem(int itemId, string name, int totalPrice, int basePrice, string imageId, int hP, int armor, int mR, int hP5, int healShieldPower, int tenacity, int slowResist, int aD, int lethality, int armorPenetration, int aS, int lifeSteal, int critChance, int critDamage, int aP, int magicPenetration, int cDR, int mana, int manaP5, int mS, int maxms, int percentmagicpen, int percentms, int goldregen, int onhit, int onhitpercent, bool melee, bool grievousWounds)
        {
            ItemId = itemId;
            Name = name;
            TotalPrice = totalPrice;
            BasePrice = basePrice;
            ImageId = imageId;
            HP = hP;
            Armor = armor;
            MR = mR;
            HP5 = hP5;
            HealShieldPower = healShieldPower;
            Tenacity = tenacity;
            SlowResist = slowResist;
            AD = aD;
            Lethality = lethality;
            ArmorPenetration = armorPenetration;
            AS = aS;
            LifeSteal = lifeSteal;
            CritChance = critChance;
            CritDamage = critDamage;
            AP = aP;
            MagicPenetration = magicPenetration;
            CDR = cDR;
            Mana = mana;
            ManaP5 = manaP5;
            MS = mS;
            this.MaxMs = maxms;
            this.PercentMagicPen = percentmagicpen;
            this.PercentMs = percentms;
            this.GoldRegen = goldregen;
            this.OnHit = onhit;
            this.OnHitPercent = onhitpercent;
            this.Melee = melee;
            GrievousWounds = grievousWounds;
        }

        public MyItem(ItemStatic item)
        {
            ItemId = item.Id;
            Name = item.Name;
            TotalPrice = item.Gold.TotalPrice;
            BasePrice = item.Gold.BasePrice;
            ImageId = item.Image.Full;
        }


    }
}
