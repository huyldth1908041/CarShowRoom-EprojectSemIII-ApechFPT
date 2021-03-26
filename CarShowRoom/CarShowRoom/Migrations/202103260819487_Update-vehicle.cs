namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatevehicle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "Name");
        }
    }
}
