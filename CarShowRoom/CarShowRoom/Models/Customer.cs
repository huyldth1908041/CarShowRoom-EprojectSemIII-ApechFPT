using System.Collections.Generic;

namespace CarShowRoom.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public CustomerStatus Status { get; set; }
        
        public enum CustomerStatus
        {
            Active, Deactive, Delete
        }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}