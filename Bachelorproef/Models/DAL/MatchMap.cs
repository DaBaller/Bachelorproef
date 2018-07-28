using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class MatchMap : EntityTypeConfiguration<MyMatch>
    {
        public MatchMap()
        {
            this.HasKey(t => t.Id);
            
            this.Property(t => t.MatchId);
            this.Property(t => t.GameCreation).IsOptional();
            this.Property(t => t.MatchDuration).IsOptional();

            this.ToTable("Matches");

            this.HasMany(t => t.Participants)
                .WithMany()
                .Map(m => m.MapLeftKey("ParticipantInMatchId"))
                .Map(m => m.MapRightKey("MatchFromParticipantId"));
        }
    }
}
