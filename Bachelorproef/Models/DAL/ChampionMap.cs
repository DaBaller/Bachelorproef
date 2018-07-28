using DataGatherer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class ChampionMap : EntityTypeConfiguration<MyChampion>
    {
        public ChampionMap()
        {
            this.HasKey(t => t.ChampId);

            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.ResourceType).IsRequired();
            this.Property(t => t.Passive).IsRequired();
            this.Property(t => t.BaseArmor).IsRequired();
            this.Property(t => t.ArmorPerLevel).IsRequired();
            this.Property(t => t.Mp5PerLevel).IsRequired();
            this.Property(t => t.BaseMp5).IsRequired();
            this.Property(t => t.Hp5PerLevel).IsRequired();
            this.Property(t => t.BaseHp).IsRequired();
            this.Property(t => t.BaseAD).IsRequired();

            this.ToTable("Champions");
        }
    }
}
