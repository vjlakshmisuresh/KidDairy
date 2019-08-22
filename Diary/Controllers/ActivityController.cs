using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diary.Controllers
{
    public class ActivityController : Controller
    {
        private KidsDairyEntities db = new KidsDairyEntities();

        // GET: Activity
        [HttpGet]
        public ActionResult Index()
        {

            return View ("Activity", db.Activities.ToList().OrderByDescending(x=>x.Activity_Date)) ;
        }

        [HttpPost]
        public ActionResult AddActivity(string Name, string Description, string activityDate)
        {
            //convert date
            DateTime oDate = DateTime.ParseExact(activityDate, "dd/MM/yyyy HH:mm", null);

            Activity activity = new Activity(Name, Description, oDate);
            db.Activities.Add(activity);
            db.SaveChanges();
            return View("Activity",db.Activities.ToList().OrderByDescending(x => x.Activity_Date));


        }

      
    }
}