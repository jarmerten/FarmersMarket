using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Farmers_Market.Models;

namespace Farmers_Market.Controllers
{
    public class ProducesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produces
        public ActionResult Index()
        {
            return View(db.produce.ToList());
        }

        // GET: Produces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produce produce = db.produce.Find(id);
            if (produce == null)
            {
                return HttpNotFound();
            }
            return View(produce);
        }

        // GET: Produces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Description,ImagePath,UnitPrice,CategoryID")] Produce produce)
        {
            if (ModelState.IsValid)
            {
                db.produce.Add(produce);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produce);
        }

        // GET: Produces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produce produce = db.produce.Find(id);
            if (produce == null)
            {
                return HttpNotFound();
            }
            return View(produce);
        }

        // POST: Produces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Description,ImagePath,UnitPrice,CategoryID")] Produce produce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produce);
        }

        // GET: Produces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produce produce = db.produce.Find(id);
            if (produce == null)
            {
                return HttpNotFound();
            }
            return View(produce);
        }

        // POST: Produces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produce produce = db.produce.Find(id);
            db.produce.Remove(produce);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
