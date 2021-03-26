using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowRoom.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }


        public PurchaseOrderStatus Status { get; set; }

        public enum PurchaseOrderStatus
        {
            Pending, Done
        }
    }
}