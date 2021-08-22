using Microsoft.AspNetCore.Mvc;
using MVCASP.Data;
using MVCASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP.Controllers
{
    public class SearchController : Controller
    {
        // Creacion de variable de tipo ApplicationDbContext
        private readonly ApplicationDBContext _db;

        public SearchController(ApplicationDBContext db)
        {
            // Dependy injection en constructor
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Get
        [HttpGet]
        public IActionResult User(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            Person obj = _db.People.FirstOrDefault(p => p.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        // POST - Buscar
        // SE DEBE PASAR EL ELEMENTO CREADO CON EL OBJETO DEL MODELO - asp-for para recibir la informacion
        [HttpPost]
        [Route("Search/User/{id?}")]
        public IActionResult User(int? id)
        {
            // Obtener el ID y pasar el valor guardandolo com objeto
            Person obj = _db.People.FirstOrDefault(p => p.Id == id);
            // return Content("Good " + Person);
            // Se pasa el objeto a la vista
            return View(obj);
           // return Content(obj.fName);
        }

    
        
    }
}
