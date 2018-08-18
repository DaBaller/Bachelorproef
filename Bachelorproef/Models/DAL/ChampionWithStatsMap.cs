using DataGatherer.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class ChampionWithStatsMap : EntityTypeConfiguration<MyChampionWithStats>
    {
           public ChampionWithStatsMap()
        {
            this.HasKey(t => t.ChampionId);
            this.Property(t => t.ChampionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.HasRequired(t => t.Champion)
                .WithOptional()
                .Map(m => m.MapKey("RealChampionId"))
                .WillCascadeOnDelete(false);

            //this.HasMany(t => t.MatchesWithChamp)
            //    .WithOptional()
            //    .Map(m => m.MapKey("ChampWithStatsId"))
            //    .WillCascadeOnDelete(false);

            this.Property(t => t.Armor).IsOptional();
            this.Property(t => t.HP).IsOptional();
            this.Property(t => t.HP5).IsOptional();
            this.Property(t => t.MR).IsOptional();
            this.Property(t => t.HealAndShieldPower).IsOptional();
            this.Property(t => t.Tenacity).IsOptional();
            this.Property(t => t.SlowResist).IsOptional();
            this.Property(t => t.AD).IsOptional();
            this.Property(t => t.Lethality).IsOptional();
            this.Property(t => t.ArmorPenetration).IsOptional();
            this.Property(t => t.AS).IsOptional();
            this.Property(t => t.LifeSteal).IsOptional();
            this.Property(t => t.CritChance).IsOptional();
            this.Property(t => t.AP).IsOptional();
            this.Property(t => t.MagicPenetration).IsOptional();
            this.Property(t => t.CDR).IsOptional();
            this.Property(t => t.Mana).IsOptional();
            this.Property(t => t.ManaP5).IsOptional();
            this.Property(t => t.MS).IsOptional();
            this.Property(t => t.Kills).IsOptional();
            this.Property(t => t.Deaths).IsOptional();
            this.Property(t => t.Assists).IsOptional();
            this.Property(t => t.LargestCriticalStrike).IsOptional();
            this.Property(t => t.LargestMultiKill).IsOptional();
            this.Property(t => t.MagicDamageDealt).IsOptional();
            this.Property(t => t.MagicDamageDealtToChampions).IsOptional();
            this.Property(t => t.PhysicalDamageDealt).IsOptional();
            this.Property(t => t.PhysicalDamageDealtToChampions).IsOptional();
            this.Property(t => t.TrueDamageDealt).IsOptional();
            this.Property(t => t.TrueDamageDealtToChampions).IsOptional();
            this.Property(t => t.TotalDamageDealt).IsOptional();
            this.Property(t => t.TotalDamageDealtToChampions).IsOptional();
            this.Property(t => t.MagicDamageTaken).IsOptional();
            this.Property(t => t.PhysicalDamageTaken).IsOptional();
            this.Property(t => t.TrueDamageTaken).IsOptional();
            this.Property(t => t.TotalDamageTaken).IsOptional();
            this.Property(t => t.WardsPlaced).IsOptional();
            this.Property(t => t.WardsKilled).IsOptional();
            this.Property(t => t.VisionWardsBoughtInGame).IsOptional();
            this.Property(t => t.MinionsKilled).IsOptional();
            this.Property(t => t.NeutralMinionsKilled).IsOptional();
            this.Property(t => t.NeutralMinionsKilledEnemyJungle).IsOptional();
            this.Property(t => t.NeutralMinionsKilledJungle).IsOptional();
            this.Property(t => t.TotalDamageHealed).IsOptional();
            this.Property(t => t.TotalTimeCCDealt).IsOptional();
            this.Property(t => t.Range).IsOptional();

            this.ToTable("ChampionsWithStats"); 
        }
    }
}
