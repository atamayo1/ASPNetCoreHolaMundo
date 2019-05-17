**Crear proyecto en ASP.Net Core:**
dotnet new mvc -o HolaMundoMVC

**Para ejecutar la app web** 
**Comando:** fn F5

**Models/Escuela**

    namespace HolaMundoMVC.Models
    {
        public class Escuela
        {
            public string EscuelaId { get; set; }
            public string Nombre { get; set; }
            public int AñoFundación { get; set; }
        }
    }

**Views/Escuela/Index** 

    @model Escuela

    @{
        ViewData["Title"] = "Información Escuela";
    }

    <h1>@ViewData["Title"]</h1>
    <h2>Nombre: @Model.Nombre</h2>
    <p><strong>Año Fundación: @Model.AñoFundación</strong></p>

    <p><i>@ViewBag.CosaDinamica ViewBag</i></p>
    <p><i>@ViewData["CosaDinamica"] ViewData</i></p>

**Controllers/EscuelaControllers**

    using System;
    using Microsoft.AspNetCore.Mvc;
    using HolaMundoMVC.Models;

    namespace HolaMundoMVC.Controllers
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
