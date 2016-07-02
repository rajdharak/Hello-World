using System;
using System.Collections.Generic; //define generic collections
using System.Linq; //language integrated query
using System.Web;  //to read http values
using System.Web.Mvc; //supports mvc framework

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Mycontroller()
        {
            return "Hi, this is controller";
        }
        public ActionResult MyView()
        {
            return View();
        }
       
    }
}
//controllername/actionname/idparameter