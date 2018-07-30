using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class SummonerMap : EntityTypeConfiguration<MySummoner>
    {
        public SummonerMap() {

            //this.HasKey(t => t.Id);

            this.HasKey(t => t.SummonerId);
            this.Property(t => t.SummonerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.SummonerName).IsRequired();
            this.Property(t => t.Tier).IsOptional();

            this.ToTable("Summoners");

            this.HasMany(t => t.MatchHistory)
                .WithMany()
                .Map(m => m.MapLeftKey("MatchInHistoryId"))
                .Map(m => m.MapRightKey("SummonerInMatch"));
        }
    }
}
