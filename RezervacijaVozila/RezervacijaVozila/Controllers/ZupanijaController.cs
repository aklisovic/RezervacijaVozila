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
    public class ZupanijaController : Controller
    {
        private VozilaContext db = new VozilaContext();

        // GET: Zupanija
        public ActionResult Index()
        {
            return View(db.Zupanije.ToList());
        }

        // GET: Zupanija/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zupanija zupanija = db.Zupanije.Find(id);
            if (zupanija == null)
            {
                return HttpNotFound();
            }
            return View(zupanija);
        }

        // GET: Zupanija/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zupanija/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Zupanija zupanija)
        {
            if (ModelState.IsValid)
            {
                db.Zupanije.Add(zupanija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zupanija);
        }

        // GET: Zupanija/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zupanija zupanija = db.Zupanije.Find(id);
            if (zupanija == null)
            {
                return HttpNotFound();
            }
            return View(zupanija);
        }

        // POST: Zupanija/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Zupanija zupanija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zupanija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zupanija);
        }

        // GET: Zupanija/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zupanija zupanija = db.Zupanije.Find(id);
            if (zupanija == null)
            {
                return HttpNotFound();
            }
            return View(zupanija);
        }

        // POST: Zupanija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zupanija zupanija = db.Zupanije.Find(id);
            db.Zupanije.Remove(zupanija);
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
