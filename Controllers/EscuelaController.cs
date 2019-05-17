using System;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreHolaMundo.Models;

namespace ASPNetCoreHolaMundo.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundación = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "AnthonyJobs";

            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}