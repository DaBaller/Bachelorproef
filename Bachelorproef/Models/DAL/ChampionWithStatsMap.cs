using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using DataGatherer.Domain;

namespace DataGatherer.Models.DAL
{
    class ChampionWithStatsMap : EntityTypeConfiguration<MyChampionWithStats>
    {
           public ChampionWithStatsMap()
        {
            this.HasKey(t => t.ChampionStatsId);

            this.HasRequired(t => t.Champion)
                .WithMany()
                .Map(m => m.MapKey("ChampionId"))
                .WillCascadeOnDelete(false);
        }
    }
}
