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
    public class VoziloController : Controller
    {
        private VozilaContext db = new VozilaContext();

        // GET: Vozilo
        public ActionResult Index()
        {
            var voziloes = db.Vozila.Include(v => v.Marka);
            return View(voziloes.ToList());
        }

        // GET: Vozilo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozila.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // GET: Vozilo/Create
        public ActionResult Create()
        {
            ViewBag.MarkaID = new SelectList(db.Marke, "MarkaID", "Naziv");
            return View();
        }

        // POST: Vozilo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                db.Vozila.Add(vozilo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MarkaID = new SelectList(db.Marke, "MarkaID", "Naziv", vozilo.MarkaID);
            return View(vozilo);
        }

        // GET: Vozilo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozila.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            ViewBag.MarkaID = new SelectList(db.Marke, "MarkaID", "Naziv", vozilo.MarkaID);
            return View(vozilo);
        }

        // POST: Vozilo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vozilo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MarkaID = new SelectList(db.Marke, "MarkaID", "Naziv", vozilo.MarkaID);
            return View(vozilo);
        }

        // GET: Vozilo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozila.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // POST: Vozilo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vozilo vozilo = db.Vozila.Find(id);
            db.Vozila.Remove(vozilo);
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
