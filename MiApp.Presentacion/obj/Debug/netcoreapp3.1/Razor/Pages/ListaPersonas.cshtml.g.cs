#pragma checksum "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672406fefd4f4489c2400e50fed8c21e2cf48476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MiApp.Presentacion.Pages.Pages_ListaPersonas), @"mvc.1.0.razor-page", @"/Pages/ListaPersonas.cshtml")]
namespace MiApp.Presentacion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\_ViewImports.cshtml"
using MiApp.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672406fefd4f4489c2400e50fed8c21e2cf48476", @"/Pages/ListaPersonas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc12a32807eb5d115115b640528d93083e6c22b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ListaPersonas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Personas</h1>
    <table class=""table"">
        <tr>
            <th>
                Nombres
            </th>
            <th>
                Apellidos
            </th>
            <th>
                Edad
            </th>
            <th>
                Género
            </th>
            <th>
                Documento
            </th>
        </tr>
");
#nullable restore
#line 25 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
 foreach (var persona in Model.Personas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 28 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
       Write(persona.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
       Write(persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
       Write(persona.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
       Write(persona.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
       Write(persona.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 34 "C:\Ejemplo\MiApp\MiApp\MiApp.Presentacion\Pages\ListaPersonas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiApp.Presentacion.Pages.ListaPersonasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiApp.Presentacion.Pages.ListaPersonasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MiApp.Presentacion.Pages.ListaPersonasModel>)PageContext?.ViewData;
        public MiApp.Presentacion.Pages.ListaPersonasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591