using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class SeriesController : Controller {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Series
        public ActionResult Index() {
            return View(db.Series.ToList());
        }

        // GET: Series/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serie serie = db.Series.Find(id);
            if (serie == null) {
                return HttpNotFound();
            }
            //serie.temporadas = new LinkedList<Temporada>(db.Temporadas.Where(x => x.serieID == id));
            return View(serie);
        }

        // GET: Series/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Series/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "serieID,nombre,fechaEstreno,enEmision,genero,image")] Serie serie) {
            if (ModelState.IsValid) {
                db.Series.Add(serie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serie);
        }

        // GET: Series/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serie serie = db.Series.Find(id);
            if (serie == null) {
                return HttpNotFound();
            }
            return View(serie);
        }

        // POST: Series/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "serieID,nombre,fechaEstreno,enEmision,genero,image")] Serie serie) {
            if (ModelState.IsValid) {
                db.Entry(serie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serie);
        }

        // GET: Series/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Serie serie = db.Series.Find(id);
            if (serie == null) {
                return HttpNotFound();
            }
            return View(serie);
        }

        // POST: Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            Serie serie = db.Series.Find(id);
            db.Series.Remove(serie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
