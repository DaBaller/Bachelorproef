using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class MatchMap : EntityTypeConfiguration<MyMatch>
    {
        public MatchMap()
        {

            this.HasKey(t => t.MatchId);
            this.Property(t => t.MatchId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.GameCreation).IsOptional();
            this.Property(t => t.MatchDuration).IsOptional();

            this.ToTable("Matches");

            this.HasMany(t => t.Participants)
                .WithMany()
                .Map(m => m.MapLeftKey("ParticipantInMatchId"))
                .Map(m => m.MapRightKey(new string [] { "matchid", "summonerid" }));
        }
    }
}
