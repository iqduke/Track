using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Track.Web.Areas.Adm.Controllers
{
    public class ControlController : AdmBaseController
    {

        // GET: Control
        public ActionResult Index()
        {
            return View();
        }

        // GET: Control/Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}