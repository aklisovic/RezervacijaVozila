using RezervacijaVozila.DAL;
using RezervacijaVozila.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RezervacijaVozila.Contollers
{
    public class OsobaController : Controller
    {
        private VozilaContext db = new VozilaContext();

        // GET: Osoba
        public ActionResult Index()
        {
            var osoba = db.Osobe.Include(o => o.Mjesto);
            return View(osoba.ToList());
        }

        // GET: Osoba/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba osoba = db.Osobe.Find(id);
            if (osoba == null)
            {
                return HttpNotFound();
            }
            return View(osoba);
        }

        // GET: Osoba/Create
        public ActionResult Create()
        {
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "Naziv");
            return View();
        }

        // POST: Osoba/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                db.Osobe.Add(osoba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "TipMjesta", osoba.MjestoID);
            return View(osoba);
        }

        // GET: Osoba/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba osoba = db.Osobe.Find(id);
            if (osoba == null)
            {
                return HttpNotFound();
            }
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "Naziv", osoba.MjestoID);
            return View(osoba);
        }

        // POST: Osoba/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(osoba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "TipMjesta", osoba.MjestoID);
            return View(osoba);
        }

        // GET: Osoba/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba osoba = db.Osobe.Find(id);
            if (osoba == null)
            {
                return HttpNotFound();
            }
            return View(osoba);
        }

        // POST: Osoba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Osoba osoba = db.Osobe.Find(id);
            db.Osobe.Remove(osoba);
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
