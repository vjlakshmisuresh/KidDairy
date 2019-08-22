using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diary.Controllers
{
 
    public class FoodController : Controller
    {
        private KidsDairyEntities db = new KidsDairyEntities();

        // GET: Food
        [HttpGet]
        public ActionResult Index()
        {
          
            return View("Food", db.Foods.ToList().OrderByDescending(x=>x.Date_Taken));
        }

        [HttpPost]
        public ActionResult AddFood(string Name, string FoodType, string Description, string dateTaken)
        {
            //convert date
            DateTime oDate = DateTime.ParseExact(dateTaken, "dd/MM/yyyy HH:mm", null);

            Food food = new Food(Name, FoodType, Description, oDate);
            db.Foods.Add(food);
            db.SaveChanges();
            return View("Food",db.Foods.ToList().OrderByDescending(x => x.Date_Taken));


        }
    }
}