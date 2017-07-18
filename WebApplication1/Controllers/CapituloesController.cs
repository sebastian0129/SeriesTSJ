using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CapituloesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Capituloes
        public ActionResult Index()
        {
            var capituloes = db.Capituloes.Include(c => c.temporada);
            return View(capituloes.ToList());
        }

        // GET: Capituloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Capitulo capitulo = db.Capituloes.Find(id);
            if (capitulo == null)
            {
                return HttpNotFound();
            }
            return View(capitulo);
        }

        // GET: Capituloes/Create
        public ActionResult Create()
        {
            ViewBag.temporadaID = new SelectList(db.Temporadas, "temporadaID", "nombre");
            return View();
        }

        // POST: Capituloes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "capituloID,nombre,numero,imagen,video,temporadaID")] Capitulo capitulo)
        {
            if (ModelState.IsValid)
            {
                db.Capituloes.Add(capitulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.temporadaID = new SelectList(db.Temporadas, "temporadaID", "nombre", capitulo.temporadaID);
            return View(capitulo);
        }

        // GET: Capituloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Capitulo capitulo = db.Capituloes.Find(id);
            if (capitulo == null)
            {
                return HttpNotFound();
            }
            ViewBag.temporadaID = new SelectList(db.Temporadas, "temporadaID", "nombre", capitulo.temporadaID);
            return View(capitulo);
        }

        // POST: Capituloes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "capituloID,nombre,numero,imagen,video,temporadaID")] Capitulo capitulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capitulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.temporadaID = new SelectList(db.Temporadas, "temporadaID", "nombre", capitulo.temporadaID);
            return View(capitulo);
        }

        // GET: Capituloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Capitulo capitulo = db.Capituloes.Find(id);
            if (capitulo == null)
            {
                return HttpNotFound();
            }
            return View(capitulo);
        }

        // POST: Capituloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Capitulo capitulo = db.Capituloes.Find(id);
            db.Capituloes.Remove(capitulo);
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
