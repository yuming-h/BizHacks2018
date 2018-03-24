namespace BizHacksApp.Migrations.Products
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductstabletoincludepriceandchangedGPUSpeedtonullabledouble : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "GPUSpeed", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "GPUSpeed", c => c.Int());
            DropColumn("dbo.Products", "Price");
        }
    }
}
