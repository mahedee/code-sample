using MarkdownToHtml.Models;
using MarkdownToHtml.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MarkdownToHtml.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string markdownText = "## This is a title of Markdown file ";
            string htmltext = MarkDownParser.Parse(markdownText);
            htmltext += MarkDownParser.Parse("  ") ;// for new line
            htmltext += MarkDownParser.Parse("__Strong text__");// for new line

            htmltext += MarkDownParser.Parse("  ");// for new line
            htmltext += MarkDownParser.Parse("* This is a bullet point");// bullet point
            ViewBag.HTMLText = htmltext;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
