using NH.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NH.Controllers
{
    public class DetailsController : Controller
    {
 
        // GET: Details
        public ActionResult Index()
        {
            HotelEntities db = new HotelEntities();
            var data = db.Details.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Detail p)
        {
            if (ModelState.IsValid)
            {
                HotelEntities db = new HotelEntities();
                db.Details.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var db = new HotelEntities();
            var data = (from d in db.Details where d.Id == Id select d).SingleOrDefault();

            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Detail p)
        {
            var db = new HotelEntities();
            var user = (from d in db.Details where d.Id == p.Id select d).FirstOrDefault();
            user.Room_Number = p.Room_Number;
            user.Room_Catagory = p.Room_Catagory;
            user.Price = p.Price;
            try
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException n)
            {
                return View(p);
            }
        }
        public ActionResult Delete(int ID)
        {
            var db = new HotelEntities();
            var p = (from d in db.Details where d.Id == ID select d).SingleOrDefault();
            db.Details.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
