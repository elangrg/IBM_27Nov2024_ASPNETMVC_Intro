using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM_27Nov2024_ASPNETMVC_Intro.Controllers
{
    public class RazorViewEngineIntroController : Controller
    {
        // GET: RazorViewEngineIntro
        public ActionResult RazorSyntax()
        {
            return View();
        }


        public ActionResult LayoutContentWithSection()
        {
            return View();
        }

        public ActionResult NestedLayoutContent()
        {
            return View();
        }
    }
}