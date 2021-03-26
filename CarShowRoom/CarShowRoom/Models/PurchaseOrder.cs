using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarShowRoom.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public float TotalPrice { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedTime { get; set; }

        public PurchaseOrderStatus Status { get; set; }

        public enum PurchaseOrderStatus
        {
            Pending, Done
        }

        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}