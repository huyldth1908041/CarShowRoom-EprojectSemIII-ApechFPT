using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarShowRoom.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Name { get; set; }
        public string Cover { get; set; }
        [StringLength(255)]
       
        public string VIN { get; set; }
        [StringLength(255)]
      
        public string FN { get; set; }
        [Display(Name="Price")]
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public float SalePrice { get; set; }
        [Required]
        public string Description { get; set; }
        public VehicleType Type { get; set; }
        public VehicleControlType Control { get; set; }
        public VehicleStatus Status { get; set; }

        public enum VehicleStatus
        {
            Pending, Avaible, Sold, Assigned
        }

        public enum VehicleType
        {
            Petrol = 0,
            Diesel = 1,
            [Display(Name="Petrol and Diesel")]
            Both = 2
        }
        public enum VehicleControlType
        {
            Automatic = 0,
            Manual = 1
        }

        //foreings key
        public int VehicleModelId { get; set; }
        //navigation property
        public virtual VehicleModel VehicleModel { get; set; }


    }
}