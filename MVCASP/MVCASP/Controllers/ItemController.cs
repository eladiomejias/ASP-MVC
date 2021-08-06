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

        // Action default
        public IActionResult Index()
        {
            IEnumerable<Person> objList = _db.People;
            return View(objList);
        }


        // Action para el url de create
        // GET - Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person obj)
        {

            // Using EF to add the item
            //System.Diagnostics.Debug.WriteLine(obj.fName);
            _db.People.Add(obj);
            _db.SaveChanges();


            //return View();
            return RedirectToAction("Index");
        }

        // Delete - POST Delete - int? means optional id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {

            var obj = _db.People.Find(id);

            if(obj == null)
            {
                return NotFound();
            }
            
            _db.People.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // Delete - GET
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.People.Find(id);

            if(obj == null)
            {
               return NotFound();

            }

            return View(obj);
            

        }

        // Delete
        /* public IActionResult Update(Person id)
         {

         }*/


    }
}
