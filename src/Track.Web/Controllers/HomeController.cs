using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Track.Models;

namespace Track.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var tl = new List<TrackMain>
            {
                new TrackMain
                {
                    Id = Guid.NewGuid().ToString(),
                    Content = "",
                    Name = "test",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    CreateUser = "",
                    UpdateUser = ""
                }
            };
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
