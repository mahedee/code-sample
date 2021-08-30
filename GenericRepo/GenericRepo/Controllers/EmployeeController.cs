using GenericRepo.Models;
using GenericRepo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepo.Controllers
{
    public class EmployeeController : Controller
    {
        private IGenericRepository<Employee> repository = null;
        public EmployeeController()
        {
            this.repository = new GenericRepository<Employee>();
        }


        // GET: Employee
        public ActionResult Index()
        {
            var employee = repository.SelectAll().ToList();
            return View(employee);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = repository.SelectByID(id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(employee);
                repository.Save();

                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = repository.SelectByID(id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                repository.Update(employee);
                repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = repository.SelectByID(id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.Delete(id);
                repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
