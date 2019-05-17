
**Comenzamos Creando un Proyecto en ASP.Net Core:**
    **Escribir en el Terminal:** dotnet new mvc -o ASPNetCoreHolaMundo

**Modificaciones que se hicieron en este proyecto**

**Para ejecutar la app web** 
    **Comando en MAC:** fn F5
    **Comando en Windows:** F5

**Models/Escuela.cs**

    namespace HolaMundoMVC.Models
    {
        public class Escuela
        {
            public string EscuelaId { get; set; }
            public string Nombre { get; set; }
            public int AñoFundación { get; set; }
        }
    }

**Views/Escuela/Index.cshtml** 

    @model Escuela

    @{
        ViewData["Title"] = "Información Escuela";
    }

    <h1>@ViewData["Title"]</h1>
    <h2>Nombre: @Model.Nombre</h2>
    <p><strong>Año Fundación: @Model.AñoFundación</strong></p>

    <p><i>@ViewBag.CosaDinamica ViewBag</i></p>
    <p><i>@ViewData["CosaDinamica"] ViewData</i></p>

**Controllers/EscuelaControllers.cs**

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

**Shared/_Simple.cshtml**

    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>@ViewData["Title"] - ASPNetCoreHolaMundo</title>

        <environment include="Development">
            <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />
        </environment>
        <environment exclude="Development">
            <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
                asp-fallback-href="~/lib/bootstrap/dist/css/bootstrap.min.css"
                asp-fallback-test-class="sr-only" asp-fallback-test-property="position" asp-fallback-test-value="absolute"
                crossorigin="anonymous"
                integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"/>
        </environment>
        <link rel="stylesheet" href="~/css/site.css" />
    </head>
    <body>
    @RenderBody()
    </body>
    </html>
