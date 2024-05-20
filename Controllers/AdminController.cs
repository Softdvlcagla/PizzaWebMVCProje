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
    public class AdminController : Controller
    {
        PizzaCTX db = new PizzaCTX();
        // GET: Admin
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Yoneticiler kullanici)
        {
            var Kullanici = db.Kullanicilar.FirstOrDefaultAsync(x => x.KullaniciEposta == kullanici.Mail);
            if (Kullanici != null)
            {
                return RedirectToAction("UrunEkle", "Urunler");

            }

            return View();
        }
    }
}