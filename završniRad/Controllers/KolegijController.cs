using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using završniRad.Models;

namespace završniRad.Controllers
{
    public class KolegijController : Controller
    {
        private diplomskiEntities db = new diplomskiEntities();

        // GET: Kolegij
        public ActionResult Index()
        {
            return View(db.Kolegijs.ToList());
        }

        // GET: Kolegij/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kolegij kolegij = db.Kolegijs.Find(id);
            if (kolegij == null)
            {
                return HttpNotFound();
            }
            return View(kolegij);
        }

        // GET: Kolegij/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kolegij/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KolegijID,Naziv")] Kolegij kolegij)
        {
            if (ModelState.IsValid)
            {
                db.Kolegijs.Add(kolegij);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kolegij);
        }

        // GET: Kolegij/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kolegij kolegij = db.Kolegijs.Find(id);
            if (kolegij == null)
            {
                return HttpNotFound();
            }
            return View(kolegij);
        }

        // POST: Kolegij/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KolegijID,Naziv")] Kolegij kolegij)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kolegij).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kolegij);
        }

        // GET: Kolegij/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kolegij kolegij = db.Kolegijs.Find(id);
            if (kolegij == null)
            {
                return HttpNotFound();
            }
            return View(kolegij);
        }

        // POST: Kolegij/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kolegij kolegij = db.Kolegijs.Find(id);
            db.Kolegijs.Remove(kolegij);
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
