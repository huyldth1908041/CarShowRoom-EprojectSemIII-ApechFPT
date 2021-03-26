using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShowRoom.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public VehicleModelStatus Status { get; set; }
        public string Descriptions { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public enum VehicleModelStatus
        {
            Active, DeActive
        }
 
        public virtual ICollection<Vehicle> Vehicles { get; set; }


    }
}