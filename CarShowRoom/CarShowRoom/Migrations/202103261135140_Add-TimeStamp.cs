namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeStamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrderDetails", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.PurchaseOrderDetails", "UpdatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.PurchaseOrders", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.PurchaseOrders", "UpdatedTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseOrders", "UpdatedTime");
            DropColumn("dbo.PurchaseOrders", "CreatedAt");
            DropColumn("dbo.PurchaseOrderDetails", "UpdatedTime");
            DropColumn("dbo.PurchaseOrderDetails", "CreatedAt");
        }
    }
}
