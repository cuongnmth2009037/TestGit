using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGitDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Hello()
        {
            return View();
        }
    }
}