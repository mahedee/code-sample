using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Controllers
{   
    public class TrainersController : Controller
    {
        private TMSContext context = new TMSContext();

        //
        // GET: /Trainers/

        public ViewResult Index()
        {
            return View(context.Trainers.ToList());
        }

        //
        // GET: /Trainers/Details/5

        public ViewResult Details(long id)
        {
            Trainer trainer = context.Trainers.Single(x => x.Id == id);
            return View(trainer);
        }

        //
        // GET: /Trainers/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Trainers/Create

        [HttpPost]
        public ActionResult Create(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                context.Trainers.Add(trainer);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(trainer);
        }
        
        //
        // GET: /Trainers/Edit/5
 
        public ActionResult Edit(long id)
        {
            Trainer trainer = context.Trainers.Single(x => x.Id == id);
            return View(trainer);
        }

        //
        // POST: /Trainers/Edit/5

        [HttpPost]
        public ActionResult Edit(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                context.Entry(trainer).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainer);
        }

        //
        // GET: /Trainers/Delete/5
 
        public ActionResult Delete(long id)
        {
            Trainer trainer = context.Trainers.Single(x => x.Id == id);
            return View(trainer);
        }

        //
        // POST: /Trainers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Trainer trainer = context.Trainers.Single(x => x.Id == id);
            context.Trainers.Remove(trainer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}