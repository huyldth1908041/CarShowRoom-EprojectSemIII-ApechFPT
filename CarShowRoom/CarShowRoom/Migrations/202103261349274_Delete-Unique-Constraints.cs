namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUniqueConstraints : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Vehicles", new[] { "VIN" });
            DropIndex("dbo.Vehicles", new[] { "FN" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Vehicles", "FN", unique: true);
            CreateIndex("dbo.Vehicles", "VIN", unique: true);
        }
    }
}
