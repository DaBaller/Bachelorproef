using DataGatherer.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class ParticipantMap : EntityTypeConfiguration<MyParticipant>
    {
        public ParticipantMap()
        {
            this.HasKey(t => new {t.MatchId, t.SummonerId });
            this.Property(t => t.MatchId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.SummonerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParticipantId);
            //this.Property(t => t.MatchId);
            //this.Property(t => t.SummonerId);

            this.Property(t => t.ChampionId).IsRequired();
            this.Property(t => t.Spell1Id).IsRequired();
            this.Property(t => t.Spell2Id).IsRequired();
            this.Property(t => t.TeamId).IsRequired();
            this.Property(t => t.Winner).IsRequired();

            //items nog toevoegen
            this.Property(t => t.Item0).IsOptional();
            this.Property(t => t.Item1).IsOptional();
            this.Property(t => t.Item2).IsOptional();
            this.Property(t => t.Item3).IsOptional();
            this.Property(t => t.Item4).IsOptional();
            this.Property(t => t.Item5).IsOptional();
            this.Property(t => t.Item6).IsOptional();

            this.Property(t => t.Kills).IsRequired();
            this.Property(t => t.Deaths).IsRequired();
            this.Property(t => t.Assists).IsRequired();

            this.Property(t => t.ChampLevel).IsRequired();
            this.Property(t => t.FirstBloodKill).IsOptional();
            this.Property(t => t.FirstBloodAssist).IsOptional();

            this.Property(t => t.LargestCriticalStrike).IsRequired();
            this.Property(t => t.LargestMultiKill).IsRequired();
            this.Property(t => t.MagicDamageDealt).IsRequired();
            this.Property(t => t.MagicDamageDealtToChampions).IsRequired();
            this.Property(t => t.PhysicalDamageDealt).IsRequired();
            this.Property(t => t.PhysicalDamageDealtToChampions).IsRequired();
            this.Property(t => t.TrueDamageDealt).IsRequired();
            this.Property(t => t.TrueDamageDealtToChampions).IsRequired();
            this.Property(t => t.TotalDamageDealt).IsRequired();
            this.Property(t => t.TotalDamageDealtToChampions).IsRequired();

            this.Property(t => t.MagicDamageTaken).IsRequired();
            this.Property(t => t.PhysicalDamageTaken).IsRequired();
            this.Property(t => t.TrueDamageTaken).IsRequired();
            this.Property(t => t.TotalDamageTaken).IsRequired();

            this.Property(t => t.WardsPlaced).IsRequired();
            this.Property(t => t.wardsKilled).IsRequired();
            this.Property(t => t.VisionWardsBoughtInGame).IsRequired();

            this.Property(t => t.MinionsKilled).IsRequired();
            this.Property(t => t.NeutralMinionsKilled).IsRequired();
            this.Property(t => t.NeutralMinionsKilledEnemyJungle).IsRequired();
            this.Property(t => t.NeutralMinionsKilledJungle).IsRequired();

            this.Property(t => t.TotalDamageHealed).IsRequired();
            this.Property(t => t.TotalTimeCCDealt).IsRequired();

            this.ToTable("Participants");

        }
    }
}
