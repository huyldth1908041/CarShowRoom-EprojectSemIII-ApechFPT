namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelNumber = c.String(maxLength: 255),
                        ModelName = c.String(),
                        Status = c.Int(nullable: false),
                        Descriptions = c.String(),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.ModelNumber, unique: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Cover = c.String(),
                        VIN = c.String(maxLength: 255),
                        FN = c.String(maxLength: 255),
                        SalePrice = c.Single(nullable: false),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Control = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        VehicleModelId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleModels", t => t.VehicleModelId, cascadeDelete: true)
                .Index(t => t.VIN, unique: true)
                .Index(t => t.FN, unique: true)
                .Index(t => t.VehicleModelId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleModelId", "dbo.VehicleModels");
            DropForeignKey("dbo.Vehicles", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.VehicleModels", "BrandId", "dbo.Brands");
            DropIndex("dbo.Vehicles", new[] { "CustomerId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleModelId" });
            DropIndex("dbo.Vehicles", new[] { "FN" });
            DropIndex("dbo.Vehicles", new[] { "VIN" });
            DropIndex("dbo.VehicleModels", new[] { "BrandId" });
            DropIndex("dbo.VehicleModels", new[] { "ModelNumber" });
            DropTable("dbo.Customers");
            DropTable("dbo.Vehicles");
            DropTable("dbo.VehicleModels");
            DropTable("dbo.Brands");
        }
    }
}
