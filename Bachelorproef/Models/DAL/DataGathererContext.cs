using DataGatherer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using System.Text;

namespace DataGatherer.Models.DAL
{
    class DataGathererContext : DbContext
    {

        public DbSet<MySummoner> Summoners { get; set; }
        public DbSet<MyMatch> Matches { get; set; }
        //public DbSet<MyChampionWithStats> ChampionsWithStats {get; set;}

        public DataGathererContext() : base("BachelorProef1718")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
