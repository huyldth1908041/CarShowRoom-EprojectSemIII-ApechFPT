namespace CarShowRoom.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarShowRoom.Models.ShowRoomDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarShowRoom.Models.ShowRoomDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Brands.AddOrUpdate(x => x.Id,
                new Models.Brand() { Id = 1, Name = "VinFast", Description = "Xe VinFast" },
                new Models.Brand() { Id = 2, Name = "Kia Morning", Description = "Xe Kia" }

            );

            context.VehicleModels.AddOrUpdate(x => x.Id,
                new Models.VehicleModel() 
                {
                    Id = 1, 
                    BrandId = 1,
                    ModelName = "Vf-e34",
                    ModelNumber = "Vf-e34",
                    Status = Models.VehicleModel.VehicleModelStatus.Active,
                    Descriptions = "electronic car vinfast"
                }, 
                new Models.VehicleModel()
                {
                    Id = 2,
                    BrandId = 1,
                    ModelName = "Vinfast LUX SA2.0",
                    ModelNumber = "LUX SA2.0",
                    Status = Models.VehicleModel.VehicleModelStatus.Active,
                    Descriptions = "vinfast luxury"
                },
                new Models.VehicleModel()
                {
                    Id = 3,
                    BrandId = 2,
                    ModelName = "KIA QUORIS",
                    ModelNumber = "KIA QUORIS - GAT - 3.8",
                    Status = Models.VehicleModel.VehicleModelStatus.Active,
                    Descriptions = "kia car"
                },
                new Models.VehicleModel()
                {
                    Id = 4,
                    BrandId = 2,
                    ModelName = "KIA SORENTO (ALL NEW) - 2.2D DELUXE",
                    ModelNumber = "KIA SORENTO (ALL NEW) - 2.2D DELUXE",
                    Status = Models.VehicleModel.VehicleModelStatus.Active,
                    Descriptions = "kia car"
                }
            );
        }
    }
}
