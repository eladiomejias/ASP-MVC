using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP.Controllers
{
    public class PersonController : Controller
    {

        [Route("/person/{id?}")]
        public IActionResult Index(int id)
        {
            // return View();
            if (String.IsNullOrEmpty(id.ToString()))
            {
                id = 1000;
            }

            return Content("El id es " + id);
        }



    }
}
