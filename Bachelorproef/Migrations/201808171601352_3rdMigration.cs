namespace DataGatherer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rdMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Participants", "Item0", "dbo.Items");
            DropForeignKey("dbo.Participants", "Item1", "dbo.Items");
            DropForeignKey("dbo.Participants", "Item2", "dbo.Items");
            DropForeignKey("dbo.Participants", "Item3", "dbo.Items");
            DropForeignKey("dbo.Participants", "Item4", "dbo.Items");
            DropForeignKey("dbo.Participants", "Item5", "dbo.Items");
            DropForeignKey("dbo.Participants", "Item6", "dbo.Items");
            DropIndex("dbo.Participants", new[] { "Item0" });
            DropIndex("dbo.Participants", new[] { "Item1" });
            DropIndex("dbo.Participants", new[] { "Item2" });
            DropIndex("dbo.Participants", new[] { "Item3" });
            DropIndex("dbo.Participants", new[] { "Item4" });
            DropIndex("dbo.Participants", new[] { "Item5" });
            DropIndex("dbo.Participants", new[] { "Item6" });
            AlterColumn("dbo.Participants", "Item0", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "Item1", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "Item2", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "Item3", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "Item4", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "Item5", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "Item6", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "Item6", c => c.Int());
            AlterColumn("dbo.Participants", "Item5", c => c.Int());
            AlterColumn("dbo.Participants", "Item4", c => c.Int());
            AlterColumn("dbo.Participants", "Item3", c => c.Int());
            AlterColumn("dbo.Participants", "Item2", c => c.Int());
            AlterColumn("dbo.Participants", "Item1", c => c.Int());
            AlterColumn("dbo.Participants", "Item0", c => c.Int());
            CreateIndex("dbo.Participants", "Item6");
            CreateIndex("dbo.Participants", "Item5");
            CreateIndex("dbo.Participants", "Item4");
            CreateIndex("dbo.Participants", "Item3");
            CreateIndex("dbo.Participants", "Item2");
            CreateIndex("dbo.Participants", "Item1");
            CreateIndex("dbo.Participants", "Item0");
            AddForeignKey("dbo.Participants", "Item6", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Participants", "Item5", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Participants", "Item4", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Participants", "Item3", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Participants", "Item2", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Participants", "Item1", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Participants", "Item0", "dbo.Items", "ItemId");
        }
    }
}
