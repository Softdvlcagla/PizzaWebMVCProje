using PizzaWebMVCProje.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PizzaWebMVCProje.Controllers
{
    public class KullaniciController : Controller
    {
        PizzaCTX db = new PizzaCTX();

        // GET: Kullanici
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Kullanicilar kullanici)
        {
            var Kullanici = db.Kullanicilar.FirstOrDefaultAsync(x => x.KullaniciEposta == kullanici.KullaniciEposta);
            if (Kullanici != null)
            {
                return RedirectToAction("YeniSatis", "Satislar");
               
            }

            return View();
        }
    }
}