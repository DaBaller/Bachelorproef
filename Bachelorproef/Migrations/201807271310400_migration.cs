namespace DataGatherer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MyMatch", newName: "Matches");
            RenameTable(name: "dbo.MyParticipant", newName: "Participants");
            RenameTable(name: "dbo.MySummoner", newName: "Summoners");
            RenameTable(name: "dbo.MyChampion", newName: "Champions");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Champions", newName: "MyChampion");
            RenameTable(name: "dbo.Summoners", newName: "MySummoner");
            RenameTable(name: "dbo.Participants", newName: "MyParticipant");
            RenameTable(name: "dbo.Matches", newName: "MyMatch");
        }
    }
}
