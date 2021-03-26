namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addorder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseOrderId = c.Int(nullable: false),
                        VehicleModelId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Name = c.String(),
                        Color = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseOrders", t => t.PurchaseOrderId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleModels", t => t.VehicleModelId, cascadeDelete: true)
                .Index(t => t.PurchaseOrderId)
                .Index(t => t.VehicleModelId);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Single(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseOrderDetails", "VehicleModelId", "dbo.VehicleModels");
            DropForeignKey("dbo.PurchaseOrderDetails", "PurchaseOrderId", "dbo.PurchaseOrders");
            DropIndex("dbo.PurchaseOrderDetails", new[] { "VehicleModelId" });
            DropIndex("dbo.PurchaseOrderDetails", new[] { "PurchaseOrderId" });
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.PurchaseOrderDetails");
        }
    }
}
