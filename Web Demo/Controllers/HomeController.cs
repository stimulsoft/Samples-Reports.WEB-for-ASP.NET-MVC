using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Console.WriteLine("this is a debug output so we can see that the application is working.");
            System.Diagnostics.Debug.WriteLine("SomeText for debug output");
            return View();
        }
    }
}