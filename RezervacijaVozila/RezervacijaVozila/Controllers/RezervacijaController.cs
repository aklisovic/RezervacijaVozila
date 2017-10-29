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
    public class RezervacijaController : Controller
    {
        private VozilaContext db = new VozilaContext();

        // GET: Rezervacija
        public ActionResult Index()
        {
            var rezervacija = db.Rezervacije.Include(r => r.Osoba).Include(r => r.Vozilo).Include(r => r.Mjesto);
            return View(rezervacija.ToList());
        }

        // GET: Rezervacija/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervacija rezervacija = db.Rezervacije.Find(id);
            if (rezervacija == null)
            {
                return HttpNotFound();
            }
            return View(rezervacija);
        }

        // GET: Rezervacija/Create
        public ActionResult Create()
        {
            ViewBag.OsobaID = new SelectList(db.Osobe.Select(zapis => new { zapis.OsobaID, ImePrezime = zapis.Ime + " " + zapis.Prezime }), "OsobaID", "ImePrezime").ToList();
            ViewBag.VoziloID = new SelectList(db.Vozila.Select(zapis => new { zapis.VoziloID , MarkaModel = zapis.Marka.Naziv + " - " + zapis.Naziv + " (" + zapis.GodinaProizvodnje + ")" }), "VoziloID", "MarkaModel").ToList();
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "Naziv");

            return View();
        }

        // POST: Rezervacija/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rezervacija rezervacija)
        {
            if (ModelState.IsValid)
            {
                db.Rezervacije.Add(rezervacija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OsobaID = new SelectList(db.Osobe, "OsobaID", "Ime", rezervacija.OsobaID);
            ViewBag.VoziloID = new SelectList(db.Vozila, "VoziloID", "Naziv", rezervacija.VoziloID);
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "TipMjesta", rezervacija.MjestoID);
            return View(rezervacija);
        }

        // GET: Rezervacijas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervacija rezervacija = db.Rezervacije.Find(id);
            if (rezervacija == null)
            {
                return HttpNotFound();
            }
            ViewBag.OsobaID = new SelectList(db.Osobe.Select(zapis => new { zapis.OsobaID, ImePrezime = zapis.Ime + " " + zapis.Prezime }), "OsobaID", "ImePrezime", rezervacija.OsobaID);
            ViewBag.VoziloID = new SelectList(db.Vozila.Select(zapis => new { zapis.VoziloID, MarkaModel = zapis.Marka.Naziv + " - " + zapis.Naziv + " (" + zapis.GodinaProizvodnje + ")" }), "VoziloID", "MarkaModel", rezervacija.VoziloID);
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "Naziv", rezervacija.MjestoID);

            return View(rezervacija);
        }

        // POST: Rezervacijas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rezervacija rezervacija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rezervacija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OsobaID = new SelectList(db.Osobe, "OsobaID", "Ime", rezervacija.OsobaID);
            ViewBag.VoziloID = new SelectList(db.Vozila, "VoziloID", "Naziv", rezervacija.VoziloID);
            ViewBag.MjestoID = new SelectList(db.Mjesta, "MjestoID", "TipMjesta", rezervacija.MjestoID);
            return View(rezervacija);
        }

        // GET: Rezervacijas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervacija rezervacija = db.Rezervacije.Find(id);
            if (rezervacija == null)
            {
                return HttpNotFound();
            }
            return View(rezervacija);
        }

        // POST: Rezervacijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rezervacija rezervacija = db.Rezervacije.Find(id);
            db.Rezervacije.Remove(rezervacija);
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
