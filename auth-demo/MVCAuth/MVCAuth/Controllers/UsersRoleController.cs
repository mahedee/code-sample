using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuth.Controllers
{
    public class UsersRoleController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: UsersRole
        public ActionResult Index()
        {
            List<UsersRolesVM> usersRolesVMs = new List<UsersRolesVM>();
            List<ApplicationUser> users = db.Users.ToList();

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            foreach (ApplicationUser user in users)
            {
                UsersRolesVM usersRolesVM = new UsersRolesVM();
                usersRolesVM.User = user;
                usersRolesVM.RoleNames = userManager.GetRoles(user.Id);
                usersRolesVMs.Add(usersRolesVM);
            }
            return View(usersRolesVMs);
        }

        // GET: UsersRole/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersRole/Create
        public ActionResult Create()
        {

            var roleStore = new RoleStore<IdentityRole>(db);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var roles = roleManager.Roles.ToList();


            ViewBag.UserId = new SelectList(db.Users.ToList(), "Id", "UserName");
            ViewBag.RoleName = new SelectList(roles, "Name", "Name");

            return View();
        }

        // POST: UsersRole/Create
        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        public ActionResult Create(UserRoleVM userRole)
        {
            try
            {
               if(userRole != null)
                {
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                    userManager.AddToRole(userRole.UserId, userRole.RoleName);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersRole/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersRole/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersRole/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersRole/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
