using RiotSharp.Endpoints.ChampionEndpoint;
using RiotSharp.Endpoints.StaticDataEndpoint;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Domain
{
    class MyChampion
    {
        public long ChampId { get; set; }
        public string Name { get; set; }
        public string ImageId { get; set; }
        public string Passive { get; set; }

        //public List<ChampionSpellStatic> Spells { get; set; }

        public double BaseArmor { get; set; }
        public double Mp5PerLevel { get; set; }
        public double BaseMp5 { get; set; }
        public double MpPerLevel { get; set; }
        public double BaseMp { get; set; }
        public double BaseMoveSpeed { get; set; }
        public double Hp5PerLevel { get; set; }
        public double BaseHp5 { get; set; }
        public double HpPerLevel { get; set; }
        public double BaseHp { get; set; }
        public double CritPerLevel { get; set; }
        public double BaseCrit { get; set; }
        public double AttackSpeedPerLevel { get; set; }
        public double AttackSpeedOffset { get; set; }
        public double AttackRange { get; set; }
        public double ADPerLevel { get; set; }
        public double BaseAD { get; set; }
        public double ArmorPerLevel { get; set; }
        public double BaseMR { get; set; }
        public double MRPerLevel { get; set; }
        public string ResourceType { get; set; }

        public MyChampion(long champId, string name, string imageId, string passive, /*List<ChampionSpellStatic> spells,*/ double baseArmor, double mp5PerLevel, double baseMp5, double mpPerLevel, double baseMp, double baseMoveSpeed, double hp5PerLevel, double baseHp5, double hpPerLevel, double baseHp, double critPerLevel, double baseCrit, double attackSpeedPerLevel, double attackSpeedOffset, double attackRange, double aDPerLevel, double baseAD, double armorPerLevel, double baseMR, double mRPerLevel, string resourceType)
        {
            ChampId = champId;
            Name = name;
            ImageId = imageId;
            Passive = passive;
            //Spells = spells;
            BaseArmor = baseArmor;
            Mp5PerLevel = mp5PerLevel;
            BaseMp5 = baseMp5;
            MpPerLevel = mpPerLevel;
            BaseMp = baseMp;
            BaseMoveSpeed = baseMoveSpeed;
            Hp5PerLevel = hp5PerLevel;
            BaseHp5 = baseHp5;
            HpPerLevel = hpPerLevel;
            BaseHp = baseHp;
            CritPerLevel = critPerLevel;
            BaseCrit = baseCrit;
            AttackSpeedPerLevel = attackSpeedPerLevel;
            AttackSpeedOffset = attackSpeedOffset;
            AttackRange = attackRange;
            ADPerLevel = aDPerLevel;
            BaseAD = baseAD;
            ArmorPerLevel = armorPerLevel;
            BaseMR = baseMR;
            MRPerLevel = mRPerLevel;
            ResourceType = resourceType;
        }

        public MyChampion(ChampionStatic champion)
        {
            ChampId = champion.Id;
            Name = champion.Name;
            ImageId = champion.Image.Full;
            Passive = champion.Passive.SanitizedDescription;
            //Spells = spells;
            BaseArmor = champion.Stats.Armor;
            Mp5PerLevel = champion.Stats.MpRegenPerLevel;
            BaseMp5 = champion.Stats.MpRegen;
            MpPerLevel = champion.Stats.MpPerLevel;
            BaseMp = champion.Stats.Mp;
            BaseMoveSpeed = champion.Stats.MoveSpeed;
            Hp5PerLevel = champion.Stats.HpRegenPerLevel;
            BaseHp5 = champion.Stats.HpRegen;
            HpPerLevel = champion.Stats.HpPerLevel;
            BaseHp = champion.Stats.Hp;
            CritPerLevel = champion.Stats.CritPerLevel;
            BaseCrit = champion.Stats.Crit;
            AttackSpeedPerLevel = champion.Stats.AttackSpeedPerLevel;
            AttackSpeedOffset = champion.Stats.AttackSpeedOffset;
            AttackRange = champion.Stats.AttackRange;
            ADPerLevel = champion.Stats.AttackDamagePerLevel;
            BaseAD = champion.Stats.AttackDamage;
            ArmorPerLevel = champion.Stats.ArmorPerLevel;
            BaseMR = champion.Stats.SpellBlock;
            MRPerLevel = champion.Stats.SpellBlockPerLevel;
            ResourceType = champion.Partype;
        }

    }
}
