using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Info action redirection
        public ActionResult infoAction()
        {
            //return Content("Demo info action");
            return View();
        }
    }
}
