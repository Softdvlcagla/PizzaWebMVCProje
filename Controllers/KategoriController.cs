using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaWebMVCProje.Models;

namespace PizzaWebMVCProje.Controllers
{
    public class KategoriController : Controller
    {
       
                PizzaCTX db = new PizzaCTX();
        public ActionResult Index()
        {
            var degerler = db.tblKategoriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yenikategori()
        {
            return View();
        }
        [HttpPost]
        public  ActionResult Yenikategori(tblKategoriler p1)
        {
            db.tblKategoriler.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}