#pragma checksum "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58cc6ea1878fd41f0cde4849c83d8465a7e158a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_index), @"mvc.1.0.view", @"/Views/Escuela/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/index.cshtml", typeof(AspNetCore.Views_Escuela_index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/anthony/ASPNetCoreHolaMundo/Views/_ViewImports.cshtml"
using ASPNetCoreHolaMundo;

#line default
#line hidden
#line 2 "/Users/anthony/ASPNetCoreHolaMundo/Views/_ViewImports.cshtml"
using ASPNetCoreHolaMundo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58cc6ea1878fd41f0cde4849c83d8465a7e158a", @"/Views/Escuela/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4099a51c0cf3344ab3ce633f3660727fd99b26bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml"
  
    ViewData["Title"] = "Información Escuela";
   // Layout = "_Simple";

#line default
#line hidden
            BeginContext(94, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(100, 17, false);
#line 8 "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 18, true);
            WriteLiteral("</h1>\n<h2>Nombre: ");
            EndContext();
            BeginContext(136, 12, false);
#line 9 "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(148, 34, true);
            WriteLiteral("</h2>\n<p><strong>Año de Creación: ");
            EndContext();
            BeginContext(183, 19, false);
#line 10 "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml"
                       Write(Model.AñoDeCreación);

#line default
#line hidden
            EndContext();
            BeginContext(202, 21, true);
            WriteLiteral("</strong></p>\n\n<p><i>");
            EndContext();
            BeginContext(224, 20, false);
#line 12 "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(244, 23, true);
            WriteLiteral(" ViewBag</i></p>\n<p><i>");
            EndContext();
            BeginContext(268, 24, false);
#line 13 "/Users/anthony/ASPNetCoreHolaMundo/Views/Escuela/index.cshtml"
 Write(ViewData["CosaDinamica"]);

#line default
#line hidden
            EndContext();
            BeginContext(292, 17, true);
            WriteLiteral(" ViewData</i></p>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
