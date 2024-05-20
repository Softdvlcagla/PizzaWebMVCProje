using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace PizzaWebMVCProje.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
        
    }
}