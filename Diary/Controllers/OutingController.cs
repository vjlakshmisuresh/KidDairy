using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diary.Controllers
{
    public class OutingController : Controller
    {
        private KidsDairyEntities db = new KidsDairyEntities();
        // GET: Outing
        [HttpGet]
        public ActionResult Index()
        {
      
            return View("Outing", db.Outings.ToList().OrderByDescending(x=>x.Outing_Date));
        }

        [HttpPost]
        public ActionResult AddOuting(string name, string outingDate,string description)
        {
            //convert date
            DateTime oDate = DateTime.ParseExact(outingDate, "dd/MM/yyyy HH:mm", null);

            Outing outing = new Outing(name, oDate, description);
            db.Outings.Add(outing);
            db.SaveChanges();
            return View("Outing",db.Outings.ToList().OrderByDescending(x=>x.Outing_Date));


        }
    }
}