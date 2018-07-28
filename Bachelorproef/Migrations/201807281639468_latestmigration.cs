namespace DataGatherer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MyMatchMyParticipant", "MyMatch_MatchId", "dbo.Matches");
            DropForeignKey("dbo.MySummonerMyMatch", "SummonerInMatch", "dbo.Matches");
            DropForeignKey("dbo.MyMatchMyParticipant", "MatchFromParticipantId", "dbo.Participants");
            DropForeignKey("dbo.MySummonerMyMatch", "MySummoner_SummonerId", "dbo.Summoners");
            DropIndex("dbo.MyMatchMyParticipant", new[] { "MatchFromParticipantId" });
            RenameColumn(table: "dbo.MyMatchMyParticipant", name: "MyMatch_MatchId", newName: "MyMatch_Id");
            RenameColumn(table: "dbo.MySummonerMyMatch", name: "MySummoner_SummonerId", newName: "MySummoner_Id");
            RenameIndex(table: "dbo.MyMatchMyParticipant", name: "IX_MyMatch_MatchId", newName: "IX_MyMatch_Id");
            RenameIndex(table: "dbo.MySummonerMyMatch", name: "IX_MySummoner_SummonerId", newName: "IX_MySummoner_Id");
            DropPrimaryKey("dbo.Matches");
            DropPrimaryKey("dbo.Participants");
            DropPrimaryKey("dbo.Summoners");
            DropPrimaryKey("dbo.MyMatchMyParticipant");
            AddColumn("dbo.Matches", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Participants", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Summoners", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Matches", "MatchId", c => c.Long(nullable: false));
            AlterColumn("dbo.Summoners", "SummonerId", c => c.Long(nullable: false));
            AlterColumn("dbo.MyMatchMyParticipant", "MatchFromParticipantId", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Matches", "Id");
            AddPrimaryKey("dbo.Participants", "Id");
            AddPrimaryKey("dbo.Summoners", "Id");
            AddPrimaryKey("dbo.MyMatchMyParticipant", new[] { "MyMatch_Id", "MatchFromParticipantId" });
            CreateIndex("dbo.MyMatchMyParticipant", "MatchFromParticipantId");
            AddForeignKey("dbo.MyMatchMyParticipant", "MyMatch_Id", "dbo.Matches", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MySummonerMyMatch", "SummonerInMatch", "dbo.Matches", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MyMatchMyParticipant", "MatchFromParticipantId", "dbo.Participants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MySummonerMyMatch", "MySummoner_Id", "dbo.Summoners", "Id", cascadeDelete: true);
            DropColumn("dbo.Participants", "CombinedId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Participants", "CombinedId", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.MySummonerMyMatch", "MySummoner_Id", "dbo.Summoners");
            DropForeignKey("dbo.MyMatchMyParticipant", "MatchFromParticipantId", "dbo.Participants");
            DropForeignKey("dbo.MySummonerMyMatch", "SummonerInMatch", "dbo.Matches");
            DropForeignKey("dbo.MyMatchMyParticipant", "MyMatch_Id", "dbo.Matches");
            DropIndex("dbo.MyMatchMyParticipant", new[] { "MatchFromParticipantId" });
            DropPrimaryKey("dbo.MyMatchMyParticipant");
            DropPrimaryKey("dbo.Summoners");
            DropPrimaryKey("dbo.Participants");
            DropPrimaryKey("dbo.Matches");
            AlterColumn("dbo.MyMatchMyParticipant", "MatchFromParticipantId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Summoners", "SummonerId", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Matches", "MatchId", c => c.Long(nullable: false, identity: true));
            DropColumn("dbo.Summoners", "Id");
            DropColumn("dbo.Participants", "Id");
            DropColumn("dbo.Matches", "Id");
            AddPrimaryKey("dbo.MyMatchMyParticipant", new[] { "MyMatch_MatchId", "MatchFromParticipantId" });
            AddPrimaryKey("dbo.Summoners", "SummonerId");
            AddPrimaryKey("dbo.Participants", "CombinedId");
            AddPrimaryKey("dbo.Matches", "MatchId");
            RenameIndex(table: "dbo.MySummonerMyMatch", name: "IX_MySummoner_Id", newName: "IX_MySummoner_SummonerId");
            RenameIndex(table: "dbo.MyMatchMyParticipant", name: "IX_MyMatch_Id", newName: "IX_MyMatch_MatchId");
            RenameColumn(table: "dbo.MySummonerMyMatch", name: "MySummoner_Id", newName: "MySummoner_SummonerId");
            RenameColumn(table: "dbo.MyMatchMyParticipant", name: "MyMatch_Id", newName: "MyMatch_MatchId");
            CreateIndex("dbo.MyMatchMyParticipant", "MatchFromParticipantId");
            AddForeignKey("dbo.MySummonerMyMatch", "MySummoner_SummonerId", "dbo.Summoners", "SummonerId", cascadeDelete: true);
            AddForeignKey("dbo.MyMatchMyParticipant", "MatchFromParticipantId", "dbo.Participants", "CombinedId", cascadeDelete: true);
            AddForeignKey("dbo.MySummonerMyMatch", "SummonerInMatch", "dbo.Matches", "MatchId", cascadeDelete: true);
            AddForeignKey("dbo.MyMatchMyParticipant", "MyMatch_MatchId", "dbo.Matches", "MatchId", cascadeDelete: true);
        }
    }
}
