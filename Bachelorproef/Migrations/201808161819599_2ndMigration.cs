namespace DataGatherer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2ndMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MyItem", newName: "Items");
            AlterColumn("dbo.Items", "MaxMs", c => c.Int());
            AlterColumn("dbo.Items", "PercentMagicPen", c => c.Int());
            AlterColumn("dbo.Items", "PercentMs", c => c.Int());
            AlterColumn("dbo.Items", "GoldRegen", c => c.Int());
            AlterColumn("dbo.Items", "OnHit", c => c.Int());
            AlterColumn("dbo.Items", "OnHitPercent", c => c.Int());
            AlterColumn("dbo.Items", "Melee", c => c.Boolean());
            AlterColumn("dbo.Items", "GrievousWounds", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "GrievousWounds", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Items", "Melee", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Items", "OnHitPercent", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "OnHit", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "GoldRegen", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "PercentMs", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "PercentMagicPen", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "MaxMs", c => c.Int(nullable: false));
            RenameTable(name: "dbo.Items", newName: "MyItem");
        }
    }
}
