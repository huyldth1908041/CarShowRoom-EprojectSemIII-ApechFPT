﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarShowRoom.Models
{
    public class PurchaseOrderDetail
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int VehicleModelId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Unit Price")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public float Price { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedTime { get; set; }

    }
}