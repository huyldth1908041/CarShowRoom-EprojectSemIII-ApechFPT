using CarShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowRoom.Controllers
{
    public class ShowRoomController : Controller
    {
        // GET: ShowRoom
        private ShowRoomDataContext _db;
        public ShowRoomController()
        {
            _db = new ShowRoomDataContext();
        }


        public ActionResult CreateVehicle()
        {
            //getList model
            var listModels = _db.VehicleModels.ToList();
            ViewBag.Models = listModels;
            return View();
        }
        [HttpPost]
        public ActionResult CreateVehicle(Vehicle model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _db.Vehicles.Add(model);

            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult CreatePurchaseOrder()
        {
            var listModels = _db.VehicleModels.ToList();
            ViewBag.Models = listModels;
            return View();
        }
        [HttpPost]
        public ActionResult CreatePurchaseOrder(PurchaseOrderDetail model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //add new purchase order
            var newOrder = _db.PurchaseOrders.Add(new PurchaseOrder()
            {
                CreatedAt = DateTime.Now,
                UpdatedTime = DateTime.Now,
                Quantity = model.Quantity,
                Status = PurchaseOrder.PurchaseOrderStatus.Pending,
                TotalPrice = model.Price * model.Quantity
                
            });
            _db.SaveChanges();
            //add new order detaile
            model.CreatedAt = DateTime.Now;
            model.UpdatedTime = DateTime.Now;
            model.PurchaseOrderId = newOrder.Id;
            _db.PurchaseOrderDetails.Add(model);
            _db.SaveChanges();


            return RedirectToAction("Index", "Home");
        }

        public ActionResult ListPurchaseOrder()
        {
            var listOrders = _db.PurchaseOrders.ToList();
            return View(listOrders);
        }

        public ActionResult PurchaseOrderDetail(int id)
        {
            var listOrdersDetails = _db.PurchaseOrderDetails.Where(x => x.PurchaseOrderId == id).ToList();
            return View(listOrdersDetails);
        }


    }
}