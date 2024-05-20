using PizzaWebMVCProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaWebMVCProje.Controllers
{
    public class SatislarController : Controller
    {
        PizzaCTX db = new PizzaCTX();
        // GET: Satislar
        public ActionResult Index()
        {
            var degerler = db.tblSatislar.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]

        public ActionResult YeniSatis(tblSatislar p1)
        {
            db.tblSatislar.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}
    