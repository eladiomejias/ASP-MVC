using Microsoft.AspNetCore.Mvc;
using MVCASP.Data;
using MVCASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP.Controllers
{
    public class ItemController : Controller
    {
        // Creacion de variable de tipo ApplicationDbContext
        private readonly ApplicationDBContext _db;

        public ItemController(ApplicationDBContext db)
        {
            // Dependy injection en constructor
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Person> objList = _db.People;
            return View(objList);
        }
    }
}
