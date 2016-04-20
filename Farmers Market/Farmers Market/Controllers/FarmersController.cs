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
    public class FarmersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Farmers
        public ActionResult Index()
        {
            
            return View(db.Farmer.ToList());
        }

        // GET: Farmers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmers farmers = db.Farmer.Find(id);
            if (farmers == null)
            {
                return HttpNotFound();
            }
            return View(farmers);
        }

        // GET: Farmers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Address,Email,Password,ConfirmPassword")] Farmers farmers)
        {
            if (ModelState.IsValid)
            {
                db.Farmer.Add(farmers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(farmers);
        }

        // GET: Farmers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmers farmers = db.Farmer.Find(id);
            if (farmers == null)
            {
                return HttpNotFound();
            }
            return View(farmers);
        }

        // POST: Farmers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Address,Email,Password,ConfirmPassword")] Farmers farmers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(farmers);
        }

        // GET: Farmers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmers farmers = db.Farmer.Find(id);
            if (farmers == null)
            {
                return HttpNotFound();
            }
            return View(farmers);
        }

        // POST: Farmers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Farmers farmers = db.Farmer.Find(id);
            db.Farmer.Remove(farmers);
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
