using AppVol.data;
using AppVol.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppVol.Controllers
{
    public class VolController : Controller
    {


        private readonly ApplicationDbContext _db;
        public VolController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {


            var objvol = _db.vol.ToList();
            return View(objvol);
        }


       

       
        //Get

        public IActionResult Create()
        {
            return View();
        }

        //Post 
        [HttpPost]
        public IActionResult Create(vol obj)
        {
            _db.vol.Add(obj);
            _db.SaveChanges();
            return View(obj);
        }

        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            var volfromDb = _db.vol.Find(id);
            if (volfromDb == null) { return NotFound(); }

            return View(volfromDb);
        }


        //Post
        [HttpPost]
        

        public IActionResult Edit(vol obj)
        {
           
                _db.vol.Update(obj);
                _db.SaveChanges();
                 return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            var volfromDb = _db.vol.Find(id);
            if (volfromDb == null) { return NotFound(); }

            return View(volfromDb);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.vol.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.vol.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "flight deleted successfully";
            return RedirectToAction("Index");

        }











    }
}

