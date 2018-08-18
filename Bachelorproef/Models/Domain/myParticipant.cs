using RiotSharp.Endpoints.MatchEndpoint;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataGatherer.Models.Domain
{
    public class MyParticipant
    {
        [NotMapped]
        public ItemStore Items { get; set; } 

        public long ParticipantId { get; set; }
        public long MatchId { get; set; }
        public long SummonerId { get; set; }
        public long  ChampionId { get; set; }
        
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
        public int TeamId { get; set; }
        public string Lane { get; set; }
        public string Role { get; set; }

        public bool Winner { get; set; }

        //KDA
        public long Kills { get; set; }
        public long Deaths { get; set; }
        public long Assists { get; set; }
        //level 
        public long ChampLevel { get; set; }
        //FirstBlood
        public bool FirstBloodKill { get; set; }
        public bool FirstBloodAssist { get; set; }

        //Items
        public int Item0Id { get; set; }
        public int Item1Id { get; set; }
        public int Item2Id { get; set; }
        public int Item3Id { get; set; }
        public int Item4Id { get; set; }
        public int Item5Id { get; set; }
        public int Item6Id { get ; set; }
        public  MyItem Item0 { get { return Items.Items[Item0Id]; } }
        public  MyItem Item1 { get { return Items.Items[Item1Id]; } }
        public  MyItem Item2 { get { return Items.Items[Item2Id]; } }
        public  MyItem Item3 { get { return Items.Items[Item3Id]; } }
        public  MyItem Item4 { get { return Items.Items[Item4Id]; } }
        public  MyItem Item5 { get { return Items.Items[Item5Id]; } }
        public  MyItem Item6 { get { return Items.Items[Item6Id]; } }

        //DamageDealt
        public long LargestCriticalStrike { get; set; }
        public long LargestMultiKill { get; set; }
        public long MagicDamageDealt { get; set; }
        public long MagicDamageDealtToChampions { get; set; }
        public long PhysicalDamageDealt { get; set; }
        public long PhysicalDamageDealtToChampions { get; set; }
        public long TrueDamageDealt { get; set; }
        public long TrueDamageDealtToChampions { get; set; }
        public long TotalDamageDealt { get; set; }
        public long TotalDamageDealtToChampions { get; set; }

        //DamageTaken
        public long MagicDamageTaken { get; set; }
        public long PhysicalDamageTaken { get; set; }
        public long TrueDamageTaken { get; set; }
        public long TotalDamageTaken { get; set; }

        //Wards
        public long WardsPlaced { get; set; }
        public long WardsKilled { get; set; }
        public long VisionWardsBoughtInGame { get; set; }

        //Minions
        public long MinionsKilled { get; set; }
        public long NeutralMinionsKilled { get; set; }
        public long NeutralMinionsKilledEnemyJungle { get; set; }
        public long NeutralMinionsKilledJungle { get; set; }

        public long TotalDamageHealed { get; set; }
        public long TotalTimeCCDealt { get; set; }

        public MyParticipant()
        {
            
        }

        //public MyParticipant(long participantId, long matchId, long summonerId, int championId, int spell1Id, int spell2Id, int teamId, bool winner, int kills, int deaths, int assists, long champLevel, bool firstBloodKill, bool firstBloodAssist, MyItem item0, MyItem item1, MyItem item2, MyItem item3, MyItem item4, MyItem item5, MyItem item6, long largestCriticalStrike, long largestMultiKill, long magicDamageDealt, long magicDamageDealtToChampions, long physicalDamageDealt, long physicalDamageDealtToChampions, long trueDamageDealt, long trueDamageDealtToChampions, long totalDamageDealt, long totalDamageDealtToChampions, long magicDamageTaken, long physicalDamageTaken, long trueDamageTaken, long totalDamageTaken, long wardsPlaced, long wardsKilled, long visionWardsBoughtInGame, long minionsKilled, long neutralMinionsKilled, long neutralMinionsKilledEnemyJungle, long neutralMinionsKilledJungle, long totalDamageHealed, long totalTimeCCDealt)
        //{
        //    ParticipantId = participantId;
        //    MatchId = matchId;
        //    SummonerId = summonerId;
        //    ChampionId = championId;
            
        //    Spell1Id = spell1Id;
        //    Spell2Id = spell2Id;
        //    TeamId = teamId;
        //    Winner = winner;
        //    Kills = kills;
        //    Deaths = deaths;
        //    Assists = assists;
        //    ChampLevel = champLevel;
        //    FirstBloodKill = firstBloodKill;
        //    FirstBloodAssist = firstBloodAssist;
        //    Item0 = item0;
        //    Item1 = item1;
        //    Item2 = item2;
        //    Item3 = item3;
        //    Item4 = item4;
        //    Item5 = item5;
        //    Item6 = item6;
        //    LargestCriticalStrike = largestCriticalStrike;
        //    LargestMultiKill = largestMultiKill;
        //    MagicDamageDealt = magicDamageDealt;
        //    MagicDamageDealtToChampions = magicDamageDealtToChampions;
        //    PhysicalDamageDealt = physicalDamageDealt;
        //    PhysicalDamageDealtToChampions = physicalDamageDealtToChampions;
        //    TrueDamageDealt = trueDamageDealt;
        //    TrueDamageDealtToChampions = trueDamageDealtToChampions;
        //    TotalDamageDealt = totalDamageDealt;
        //    TotalDamageDealtToChampions = totalDamageDealtToChampions;
        //    MagicDamageTaken = magicDamageTaken;
        //    PhysicalDamageTaken = physicalDamageTaken;
        //    TrueDamageTaken = trueDamageTaken;
        //    TotalDamageTaken = totalDamageTaken;
        //    WardsPlaced = wardsPlaced;
        //    this.WardsKilled = wardsKilled;
        //    VisionWardsBoughtInGame = visionWardsBoughtInGame;
        //    MinionsKilled = minionsKilled;
        //    NeutralMinionsKilled = neutralMinionsKilled;
        //    NeutralMinionsKilledEnemyJungle = neutralMinionsKilledEnemyJungle;
        //    NeutralMinionsKilledJungle = neutralMinionsKilledJungle;
        //    TotalDamageHealed = totalDamageHealed;
        //    TotalTimeCCDealt = totalTimeCCDealt;
        //}

        internal double CalculateMS(MyChampion Champion)
        {
            
            double ms = Champion.BaseMoveSpeed;
            ms += Item0.MS + Item1.MS + Item2.MS + Item3.MS + Item4.MS + Item5.MS + Item6.MS;
            double percentms = Item0.PercentMs + Item1.PercentMs + Item2.PercentMs + Item3.PercentMs + Item4.PercentMs + Item5.PercentMs + Item6.PercentMs;
            return ms * (1 + percentms / 100);
        }

        internal double  CalculateCDR()
        {
            double cdr = 0; 
            cdr+= Item0.CDR + Item1.CDR + Item2.CDR + Item3.CDR + Item4.CDR + Item5.CDR + Item6.CDR;
            if (cdr > 40)
            {
                return 40;
            }
            else return cdr;
        }

        internal double  CalculateMp5(MyChampion Champion)
        {    
            double mp5 = Champion.BaseMp5;
            mp5 *= 1+(Item0.ManaP5 + Item1.ManaP5 + Item2.ManaP5 + Item3.ManaP5 + Item4.ManaP5 + Item5.ManaP5 + Item6.ManaP5)/100; 
            mp5 += ChampLevel* Champion.Mp5PerLevel;
            return mp5;
        }

        internal double CalculateMana(MyChampion Champion)
        {    
            double mana = Champion.BaseMp;
            mana += Item0.Mana + Item1.Mana + Item2.Mana + Item3.Mana + Item4.Mana + Item5.Mana + Item6.Mana + ChampLevel * Champion.MpPerLevel;
            return mana;
        }

        internal int CalculateCritDamage()
        {
            return 0;
        }

        internal double CalculateAP(MyChampion Champion)
        {
            
            double ap = CalculateBonusAP(Champion);
            if (Champion.Name.Equals("Vladimir")) ap += CalculateBonusHp(Champion) * 0.025;
            
            return ap;
        }

        private double CalculateBonusAP(MyChampion Champion)
        {
            double ap = Item0.AP + Item1.AP + Item2.AP + Item3.AP + Item4.AP + Item5.AP + Item6.AP;
            if (Item0.Name.Contains("Rabadon") || Item1.Name.Contains("Rabadon") || Item2.Name.Contains("Rabadon") || Item3.Name.Contains("Rabadon") || Item4.Name.Contains("Rabadon") || Item5.Name.Contains("Rabadon") || Item6.Name.Contains("Rabadon")) ap *= 1.4;
            if (Item0.Name.Contains("Archangel") || Item1.Name.Contains("Archangel") || Item2.Name.Contains("Archangel") || Item3.Name.Contains("Archangel") || Item4.Name.Contains("Archangel") || Item5.Name.Contains("Archangel") || Item6.Name.Contains("Archangel")) ap += CalculateMana(Champion) *0.01;
            if (Item0.Name.Contains("Seraph") || Item1.Name.Contains("Seraph") || Item2.Name.Contains("Seraph") || Item3.Name.Contains("Seraph") || Item4.Name.Contains("Seraph") || Item5.Name.Contains("Seraph") || Item6.Name.Contains("Seraph")) ap += CalculateMana(Champion) * 0.03;
            if (Champion.Name.Equals("Viktor"))
            {
                if (Item0.Name.Contains("Prototype") || Item0.Name.Contains("mk-1") || Item0.Name.Contains("mk-2") || Item0.Name.Contains("Perfect")) ap+=(ChampLevel-1) * Item0.AP ;
                if (Item1.Name.Contains("Prototype") || Item1.Name.Contains("mk-1") || Item1.Name.Contains("mk-2") || Item1.Name.Contains("Perfect")) ap += (ChampLevel - 1) * Item1.AP;
                if (Item2.Name.Contains("Prototype") || Item2.Name.Contains("mk-1") || Item2.Name.Contains("mk-2") || Item2.Name.Contains("Perfect")) ap += (ChampLevel - 1) * Item2.AP;
                if (Item3.Name.Contains("Prototype") || Item3.Name.Contains("mk-1") || Item3.Name.Contains("mk-2") || Item3.Name.Contains("Perfect")) ap += (ChampLevel - 1) * Item3.AP;
                if (Item4.Name.Contains("Prototype") || Item4.Name.Contains("mk-1") || Item4.Name.Contains("mk-2") || Item4.Name.Contains("Perfect")) ap += (ChampLevel - 1) * Item4.AP;
                if (Item5.Name.Contains("Prototype") || Item5.Name.Contains("mk-1") || Item5.Name.Contains("mk-2") || Item5.Name.Contains("Perfect")) ap += (ChampLevel - 1) * Item5.AP;
                if (Item6.Name.Contains("Prototype") || Item6.Name.Contains("mk-1") || Item6.Name.Contains("mk-2") || Item6.Name.Contains("Perfect")) ap += (ChampLevel - 1) * Item6.AP;
            }
            return ap; 
        }

        internal double  CalculateMagicPen()
        {
            double magicpen = 0; 
            magicpen += Item0.MagicPenetration + Item1.MagicPenetration + Item2.MagicPenetration + Item3.MagicPenetration + Item4.MagicPenetration + Item5.MagicPenetration + Item6.MagicPenetration;
            return magicpen; 
        }

        internal double CalculateCritChance(MyChampion Champion)
        {
            double critchance = 0;
            critchance += Item0.CritChance + Item1.CritChance + Item2.CritChance + Item3.CritChance + Item4.CritChance + Item5.CritChance + Item6.CritChance;
            if (Champion.Name.Equals("Yasuo")) critchance *= 2;
            if (critchance > 100) return 100;
            else return critchance;
        }

        internal double CalculateAS(MyChampion Champion)
        {
            double AS = 0.625 / (1 + Champion.AttackSpeedOffset);
            double ASModifier = CalculateBonusAS(Champion) + ChampLevel * Champion.AttackSpeedPerLevel; 
            if (Champion.Name.Equals("Twisted Fate")) ASModifier += 30;
            if (Champion.Name.Equals("Kog'Maw")) ASModifier += 35;
            if(Champion.Name.Equals("Jhin")) ASModifier = ChampLevel * Champion.AttackSpeedPerLevel;
            AS *= 1 + ASModifier / 100; 
            if (AS > 2.5) return 2.5;
            
            else return AS; 
        }

        private double CalculateBonusAS(MyChampion Champion)
        {
            
            double ASModifier = Item0.AS + Item1.AS + Item2.AS + Item3.AS + Item4.AS + Item5.AS + Item6.AS;
            return ASModifier; 
        }

        internal double  CalculateArmorPen()
        {
            double aPen = 0;
            aPen += Item0.ArmorPenetration + Item1.ArmorPenetration + Item2.ArmorPenetration + Item3.ArmorPenetration + Item4.ArmorPenetration + Item4.ArmorPenetration + Item5.ArmorPenetration + Item6.ArmorPenetration;
            return aPen; 
        }

        internal double CalculateLethality()
        {
            double leth = 0;
            leth += Item0.Lethality + Item1.Lethality + Item2.Lethality + Item3.Lethality + Item4.Lethality + Item5.Lethality + Item6.Lethality;
            return leth; 
        }

        internal double  CalculateAD(MyChampion Champion)
        {
            double baseAD = Champion.BaseAD;
            double bonusAD = Item0.AD + Item1.AD + Item2.AD + Item3.AD + Item4.AD + Item5.AD + Item6.AD + ChampLevel * Champion.ADPerLevel;
            if (Item0.Name.Contains("Manamune") || Item1.Name.Contains("Manamune") || Item2.Name.Contains("Manamune") || Item3.Name.Contains("Manamune") || Item4.Name.Contains("Manamune") || Item5.Name.Contains("Manamune") || Item6.Name.Contains("Manamune") || Item0.Name.Contains("Muramana") || Item1.Name.Contains("Muramana") || Item2.Name.Contains("Muramana") || Item3.Name.Contains("Muramana") || Item4.Name.Contains("Muramana") || Item5.Name.Contains("Muramana") || Item6.Name.Contains("Muramana")) bonusAD += CalculateMana(Champion) * 0.02;
            if (Champion.Name.Equals("Hecarim")) bonusAD += CalculateMS(Champion) * 0.30;
            if (Champion.Name.Equals("Pyke")) bonusAD += CalculateHP(Champion) / 14;
            if (Champion.Name.Equals("Tryndamere")) bonusAD += 25;
            if (Champion.Name.Equals("Master Yi")) bonusAD *= 1.1;
            if (Champion.Name.Equals("Jhin")) bonusAD *= 1 + CalculateCritChance(Champion) * 0.4 + CalculateBonusAS(Champion) * 0.25;
            return baseAD + bonusAD; 
        }

        internal int CalculateSlowResist()
        {
            return Item0.SlowResist + Item1.SlowResist + Item2.SlowResist + Item3.SlowResist + Item4.SlowResist + Item5.SlowResist + Item6.SlowResist; 
        }

        internal int CalculateTenacity()
        {
            return Item0.Tenacity + Item1.Tenacity + Item2.Tenacity + Item3.Tenacity + Item4.Tenacity + Item5.Tenacity + Item6.Tenacity;
        }

        internal int CalculateHSPower()
        {
            return Item0.HealShieldPower + Item1.HealShieldPower + Item2.HealShieldPower + Item3.HealShieldPower + Item4.HealShieldPower + Item5.HealShieldPower + Item6.HealShieldPower;
        }

        internal double CalculateMR(MyChampion Champion)
        {
            double basemr = Champion.BaseMR; 
            double bonusmr = Item0.MR + Item1.MR + Item2.MR + Item3.MR + Item4.MR + Item5.MR + Item6.MR + ChampLevel*Champion.MRPerLevel;
            if (Champion.Name.Equals("Garen")) bonusmr += 30;
            if (Champion.Name.Equals("Sejuani")) bonusmr += 120; bonusmr *= 2;
            if (Champion.Name.Equals("Wukong")) bonusmr += 40;
            if (Champion.Name.Equals("Shyvana")) bonusmr += 15;
            if (Champion.Name.Equals("Olaf")) bonusmr += 40;
            if (Champion.Name.Equals("Poppy")) bonusmr *= 1.1; 
            return basemr + bonusmr;
        }

        internal double CalculateHP5(MyChampion Champion)
        {

            double mp5 = Champion.BaseHp5;
            mp5 *= 1 + (Item0.HP5 + Item1.HP5 + Item2.HP5 + Item3.HP5 + Item4.HP5 + Item5.HP5 + Item6.HP5)/ 100;
            mp5 += ChampLevel * Champion.Mp5PerLevel;
            return mp5;
        }

        internal double CalculateHP(MyChampion Champion)
        {

            double hp = Champion.BaseHp;
            double bonusHp = CalculateBonusHp(Champion); 
            if (Champion.Name.Equals("Vladimir")) bonusHp += CalculateBonusAP(Champion) * 1.4; 
            return hp + bonusHp; 
        }

        private double CalculateBonusHp(MyChampion Champion)
        {
            double bonusHp = Item0.HP + Item1.HP + Item2.HP + Item3.HP + Item4.HP + Item5.HP + Item6.HP + Champion.HpPerLevel * ChampLevel;
            if (Item0.Name.Contains("Cinderhulk") || Item1.Name.Contains("Cinderhulk") || Item2.Name.Contains("Cinderhulk") || Item3.Name.Contains("Cinderhulk") || Item4.Name.Contains("Cinderhulk") || Item5.Name.Contains("Cinderhulk") || Item6.Name.Contains("Cinderhulk")) bonusHp *= 1.15;
            if (Champion.Name.Equals("Sion")) bonusHp += 3 * MinionsKilled;
            if (Champion.Name.Equals("Pyke")) bonusHp = Champion.HpPerLevel * ChampLevel;
            return bonusHp; 
        }


        internal double CalculateArmor(MyChampion Champion)
         {
            double baseArmor = Champion.BaseArmor;
            double bonusArmor = Item0.Armor + Item1.Armor + Item2.Armor + Item3.Armor + Item4.Armor + Item5.Armor + Item6.Armor + Champion.ArmorPerLevel * ChampLevel;
            if (Champion.Name.Equals("Malphite")) bonusArmor *= 1.9;
            if (Champion.Name.Equals("Shyvana")) bonusArmor += 15;
            if (Champion.Name.Equals("Wukong")) bonusArmor += 40;
            if (Champion.Name.Equals("Poppy")) bonusArmor *= 1.1;
            if (Champion.Name.Equals("Sejuani")) bonusArmor += 120;
            if (Champion.Name.Equals("Olaf")) bonusArmor += 40;
            if (Champion.Name.Equals("Garen")) bonusArmor += 40; 
            double armor = baseArmor + bonusArmor; 
            if (Champion.Name.Equals("Taric")) armor += 1.2;
            return armor; 
        }

        public MyParticipant(Participant participant, MyChampion champion, List<MyItem> items, long matchId, long summonerId, string lane, string role )
        {

            ParticipantId = participant.ParticipantId;
            MatchId = matchId;
            SummonerId = summonerId;
           
            ChampionId = champion.ChampId;
            Spell1Id = participant.Spell1Id;
            Spell2Id = participant.Spell2Id;
            TeamId = participant.TeamId;
            Lane = lane;
            Role = role;
            Winner = participant.Stats.Winner;
            Kills = participant.Stats.Kills;
            Deaths = participant.Stats.Deaths;
            Assists = participant.Stats.Assists;
            ChampLevel = participant.Stats.ChampLevel;
            FirstBloodKill = participant.Stats.FirstBloodKill;
            FirstBloodAssist = participant.Stats.FirstBloodAssist;
            Item0Id = items[0].ItemId;
            Item1Id = items[1].ItemId;
            Item2Id = items[2].ItemId;
            Item3Id = items[3].ItemId;
            Item4Id = items[4].ItemId;
            Item5Id = items[5].ItemId;
            Item6Id = items[6].ItemId;
            LargestCriticalStrike = participant.Stats.LargestCriticalStrike;
            LargestMultiKill = participant.Stats.LargestMultiKill;
            MagicDamageDealt = participant.Stats.MagicDamageDealt;
            MagicDamageDealtToChampions = participant.Stats.MagicDamageDealtToChampions;
            PhysicalDamageDealt = participant.Stats.PhysicalDamageDealt;
            PhysicalDamageDealtToChampions = participant.Stats.PhysicalDamageDealtToChampions;
            TrueDamageDealt = participant.Stats.TrueDamageDealt;
            TrueDamageDealtToChampions = participant.Stats.TrueDamageDealtToChampions;
            TotalDamageDealt = participant.Stats.TotalDamageDealt;
            TotalDamageDealtToChampions = participant.Stats.TotalDamageDealtToChampions;
            MagicDamageTaken = participant.Stats.MagicDamageTaken;
            PhysicalDamageTaken = participant.Stats.PhysicalDamageTaken;
            TrueDamageTaken = participant.Stats.TrueDamageTaken;
            TotalDamageTaken = participant.Stats.TotalDamageTaken;
            WardsPlaced = participant.Stats.WardsPlaced;
            this.WardsKilled = participant.Stats.WardsKilled;
            VisionWardsBoughtInGame = participant.Stats.VisionWardsBoughtInGame;
            MinionsKilled = participant.Stats.MinionsKilled;
            NeutralMinionsKilled = participant.Stats.NeutralMinionsKilled;
            NeutralMinionsKilledEnemyJungle = participant.Stats.NeutralMinionsKilledEnemyJungle;
            NeutralMinionsKilledJungle = participant.Stats.NeutralMinionsKilledJungle;
            TotalDamageHealed = participant.Stats.TotalHeal;
            TotalTimeCCDealt = participant.Stats.TotalTimeCrowdControlDealt;
        }
        [NotMapped]
        public MySummoner Summoner
        {
            get;
            set;
        }
        [NotMapped]
        public MyMatch Match
        {
            get;
            set;
        }
        [NotMapped]
        public MyChampion Champion
        {
            get;
            set;
        }
    }
}
