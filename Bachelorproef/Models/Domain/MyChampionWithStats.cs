using RiotSharp.Endpoints.ChampionEndpoint;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace DataGatherer.Models.Domain
{
    public class MyChampionWithStats
    {        
        public long ChampionId { get; set; }
        
        public virtual MyChampion Champion { get; set; }

        [NotMapped]
        public List<MyParticipant> MatchesWithChamp { get; set; }

        public double Range { get; set; }
        public double Armor { get; set; }
        public double HP { get; set; }
        public double HP5 { get; set; }
        public double MR { get; set; }
        public double HealAndShieldPower { get; set; }
        public double Tenacity { get; set; }
        public double SlowResist { get; set; }

        public double AD { get; set; }
        public double Lethality { get; set; }
        public double ArmorPenetration { get; set; }
        public double AS { get; set; }
        public double LifeSteal { get; set; }
        public double CritChance { get; set; }
        public double CritDamage { get; set; }
        public double AP { get; set; }
        public double MagicPenetration { get; set; }

        public double CDR { get; set; }
        public double Mana { get; set; }
        public double ManaP5 { get; set; }

        public double MS { get; set; }

        public double  Kills { get; set; }
        public double  Deaths { get; set; }
        public double Assists { get; set; }

        public double LargestCriticalStrike { get; set; }
        public double LargestMultiKill { get; set; }
        public double MagicDamageDealt { get; set; }
        public double MagicDamageDealtToChampions { get; set; }
        public double PhysicalDamageDealt { get; set; }
        public double PhysicalDamageDealtToChampions { get; set; }
        public double TrueDamageDealt { get; set; }
        public double TrueDamageDealtToChampions { get; set; }
        public double TotalDamageDealt { get; set; }
        public double TotalDamageDealtToChampions { get; set; }

        public double MagicDamageTaken { get; set; }
        public double PhysicalDamageTaken { get; set; }
        public double TrueDamageTaken { get; set; }
        public double TotalDamageTaken { get; set; }

        public double WardsPlaced { get; set; }
        public double WardsKilled { get; set; }
        public double VisionWardsBoughtInGame { get; set; }

        public double MinionsKilled { get; set; }
        public double NeutralMinionsKilled { get; set; }
        public double NeutralMinionsKilledEnemyJungle { get; set; }
        public double NeutralMinionsKilledJungle { get; set; }

        public double  TotalDamageHealed { get; set; }
        public double TotalTimeCCDealt { get; set; }

        public double WinPercentage { get; set; } 
        public double FirstBloodPercentage { get; set; }

        public MyChampionWithStats()
        {

        }

        public MyChampionWithStats(MyChampion champion)
        {
            this.ChampionId = champion.ChampId;
            this.Champion = champion;
        }

        public MyChampionWithStats(MyChampion champ, List<MyParticipant> p, ItemStore items)
        {
            ChampionId = champ.ChampId;
            Champion = champ;
            MatchesWithChamp = p;
            CalculateMeans(items); 
        }

        public void CalculateMeans(ItemStore items)
        {
            Console.WriteLine("Busy calculating");
            int nrofmatches = MatchesWithChamp.Count;
            double sumArmor = 0, sumHP = 0, sumHP5 = 0, sumMR = 0, sumHSPower = 0, sumTenacity = 0, sumSlowResist = 0, sumAD = 0, sumLethality = 0, sumArmorPen = 0, sumAS = 0, sumLS = 0, sumCritChance = 0, sumCritDamage = 0, sumAP = 0, sumMagicPenetration = 0, sumCDR = 0, sumMana = 0, sumMP5 = 0, sumMS = 0, sumKills = 0, sumDeaths = 0, sumAssists = 0, sumDamageDealt = 0, sumDamageDealtToChampions = 0, sumPhysicalDamageToChampions = 0, sumPhysicalDamageDealt = 0, sumMagicDamageDealt = 0, sumMagicDamageToChampions = 0, sumTrueDamageDealt = 0, sumTrueDamageDealtToChampions = 0, sumWardsPlaced = 0, sumVisionWardsBought = 0, sumWardsKilled = 0, winPercentage = 0, sumDamageTaken = 0, sumPhysicalDamageTaken = 0, sumMagicDamageTaken = 0, sumTrueDamageTaken = 0, sumCC = 0, sumCreepscore = 0, sumJungleCreeps = 0, sumEnemyJungleCreeps = 0, sumOwnJungleCreeps = 0, sumFirstBloodPercentage = 0, sumHeal = 0, sumLargestCrit = 0, sumMultiKill =0;

            foreach (MyParticipant p in MatchesWithChamp)
            {
                p.Items = items;
                sumArmor+=p.CalculateArmor(Champion);
                sumHP += p.CalculateHP(Champion);
                sumHP5 += p.CalculateHP5(Champion);
                sumMR += p.CalculateMR(Champion);
                sumHSPower += p.CalculateHSPower();
                sumTenacity += p.CalculateTenacity();
                sumSlowResist += p.CalculateSlowResist();
                sumAD += p.CalculateAD(Champion);
                sumLethality += p.CalculateLethality();
                sumArmorPen += p.CalculateArmorPen();
                sumAS += p.CalculateAS(Champion);
                sumLS += p.CalculateCritChance(Champion);
                sumCritChance += p.CalculateCritChance(Champion);
                sumCritDamage += p.CalculateCritDamage();
                sumAP += p.CalculateAP(Champion);
                sumMagicPenetration += p.CalculateMagicPen();
                sumMana += p.CalculateMana(Champion);
                sumMP5 += p.CalculateMp5(Champion);
                sumCDR += p.CalculateCDR();
                sumMS += p.CalculateMS(Champion);
                sumKills += p.Kills;
                sumDeaths += p.Deaths;
                sumAssists += p.Assists;
                sumDamageDealt += (int) p.TotalDamageDealt;
                sumDamageDealtToChampions += (int) p.TotalDamageDealtToChampions;
                sumPhysicalDamageDealt += (int) p.PhysicalDamageDealt;
                sumPhysicalDamageToChampions += (int) p.PhysicalDamageDealtToChampions;
                sumMagicDamageDealt += (int) p.MagicDamageDealt;
                sumMagicDamageToChampions += (int) p.MagicDamageDealtToChampions;
                sumTrueDamageDealt += (int) p.TrueDamageDealt;
                sumTrueDamageDealtToChampions += (int) p.TrueDamageDealtToChampions;
                sumWardsPlaced += (int) p.WardsPlaced;
                sumVisionWardsBought += (int) p.VisionWardsBoughtInGame;
                sumWardsKilled += (int) p.WardsKilled;
                if (p.Winner)
                {
                    winPercentage++;
                }
                sumDamageTaken += (int) p.TotalDamageTaken;
                sumPhysicalDamageTaken += (int) p.PhysicalDamageTaken;
                sumMagicDamageTaken +=  (int) p.MagicDamageTaken;
                sumTrueDamageTaken += (int) p.TrueDamageTaken;
                sumCC += (int) p.TotalTimeCCDealt;
                sumCreepscore += (int) p.MinionsKilled;
                sumJungleCreeps +=  (int) p.NeutralMinionsKilled;
                sumEnemyJungleCreeps += (int) p.NeutralMinionsKilledEnemyJungle;
                sumOwnJungleCreeps += (int) p.NeutralMinionsKilledJungle;
                if (p.FirstBloodKill || p.FirstBloodAssist)
                {
                    sumFirstBloodPercentage++;
                }
                sumHeal += p.TotalDamageHealed;
                sumLargestCrit += p.LargestCriticalStrike;
                sumMultiKill += p.LargestMultiKill;
            }
            Console.WriteLine("loop done");
            Armor = sumArmor / nrofmatches;
            HP = sumHP / nrofmatches;
            HP5 = sumHP5 / nrofmatches;
            Mana = sumMana / nrofmatches;
            ManaP5 = sumMP5 / nrofmatches;
            MR = sumMR / nrofmatches;
            HealAndShieldPower = sumHSPower / nrofmatches;
            Tenacity = sumTenacity / nrofmatches;
            SlowResist = sumSlowResist / nrofmatches;

            AD = sumAD / nrofmatches;
            Lethality = sumLethality / nrofmatches;
            ArmorPenetration = sumArmorPen / nrofmatches;
            AS = sumAS / nrofmatches;
            LifeSteal = sumLS / nrofmatches;
            CritChance = sumCritChance / nrofmatches;
            CritDamage = sumCritDamage / nrofmatches;
            AP = sumAP / nrofmatches;
            MagicPenetration = sumMagicPenetration / nrofmatches;

            CDR = sumCDR / nrofmatches;

            MS = sumMS / nrofmatches;

            Kills = sumKills / nrofmatches;
            Deaths = sumDeaths / nrofmatches;
            Assists = sumAssists / nrofmatches;

            LargestCriticalStrike = sumLargestCrit / nrofmatches;
            LargestMultiKill = sumMultiKill / nrofmatches;
            MagicDamageDealt = sumMagicDamageDealt / nrofmatches;
            MagicDamageDealtToChampions = sumMagicDamageToChampions / nrofmatches;
            PhysicalDamageDealt = PhysicalDamageDealt / nrofmatches;
            PhysicalDamageDealtToChampions = sumPhysicalDamageToChampions / nrofmatches;
            TrueDamageDealt = sumTrueDamageDealt / nrofmatches;
            TrueDamageDealtToChampions = sumTrueDamageDealtToChampions / nrofmatches;
            TotalDamageDealt = sumDamageDealt / nrofmatches;
            TotalDamageDealtToChampions = sumDamageDealtToChampions / nrofmatches;

            MagicDamageTaken = sumMagicDamageTaken / nrofmatches;
            PhysicalDamageTaken = sumPhysicalDamageTaken / nrofmatches;
            TrueDamageTaken = TrueDamageTaken / nrofmatches;
            TotalDamageTaken = sumDamageTaken / nrofmatches;

            WardsPlaced = sumWardsPlaced / nrofmatches;
            WardsKilled = sumWardsKilled / nrofmatches;
            VisionWardsBoughtInGame = sumVisionWardsBought / nrofmatches;

            MinionsKilled = sumCreepscore / nrofmatches;
            NeutralMinionsKilled = sumJungleCreeps / nrofmatches;
            NeutralMinionsKilledEnemyJungle = sumEnemyJungleCreeps / nrofmatches;
            NeutralMinionsKilledJungle = sumOwnJungleCreeps / nrofmatches;

            TotalDamageHealed = sumHeal / nrofmatches;
            TotalTimeCCDealt = sumCC / nrofmatches;
            WinPercentage = winPercentage / nrofmatches;
            FirstBloodPercentage = sumFirstBloodPercentage / nrofmatches;
            Range = Champion.AttackRange;
        }


    }
}
