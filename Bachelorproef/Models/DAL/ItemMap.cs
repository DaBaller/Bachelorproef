using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataGatherer.Models.Domain;

namespace DataGatherer.Models.DAL
{
    class ItemMap : EntityTypeConfiguration<MyItem>
    {
        public ItemMap()
        {
            this.HasKey(t => t.ItemId);
            this.Property(t => t.ItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TotalPrice).IsRequired();
            this.Property(t => t.BasePrice).IsRequired();
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.ImageId).IsRequired();

            this.Property(t => t.HP).IsOptional();
            this.Property(t => t.Armor).IsOptional();
            this.Property(t => t.MR).IsOptional();
            this.Property(t => t.HP5).IsOptional();
            this.Property(t => t.HealShieldPower).IsOptional();
            this.Property(t => t.Tenacity).IsOptional();
            this.Property(t => t.SlowResist).IsOptional();
            this.Property(t => t.AD).IsOptional();
            this.Property(t => t.Lethality).IsOptional();
            this.Property(t => t.ArmorPenetration).IsOptional();
            this.Property(t => t.AS).IsOptional();
            this.Property(t => t.LifeSteal).IsOptional();
            this.Property(t => t.CritChance).IsOptional();
            this.Property(t => t.CritDamage).IsOptional();
            this.Property(t => t.AP).IsOptional();
            this.Property(t => t.MagicPenetration).IsOptional();
            this.Property(t => t.CDR).IsOptional();
            this.Property(t => t.Mana).IsOptional();
            this.Property(t => t.ManaP5).IsOptional();
            this.Property(t => t.MS).IsOptional();
            this.Property(t => t.MaxMs).IsOptional();
            this.Property(t => t.PercentMagicPen).IsOptional();
            this.Property(t => t.PercentMs).IsOptional();
            this.Property(t => t.GoldRegen).IsOptional();
            this.Property(t => t.Melee).IsOptional();
            this.Property(t => t.GrievousWounds).IsOptional();
            this.Property(t => t.OnHitPercent).IsOptional();
            this.Property(t => t.OnHit).IsOptional(); 

            this.ToTable("Items");
        }
        
    }
}
