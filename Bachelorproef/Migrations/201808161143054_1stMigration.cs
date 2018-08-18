namespace DataGatherer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1stMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Champions",
                c => new
                    {
                        ChampId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ImageId = c.String(nullable: false),
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
                "dbo.ChampionsWithStats",
                c => new
                    {
                        ChampionId = c.Long(nullable: false),
                        Armor = c.Double(),
                        HP = c.Double(),
                        HP5 = c.Double(),
                        MR = c.Double(),
                        HealAndShieldPower = c.Double(),
                        Tenacity = c.Double(),
                        SlowResist = c.Double(),
                        AD = c.Double(),
                        Lethality = c.Double(),
                        ArmorPenetration = c.Double(),
                        AS = c.Double(),
                        LifeSteal = c.Double(),
                        CritChance = c.Double(),
                        CritDamage = c.Double(nullable: false),
                        AP = c.Double(),
                        MagicPenetration = c.Double(),
                        CDR = c.Double(),
                        Mana = c.Double(),
                        ManaP5 = c.Double(),
                        MS = c.Double(),
                        Kills = c.Double(),
                        Deaths = c.Double(),
                        Assists = c.Double(),
                        LargestCriticalStrike = c.Double(),
                        LargestMultiKill = c.Double(),
                        MagicDamageDealt = c.Double(),
                        MagicDamageDealtToChampions = c.Double(),
                        PhysicalDamageDealt = c.Double(),
                        PhysicalDamageDealtToChampions = c.Double(),
                        TrueDamageDealt = c.Double(),
                        TrueDamageDealtToChampions = c.Double(),
                        TotalDamageDealt = c.Double(),
                        TotalDamageDealtToChampions = c.Double(),
                        MagicDamageTaken = c.Double(),
                        PhysicalDamageTaken = c.Double(),
                        TrueDamageTaken = c.Double(),
                        TotalDamageTaken = c.Double(),
                        WardsPlaced = c.Double(),
                        WardsKilled = c.Double(),
                        VisionWardsBoughtInGame = c.Double(),
                        MinionsKilled = c.Double(),
                        NeutralMinionsKilled = c.Double(),
                        NeutralMinionsKilledEnemyJungle = c.Double(),
                        NeutralMinionsKilledJungle = c.Double(),
                        TotalDamageHealed = c.Double(),
                        TotalTimeCCDealt = c.Double(),
                        WinPercentage = c.Double(nullable: false),
                        FirstBloodPercentage = c.Double(nullable: false),
                        RealChampionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChampionId)
                .ForeignKey("dbo.Champions", t => t.RealChampionId)
                .Index(t => t.RealChampionId);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        MatchId = c.Long(nullable: false),
                        SummonerId = c.Long(nullable: false),
                        ParticipantId = c.Long(nullable: false),
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
                        WardsKilled = c.Long(nullable: false),
                        VisionWardsBoughtInGame = c.Long(nullable: false),
                        MinionsKilled = c.Long(nullable: false),
                        NeutralMinionsKilled = c.Long(nullable: false),
                        NeutralMinionsKilledEnemyJungle = c.Long(nullable: false),
                        NeutralMinionsKilledJungle = c.Long(nullable: false),
                        TotalDamageHealed = c.Long(nullable: false),
                        TotalTimeCCDealt = c.Long(nullable: false),
                        Item0 = c.Int(),
                        Item1 = c.Int(),
                        Item2 = c.Int(),
                        Item3 = c.Int(),
                        Item4 = c.Int(),
                        Item5 = c.Int(),
                        Item6 = c.Int(),
                        ChampWithStatsId = c.Long(),
                    })
                .PrimaryKey(t => new { t.MatchId, t.SummonerId })
                .ForeignKey("dbo.MyItem", t => t.Item0)
                .ForeignKey("dbo.MyItem", t => t.Item1)
                .ForeignKey("dbo.MyItem", t => t.Item2)
                .ForeignKey("dbo.MyItem", t => t.Item3)
                .ForeignKey("dbo.MyItem", t => t.Item4)
                .ForeignKey("dbo.MyItem", t => t.Item5)
                .ForeignKey("dbo.MyItem", t => t.Item6)
                .ForeignKey("dbo.ChampionsWithStats", t => t.ChampWithStatsId)
                .Index(t => t.Item0)
                .Index(t => t.Item1)
                .Index(t => t.Item2)
                .Index(t => t.Item3)
                .Index(t => t.Item4)
                .Index(t => t.Item5)
                .Index(t => t.Item6)
                .Index(t => t.ChampWithStatsId);
            
            CreateTable(
                "dbo.MyItem",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        BasePrice = c.Int(nullable: false),
                        ImageId = c.String(nullable: false),
                        HP = c.Int(),
                        Armor = c.Int(),
                        MR = c.Int(),
                        HP5 = c.Int(),
                        HealShieldPower = c.Int(),
                        Tenacity = c.Int(),
                        SlowResist = c.Int(),
                        AD = c.Int(),
                        Lethality = c.Int(),
                        ArmorPenetration = c.Int(),
                        AS = c.Int(),
                        LifeSteal = c.Int(),
                        CritChance = c.Int(),
                        CritDamage = c.Int(),
                        AP = c.Int(),
                        MagicPenetration = c.Int(),
                        CDR = c.Int(),
                        Mana = c.Int(),
                        ManaP5 = c.Int(),
                        MS = c.Int(),
                        maxms = c.Int(nullable: false),
                        percentmagicpen = c.Int(nullable: false),
                        percentms = c.Int(nullable: false),
                        goldregen = c.Int(nullable: false),
                        onhit = c.Int(nullable: false),
                        onhitpercent = c.Int(nullable: false),
                        melee = c.Boolean(nullable: false),
                        GrievousWounds = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchId = c.Long(nullable: false),
                        GameCreation = c.Long(),
                        MatchDuration = c.Long(),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MatchId);
            
            CreateTable(
                "dbo.Summoners",
                c => new
                    {
                        SummonerId = c.Long(nullable: false),
                        AccountId = c.Long(nullable: false),
                        SummonerName = c.String(nullable: false),
                        Tier = c.String(),
                        IsCompleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.SummonerId);
            
            CreateTable(
                "dbo.MyMatchMyParticipant",
                c => new
                    {
                        MyMatch_MatchId = c.Long(nullable: false),
                        matchid = c.Long(nullable: false),
                        summonerid = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.MyMatch_MatchId, t.matchid, t.summonerid })
                .ForeignKey("dbo.Matches", t => t.MyMatch_MatchId, cascadeDelete: true)
                .ForeignKey("dbo.Participants", t => new { t.matchid, t.summonerid }, cascadeDelete: true)
                .Index(t => t.MyMatch_MatchId)
                .Index(t => new { t.matchid, t.summonerid });
            
            CreateTable(
                "dbo.MySummonerMyMatch",
                c => new
                    {
                        MySummoner_SummonerId = c.Long(nullable: false),
                        SummonerInMatch = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.MySummoner_SummonerId, t.SummonerInMatch })
                .ForeignKey("dbo.Summoners", t => t.MySummoner_SummonerId, cascadeDelete: true)
                .ForeignKey("dbo.Matches", t => t.SummonerInMatch, cascadeDelete: true)
                .Index(t => t.MySummoner_SummonerId)
                .Index(t => t.SummonerInMatch);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MySummonerMyMatch", "SummonerInMatch", "dbo.Matches");
            DropForeignKey("dbo.MySummonerMyMatch", "MySummoner_SummonerId", "dbo.Summoners");
            DropForeignKey("dbo.MyMatchMyParticipant", new[] { "matchid", "summonerid" }, "dbo.Participants");
            DropForeignKey("dbo.MyMatchMyParticipant", "MyMatch_MatchId", "dbo.Matches");
            DropForeignKey("dbo.Participants", "ChampWithStatsId", "dbo.ChampionsWithStats");
            DropForeignKey("dbo.Participants", "Item6", "dbo.MyItem");
            DropForeignKey("dbo.Participants", "Item5", "dbo.MyItem");
            DropForeignKey("dbo.Participants", "Item4", "dbo.MyItem");
            DropForeignKey("dbo.Participants", "Item3", "dbo.MyItem");
            DropForeignKey("dbo.Participants", "Item2", "dbo.MyItem");
            DropForeignKey("dbo.Participants", "Item1", "dbo.MyItem");
            DropForeignKey("dbo.Participants", "Item0", "dbo.MyItem");
            DropForeignKey("dbo.ChampionsWithStats", "RealChampionId", "dbo.Champions");
            DropIndex("dbo.MySummonerMyMatch", new[] { "SummonerInMatch" });
            DropIndex("dbo.MySummonerMyMatch", new[] { "MySummoner_SummonerId" });
            DropIndex("dbo.MyMatchMyParticipant", new[] { "matchid", "summonerid" });
            DropIndex("dbo.MyMatchMyParticipant", new[] { "MyMatch_MatchId" });
            DropIndex("dbo.Participants", new[] { "ChampWithStatsId" });
            DropIndex("dbo.Participants", new[] { "Item6" });
            DropIndex("dbo.Participants", new[] { "Item5" });
            DropIndex("dbo.Participants", new[] { "Item4" });
            DropIndex("dbo.Participants", new[] { "Item3" });
            DropIndex("dbo.Participants", new[] { "Item2" });
            DropIndex("dbo.Participants", new[] { "Item1" });
            DropIndex("dbo.Participants", new[] { "Item0" });
            DropIndex("dbo.ChampionsWithStats", new[] { "RealChampionId" });
            DropTable("dbo.MySummonerMyMatch");
            DropTable("dbo.MyMatchMyParticipant");
            DropTable("dbo.Summoners");
            DropTable("dbo.Matches");
            DropTable("dbo.MyItem");
            DropTable("dbo.Participants");
            DropTable("dbo.ChampionsWithStats");
            DropTable("dbo.Champions");
        }
    }
}
