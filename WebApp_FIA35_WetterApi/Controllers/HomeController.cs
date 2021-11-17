using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WebApp_FIA35_WetterApi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Wetter(string Ort)
        {
            Models.Wetter wetter = new Models.Wetter
            {
                Ort = "Unbekannt"
            };

            if (Ort == "Oberhausen")
            {
                wetter.Ort = "Oberhausen";
                wetter.Temperatur = new Random().Next(5, 15);
                wetter.Luftdruck = new Random().Next(950, 1050);
            }

            if (Ort == "Neuss")
            {
                wetter.Ort = "Neuss";
                wetter.Temperatur = new Random().Next(5, 15);
                wetter.Luftdruck = new Random().Next(950, 1050);
            }

            if (Ort == "Nienborg")
            {
                wetter.Ort = "Nienborg";
                wetter.Temperatur = new Random().Next(5, 15);
                wetter.Luftdruck = new Random().Next(950, 1050);
            }


            return Json(wetter, new JsonSerializerOptions { WriteIndented = true });
        }


        // Ohne Funktion, nur Demo
        [HttpPost]
        public IActionResult Wetter()
        {
            return Ok(); // Status-Code 200
        }


}
