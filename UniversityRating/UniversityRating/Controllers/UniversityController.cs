using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityRating.Models;

namespace UniversityRating.Controllers
{
    public class UniversityController : Controller
    {
        private UniversityContext db = new UniversityContext();

        // GET: /University/
        public ActionResult Index()
        {
            var universities = db.Universities.Include(u => u.Category).Include(u => u.Country);
            return View(universities.ToList());
        }

        // GET: /University/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            University university = db.Universities.Find(id);
            if (university == null)
            {
                return HttpNotFound();
            }
            return View(university);
        }


        // Modify Create Action. 
        //GET: /University/Create
        public ActionResult Create()
        {
            //ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name");
            return View();
        }

        // Modifed following action
        // POST: /University/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,CountryId,CategoryId")] University university)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Universities.Add(university);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(Exception exp)
            {
                return RedirectToAction("Create");
            }

            //ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", university.CategoryId);
            //ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", university.CountryId);
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name");
            return View(university);
        }

        // Modifed following action
        // GET: /University/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            University university = db.Universities.Find(id);
            if (university == null)
            {
                return HttpNotFound();
            }
            //ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", university.CategoryId);
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", university.CountryId);
            return View(university);
        }


        // POST: /University/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,CountryId,CategoryId")] University university)
        {
            if (ModelState.IsValid)
            {
                db.Entry(university).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", university.CategoryId);
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", university.CountryId);
            return View(university);
        }

        // GET: /University/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            University university = db.Universities.Find(id);
            if (university == null)
            {
                return HttpNotFound();
            }
            return View(university);
        }

        // POST: /University/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            University university = db.Universities.Find(id);
            db.Universities.Remove(university);
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
