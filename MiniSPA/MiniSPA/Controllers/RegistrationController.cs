using MiniSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniSPA.Controllers
{
    public class RegistrationController : Controller
    {
        private JSONBuilder jsonBuilder = new JSONBuilder();

        public ActionResult Index()
        {
            return View(jsonBuilder.BuildRegistrationVm());
        }

    }
}
