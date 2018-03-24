namespace BizHacksApp.Migrations.Products
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProcessorSpeed", c => c.Double());
            AlterColumn("dbo.Products", "RamSize", c => c.Int());
            AlterColumn("dbo.Products", "HardDiskSpace", c => c.Int());
            AlterColumn("dbo.Products", "GPUMemory", c => c.Int());
            AlterColumn("dbo.Products", "GPUSpeed", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "GPUSpeed", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "GPUMemory", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "HardDiskSpace", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "RamSize", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProcessorSpeed", c => c.Double(nullable: false));
        }
    }
}
