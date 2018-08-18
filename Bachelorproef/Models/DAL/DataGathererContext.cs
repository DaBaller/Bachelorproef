using DataGatherer.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using System.Text;

namespace DataGatherer.Models.DAL
{
    public class DataGathererContext : DbContext
    {

        public DbSet<MySummoner> Summoners { get; set; }
        public DbSet<MyMatch> Matches { get; set; }
        public DbSet<MyItem> Items { get; set; }
        public DbSet<MyChampion> Champions { get; set; }
        public DbSet<MyChampionWithStats> ChampionsWithStats { get; set; }
        public DbSet<MyParticipant> Participants { get; set; }

        public DataGathererContext() : base("BachelorProef1718")
        {
            Database.SetInitializer<DataGathererContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
