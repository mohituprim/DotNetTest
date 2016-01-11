using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationTest.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string GetString()
        {
            return "Hello World is old now. It&rsquo;s time for wassup bro ;)";
            ///testing git hub
        }
    }
}
