using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ebOdev2.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult FilmBilgi(Models.Bilgiler data)
        {
            var bilgi = new Models.Bilgiler();
            bilgi.FilmAdi = "Tenet";
            bilgi.Yonetmen = "Christopher Nolan ";
            bilgi.Turu = "Aksiyon,Bilim Kurgu";
            bilgi.ImdbPuani = 7.6;

            return View(bilgi);
        }
    }
}