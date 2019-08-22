using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diary.Controllers
{
    public class SleepController : Controller
    {
        private KidsDairyEntities db = new KidsDairyEntities();

        // GET: Sleep
        [HttpGet]
        public ActionResult Index()
        {
            return View("Sleep", db.Sleeps.ToList().OrderByDescending(x=>x.Date_Created));
        }

        [HttpPost]
        public ActionResult AddSleep(string bedTime, string wakeUpTime)
        {
            //convert date
            DateTime bTime = DateTime.ParseExact(bedTime, "dd/MM/yyyy HH:mm", null);
            DateTime wTime = DateTime.ParseExact(wakeUpTime, "dd/MM/yyyy HH:mm", null);

            Sleep sleep = new Sleep(bTime, wTime);
            db.Sleeps.Add(sleep);
            db.SaveChanges();
            return View("Sleep",db.Sleeps.ToList().OrderByDescending(x=>x.Date_Created));


        }
    }
}