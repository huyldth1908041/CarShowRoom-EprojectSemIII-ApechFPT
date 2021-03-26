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
            return View();
        }

        
    }
}