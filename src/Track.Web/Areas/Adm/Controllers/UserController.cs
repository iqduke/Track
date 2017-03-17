using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Track.Web.Areas.Adm.Controllers
{
    public class UserController : AdmBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Authen()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}