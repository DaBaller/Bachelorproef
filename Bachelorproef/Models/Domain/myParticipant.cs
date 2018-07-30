using RiotSharp.Endpoints.MatchEndpoint;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataGatherer.Domain
{
    class MyParticipant
    {
        public long ParticipantId { get; set; }
        public long MatchId { get; set; }
        public long SummonerId { get; set; }
        public long ChampionId { get; set; }
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
        public long Item0 { get; set; }
        public long Item1 { get; set; }
        public long Item2 { get; set; }
        public long Item3 { get; set; }
        public long Item4 { get; set; }
        public long Item5 { get; set; }
        public long Item6 { get; set; }

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
        public long wardsKilled { get; set; }
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

        public MyParticipant(long participantId, long matchId, long summonerId, long championId, int spell1Id, int spell2Id, int teamId, bool winner, long kills, long deaths, long assists, long champLevel, bool firstBloodKill, bool firstBloodAssist, long item0, long item1, long item2, long item3, long item4, long item5, long item6, long largestCriticalStrike, long largestMultiKill, long magicDamageDealt, long magicDamageDealtToChampions, long physicalDamageDealt, long physicalDamageDealtToChampions, long trueDamageDealt, long trueDamageDealtToChampions, long totalDamageDealt, long totalDamageDealtToChampions, long magicDamageTaken, long physicalDamageTaken, long trueDamageTaken, long totalDamageTaken, long wardsPlaced, long wardsKilled, long visionWardsBoughtInGame, long minionsKilled, long neutralMinionsKilled, long neutralMinionsKilledEnemyJungle, long neutralMinionsKilledJungle, long totalDamageHealed, long totalTimeCCDealt)
        {
            ParticipantId = participantId;
            MatchId = matchId;
            SummonerId = summonerId;

            ChampionId = championId;
            Spell1Id = spell1Id;
            Spell2Id = spell2Id;
            TeamId = teamId;
            Winner = winner;
            Kills = kills;
            Deaths = deaths;
            Assists = assists;
            ChampLevel = champLevel;
            FirstBloodKill = firstBloodKill;
            FirstBloodAssist = firstBloodAssist;
            Item0 = item0;
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
            LargestCriticalStrike = largestCriticalStrike;
            LargestMultiKill = largestMultiKill;
            MagicDamageDealt = magicDamageDealt;
            MagicDamageDealtToChampions = magicDamageDealtToChampions;
            PhysicalDamageDealt = physicalDamageDealt;
            PhysicalDamageDealtToChampions = physicalDamageDealtToChampions;
            TrueDamageDealt = trueDamageDealt;
            TrueDamageDealtToChampions = trueDamageDealtToChampions;
            TotalDamageDealt = totalDamageDealt;
            TotalDamageDealtToChampions = totalDamageDealtToChampions;
            MagicDamageTaken = magicDamageTaken;
            PhysicalDamageTaken = physicalDamageTaken;
            TrueDamageTaken = trueDamageTaken;
            TotalDamageTaken = totalDamageTaken;
            WardsPlaced = wardsPlaced;
            this.wardsKilled = wardsKilled;
            VisionWardsBoughtInGame = visionWardsBoughtInGame;
            MinionsKilled = minionsKilled;
            NeutralMinionsKilled = neutralMinionsKilled;
            NeutralMinionsKilledEnemyJungle = neutralMinionsKilledEnemyJungle;
            NeutralMinionsKilledJungle = neutralMinionsKilledJungle;
            TotalDamageHealed = totalDamageHealed;
            TotalTimeCCDealt = totalTimeCCDealt;
        }

        public MyParticipant(Participant participant, long matchId, long summonerId, string lane, string role )
        {

            ParticipantId = participant.ParticipantId;
            MatchId = matchId;
            SummonerId = summonerId;
           
            ChampionId = participant.ChampionId;
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
            Item0 = participant.Stats.Item0;
            Item1 = participant.Stats.Item1;
            Item2 = participant.Stats.Item2;
            Item3 = participant.Stats.Item3;
            Item4 = participant.Stats.Item4;
            Item5 = participant.Stats.Item5;
            Item6 = participant.Stats.Item6;
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
            this.wardsKilled = participant.Stats.WardsKilled;
            VisionWardsBoughtInGame = participant.Stats.VisionWardsBoughtInGame;
            MinionsKilled = participant.Stats.MinionsKilled;
            NeutralMinionsKilled = participant.Stats.NeutralMinionsKilled;
            NeutralMinionsKilledEnemyJungle = participant.Stats.NeutralMinionsKilledEnemyJungle;
            NeutralMinionsKilledJungle = participant.Stats.NeutralMinionsKilledJungle;
            TotalDamageHealed = participant.Stats.TotalHeal;
            TotalTimeCCDealt = participant.Stats.TotalTimeCrowdControlDealt;
        }

    }
}
