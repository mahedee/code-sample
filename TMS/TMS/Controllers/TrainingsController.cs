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
    public class TrainingsController : Controller
    {
        private TMSContext context = new TMSContext();

        //
        // GET: /Trainings/

        public ViewResult Index()
        {
            return View(context.Trainings.Include(training => training.Trainer).ToList());
        }

        //
        // GET: /Trainings/Details/5

        public ViewResult Details(long id)
        {
            Training training = context.Trainings.Single(x => x.Id == id);
            return View(training);
        }

        //
        // GET: /Trainings/Create

        public ActionResult Create()
        {
            ViewBag.PossibleTrainers = context.Trainers;
            return View();
        } 

        //
        // POST: /Trainings/Create

        [HttpPost]
        public ActionResult Create(Training training)
        {
            if (ModelState.IsValid)
            {
                context.Trainings.Add(training);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleTrainers = context.Trainers;
            return View(training);
        }
        
        //
        // GET: /Trainings/Edit/5
 
        public ActionResult Edit(long id)
        {
            Training training = context.Trainings.Single(x => x.Id == id);
            ViewBag.PossibleTrainers = context.Trainers;
            return View(training);
        }

        //
        // POST: /Trainings/Edit/5

        [HttpPost]
        public ActionResult Edit(Training training)
        {
            if (ModelState.IsValid)
            {
                context.Entry(training).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleTrainers = context.Trainers;
            return View(training);
        }

        //
        // GET: /Trainings/Delete/5
 
        public ActionResult Delete(long id)
        {
            Training training = context.Trainings.Single(x => x.Id == id);
            return View(training);
        }

        //
        // POST: /Trainings/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Training training = context.Trainings.Single(x => x.Id == id);
            context.Trainings.Remove(training);
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