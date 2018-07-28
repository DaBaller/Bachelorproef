namespace DataGatherer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyMatch",
                c => new
                    {
                        MatchId = c.Long(nullable: false, identity: true),
                        GameCreation = c.Long(),
                        MatchDuration = c.Long(),
                    })
                .PrimaryKey(t => t.MatchId);
            
            CreateTable(
                "dbo.MyParticipant",
                c => new
                    {
                        CombinedId = c.String(nullable: false, maxLength: 128),
                        ParticipantId = c.Long(nullable: false),
                        MatchId = c.Long(nullable: false),
                        SummonerId = c.Long(nullable: false),
                        ChampionId = c.Long(nullable: false),
                        Spell1Id = c.Int(nullable: false),
                        Spell2Id = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        Lane = c.String(),
                        Role = c.String(),
                        Winner = c.Boolean(nullable: false),
                        Kills = c.Long(nullable: false),
                        Deaths = c.Long(nullable: false),
                        Assists = c.Long(nullable: false),
                        ChampLevel = c.Long(nullable: false),
                        FirstBloodKill = c.Boolean(),
                        FirstBloodAssist = c.Boolean(),
                        Item0 = c.Long(nullable: false),
                        Item1 = c.Long(nullable: false),
                        Item2 = c.Long(nullable: false),
                        Item3 = c.Long(nullable: false),
                        Item4 = c.Long(nullable: false),
                        Item5 = c.Long(nullable: false),
                        Item6 = c.Long(nullable: false),
                        LargestCriticalStrike = c.Long(nullable: false),
                        LargestMultiKill = c.Long(nullable: false),
                        MagicDamageDealt = c.Long(nullable: false),
                        MagicDamageDealtToChampions = c.Long(nullable: false),
                        PhysicalDamageDealt = c.Long(nullable: false),
                        PhysicalDamageDealtToChampions = c.Long(nullable: false),
                        TrueDamageDealt = c.Long(nullable: false),
                        TrueDamageDealtToChampions = c.Long(nullable: false),
                        TotalDamageDealt = c.Long(nullable: false),
                        TotalDamageDealtToChampions = c.Long(nullable: false),
                        MagicDamageTaken = c.Long(nullable: false),
                        PhysicalDamageTaken = c.Long(nullable: false),
                        TrueDamageTaken = c.Long(nullable: false),
                        TotalDamageTaken = c.Long(nullable: false),
                        WardsPlaced = c.Long(nullable: false),
                        wardsKilled = c.Long(nullable: false),
                        VisionWardsBoughtInGame = c.Long(nullable: false),
                        MinionsKilled = c.Long(nullable: false),
                        NeutralMinionsKilled = c.Long(nullable: false),
                        NeutralMinionsKilledEnemyJungle = c.Long(nullable: false),
                        NeutralMinionsKilledJungle = c.Long(nullable: false),
                        TotalDamageHealed = c.Long(nullable: false),
                        TotalTimeCCDealt = c.Long(nullable: false),
                        MyChampionWithStats_ChampionStatsId = c.Long(),
                    })
                .PrimaryKey(t => t.CombinedId)
                .ForeignKey("dbo.MyChampionWithStats", t => t.MyChampionWithStats_ChampionStatsId)
                .Index(t => t.MyChampionWithStats_ChampionStatsId);
            
            CreateTable(
                "dbo.MySummoner",
                c => new
                    {
                        SummonerId = c.Long(nullable: false, identity: true),
                        SummonerName = c.String(nullable: false),
                        Tier = c.String(),
                    })
                .PrimaryKey(t => t.SummonerId);
            
            CreateTable(
                "dbo.MyChampion",
                c => new
                    {
                        ChampId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ImageId = c.String(),
                        Passive = c.String(nullable: false),
                        BaseArmor = c.Double(nullable: false),
                        Mp5PerLevel = c.Double(nullable: false),
                        BaseMp5 = c.Double(nullable: false),
                        MpPerLevel = c.Double(nullable: false),
                        BaseMp = c.Double(nullable: false),
                        BaseMoveSpeed = c.Double(nullable: false),
                        Hp5PerLevel = c.Double(nullable: false),
                        BaseHp5 = c.Double(nullable: false),
                        HpPerLevel = c.Double(nullable: false),
                        BaseHp = c.Double(nullable: false),
                        CritPerLevel = c.Double(nullable: false),
                        BaseCrit = c.Double(nullable: false),
                        AttackSpeedPerLevel = c.Double(nullable: false),
                        AttackSpeedOffset = c.Double(nullable: false),
                        AttackRange = c.Double(nullable: false),
                        ADPerLevel = c.Double(nullable: false),
                        BaseAD = c.Double(nullable: false),
                        ArmorPerLevel = c.Double(nullable: false),
                        BaseMR = c.Double(nullable: false),
                        MRPerLevel = c.Double(nullable: false),
                        ResourceType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ChampId);
            
            CreateTable(
                "dbo.MyChampionWithStats",
                c => new
                    {
                        ChampionStatsId = c.Long(nullable: false, identity: true),
                        Armor = c.Double(nullable: false),
                        HP = c.Double(nullable: false),
                        HP5 = c.Double(nullable: false),
                        MR = c.Double(nullable: false),
                        HealAndShieldPower = c.Double(nullable: false),
                        Tenacity = c.Double(nullable: false),
                        SlowResist = c.Double(nullable: false),
                        ChampionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ChampionStatsId)
                .ForeignKey("dbo.MyChampion", t => t.ChampionId)
                .Index(t => t.ChampionId);
            
            CreateTable(
                "dbo.MyMatchMyParticipant",
                c => new
                    {
                        MyMatch_MatchId = c.Long(nullable: false),
                        MatchFromParticipantId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.MyMatch_MatchId, t.MatchFromParticipantId })
                .ForeignKey("dbo.MyMatch", t => t.MyMatch_MatchId, cascadeDelete: true)
                .ForeignKey("dbo.MyParticipant", t => t.MatchFromParticipantId, cascadeDelete: true)
                .Index(t => t.MyMatch_MatchId)
                .Index(t => t.MatchFromParticipantId);
            
            CreateTable(
                "dbo.MySummonerMyMatch",
                c => new
                    {
                        MySummoner_SummonerId = c.Long(nullable: false),
                        SummonerInMatch = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.MySummoner_SummonerId, t.SummonerInMatch })
                .ForeignKey("dbo.MySummoner", t => t.MySummoner_SummonerId, cascadeDelete: true)
                .ForeignKey("dbo.MyMatch", t => t.SummonerInMatch, cascadeDelete: true)
                .Index(t => t.MySummoner_SummonerId)
                .Index(t => t.SummonerInMatch);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyParticipant", "MyChampionWithStats_ChampionStatsId", "dbo.MyChampionWithStats");
            DropForeignKey("dbo.MyChampionWithStats", "ChampionId", "dbo.MyChampion");
            DropForeignKey("dbo.MySummonerMyMatch", "SummonerInMatch", "dbo.MyMatch");
            DropForeignKey("dbo.MySummonerMyMatch", "MySummoner_SummonerId", "dbo.MySummoner");
            DropForeignKey("dbo.MyMatchMyParticipant", "MatchFromParticipantId", "dbo.MyParticipant");
            DropForeignKey("dbo.MyMatchMyParticipant", "MyMatch_MatchId", "dbo.MyMatch");
            DropIndex("dbo.MySummonerMyMatch", new[] { "SummonerInMatch" });
            DropIndex("dbo.MySummonerMyMatch", new[] { "MySummoner_SummonerId" });
            DropIndex("dbo.MyMatchMyParticipant", new[] { "MatchFromParticipantId" });
            DropIndex("dbo.MyMatchMyParticipant", new[] { "MyMatch_MatchId" });
            DropIndex("dbo.MyChampionWithStats", new[] { "ChampionId" });
            DropIndex("dbo.MyParticipant", new[] { "MyChampionWithStats_ChampionStatsId" });
            DropTable("dbo.MySummonerMyMatch");
            DropTable("dbo.MyMatchMyParticipant");
            DropTable("dbo.MyChampionWithStats");
            DropTable("dbo.MyChampion");
            DropTable("dbo.MySummoner");
            DropTable("dbo.MyParticipant");
            DropTable("dbo.MyMatch");
        }
    }
}
