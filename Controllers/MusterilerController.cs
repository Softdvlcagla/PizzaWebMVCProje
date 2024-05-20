using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaWebMVCProje.Models;

namespace PizzaWebMVCProje.Controllers
{
    public class MusterilerController : Controller
    {
       
                PizzaCTX db = new PizzaCTX();
        public ActionResult Index()
        {
            var degerler = db.tblMusteriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(tblMusteriler p1)

        {
            db.tblMusteriler.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}