using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diary.Controllers
{
    public class DiapersController : Controller
    {
        private KidsDairyEntities db = new KidsDairyEntities();

        // GET: Diapers
        [HttpGet]
        public ActionResult Index()
        {
         
            return View("Diaper", db.Diapers.ToList().OrderByDescending(x=>x.Date_Used));
        }

        [HttpPost]
        public ActionResult AddDiapers( int numberOfDiapers, string dateUsed)
        {
            //convert date
            DateTime oDate = DateTime.ParseExact(dateUsed, "dd/MM/yyyy HH:mm", null);

            Diaper diaper = new Diaper(numberOfDiapers, oDate);
            db.Diapers.Add(diaper);
            db.SaveChanges();
            return View("Diaper", db.Diapers.ToList().OrderByDescending(x => x.Date_Used));


        }
    }
}