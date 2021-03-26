using System.Collections;
using System.Collections.Generic;

namespace CarShowRoom.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}