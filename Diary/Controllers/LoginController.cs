using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Diary.Controllers
{
    public class LoginController : Controller
    {
        // GET: Home
      //  public ActionResult Login()
      //  {
       //     return View();
      //  }
        public ActionResult Login(Login login)
        {
            if (!ModelState.IsValid)
            {
               
            }
            return View();
        }
    }
}