namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCustomerId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Vehicles", new[] { "CustomerId" });
            AddColumn("dbo.Customers", "VehicleId", c => c.Int(nullable: false));
            DropColumn("dbo.Vehicles", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "CustomerId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "VehicleId");
            CreateIndex("dbo.Vehicles", "CustomerId");
            AddForeignKey("dbo.Vehicles", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
