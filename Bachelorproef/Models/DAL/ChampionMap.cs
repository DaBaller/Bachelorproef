using DataGatherer.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class ChampionMap : EntityTypeConfiguration<MyChampion>
    {
        public ChampionMap()
        {
            this.HasKey(t => t.ChampId);
            this.Property(t => t.ChampId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.ResourceType).IsRequired();
            this.Property(t => t.ImageId).IsRequired();
            this.Property(t => t.Passive).IsRequired();
            this.Property(t => t.BaseArmor).IsRequired();
            this.Property(t => t.ArmorPerLevel).IsRequired();
            this.Property(t => t.Mp5PerLevel).IsRequired();
            this.Property(t => t.BaseMp5).IsRequired();
            this.Property(t => t.BaseMp).IsRequired();
            this.Property(t => t.MpPerLevel).IsRequired();
            this.Property(t => t.BaseHp5).IsRequired();
            this.Property(t => t.Hp5PerLevel).IsRequired();
            this.Property(t => t.BaseHp).IsRequired();
            this.Property(t => t.HpPerLevel).IsRequired();
            this.Property(t => t.BaseAD).IsRequired();
            this.Property(t => t.ADPerLevel).IsRequired();
            this.Property(t => t.BaseMR).IsRequired();
            this.Property(t => t.MRPerLevel).IsRequired();
            this.Property(t => t.BaseCrit).IsRequired();
            this.Property(t => t.CritPerLevel).IsRequired();
            this.Property(t => t.AttackSpeedPerLevel).IsRequired();
            this.Property(t => t.AttackSpeedOffset).IsRequired();
            this.Property(t => t.AttackRange).IsRequired();
            this.Property(t => t.BaseMoveSpeed).IsRequired();

            this.ToTable("Champions");
        }
    }
}
