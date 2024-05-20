using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaWebMVCProje.Models;

namespace PizzaWebMVCProje.Controllers
{
    public class UrunlerController : Controller
    {
       
        PizzaCTX db = new PizzaCTX();
        public ActionResult Index()
        {
            var degerler = db.tblUrunler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(tblUrunler p1)
        {
            db.tblUrunler.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}