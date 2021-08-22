using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP.Controllers
{
    public class FAQ : Controller
    {
        public IActionResult Index()
        {
            return Content("En este caso no se ingresa aca si no en la ruta convencional de abajo");
        }

        // This is conventional routing
        [Route("faq")]
        public IActionResult test()
        {   
            // Return the name of the view
            return View();
        }
    }
}
