using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM_27Nov2024_ASPNETMVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        
        [NonAction]
        public string InternalFunctionality()
        {

            return "Internal Some Func";
        }

        public string SayHello()
        {

            return "Hello!!!";
        }



        public ContentResult SayHello1()
        {

            return Content("Hello!!!");
        }








    }
}