using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentTheBike.Models;

namespace RentTheBike.Controllers
{
    public class BicycleController : Controller
    {
        BikeDatabaseEntities db = new BikeDatabaseEntities();
        // GET: Bicycle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var data = db.Bicycle.ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        // GET: Bicycle/Details/5
        public ActionResult BicycleEditor()
        {
            return View();
        }

        public ActionResult getTypes()
        {
            var bicycleTypes = db.BicycleType.ToList();
     
                return Json(bicycleTypes, JsonRequestBehavior.AllowGet);
        }


        public string CreateBicycle(Bicycle bic)
        {
            if (bic != null)
            {
                db.Bicycle.Add((bic));
                db.SaveChanges();
                return "Bicycle Added";
                
            }
            else
            {
                return "Invalid Record";
            }
        }

        // GET: Bicycle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bicycle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bicycle/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bicycle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bicycle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bicycle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bicycle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
