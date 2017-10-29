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

namespace RezervacijaVozila.Controllers
{
    public class MjestoController : Controller
    {
        private VozilaContext db = new VozilaContext();

        // GET: Mjesto
        public ActionResult Index()
        {
            var Mjesto = db.Mjesta.Include(m => m.Zupanija);
            return View(Mjesto.ToList());
        }

        // GET: Mjesto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mjesto mjesto = db.Mjesta.Find(id);
            if (mjesto == null)
            {
                return HttpNotFound();
            }
            return View(mjesto);
        }

        // GET: Mjesto/Create
        public ActionResult Create()
        {
            ViewBag.ZupanijaID = new SelectList(db.Zupanije, "ZupanijaID", "Naziv");
            return View();
        }

        // POST: Mjesto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mjesto mjesto)
        {
            if (ModelState.IsValid)
            {
                db.Mjesta.Add(mjesto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ZupanijaID = new SelectList(db.Zupanije, "ZupanijaID", "Naziv", mjesto.ZupanijaID);
            return View(mjesto);
        }

        // GET: Mjesto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mjesto mjesto = db.Mjesta.Find(id);
            if (mjesto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ZupanijaID = new SelectList(db.Zupanije, "ZupanijaID", "Naziv", mjesto.ZupanijaID);
            return View(mjesto);
        }

        // POST: Mjesto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Mjesto mjesto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mjesto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ZupanijaID = new SelectList(db.Zupanije, "ZupanijaID", "Naziv", mjesto.ZupanijaID);
            return View(mjesto);
        }

        // GET: Mjesto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mjesto mjesto = db.Mjesta.Find(id);
            if (mjesto == null)
            {
                return HttpNotFound();
            }
            return View(mjesto);
        }

        // POST: Mjesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mjesto mjesto = db.Mjesta.Find(id);
            db.Mjesta.Remove(mjesto);
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
