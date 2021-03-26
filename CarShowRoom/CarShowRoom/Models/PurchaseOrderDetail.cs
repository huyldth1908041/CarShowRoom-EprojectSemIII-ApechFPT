using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowRoom.Models
{
    public class PurchaseOrderDetail
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int VehicleModelId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }

    }
}