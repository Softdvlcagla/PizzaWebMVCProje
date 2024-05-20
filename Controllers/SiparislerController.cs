using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaWebMVCProje.Models;

namespace PizzaWebMVCProje.Controllers
{
    public class SiparislerController : Controller
    {
                PizzaCTX db = new PizzaCTX();
        public ActionResult Index()
        {
            var degerler = db.tblSiparisler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yenisiparis()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Yenisiparis(tblSiparisler p1)
        {
            db.tblSiparisler.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult FiyatGetir(string urunAdi)
        {
            using (var dbContext = new PizzaCTX())
            {
                var urunler = dbContext.tblUrunler.Where(u => u.UrunAdi.Contains(urunAdi)).ToList();

                if (urunler.Any())
                {
                    var fiyatlar = urunler.Select(u => u.Fiyat.ToString()).ToList();
                    return Content(string.Join(", ", fiyatlar));
                }
                else
                {
                    return Content("Ürün bulunamadı.");
                }
            }
        }

    }
}