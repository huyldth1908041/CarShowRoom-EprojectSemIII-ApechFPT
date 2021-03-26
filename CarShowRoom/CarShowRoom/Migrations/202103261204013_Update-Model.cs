namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VehicleModels", "ModelName", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.PurchaseOrderDetails", "Color", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PurchaseOrderDetails", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "Description", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.VehicleModels", "ModelName", c => c.String());
        }
    }
}
