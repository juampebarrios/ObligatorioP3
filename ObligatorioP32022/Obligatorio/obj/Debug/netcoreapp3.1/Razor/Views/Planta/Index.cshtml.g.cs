#pragma checksum "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7400b7694f20a4b58ac4f0134bc39a94b5106a85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_Index), @"mvc.1.0.view", @"/Views/Planta/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/_ViewImports.cshtml"
using Obligatorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/_ViewImports.cshtml"
using Obligatorio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7400b7694f20a4b58ac4f0134bc39a94b5106a85", @"/Views/Planta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65253820cfa563c16c185affac3169c36c6d594d", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Planta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
  
    ViewData["Title"] = "Listar Planta";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table>
    <thead>
        <tr>
            <td>NombreCientifico</td>
            <td>NombreVulgar</td>
            <td>Descripcion</td>
            <td>Ambiente</td>
            <td>AlturaMax</td>
            <td>Fecha Nacimiento</td>
            <td>Precio</td>
            <td></td>
        </tr>

    </thead>
    <tbody>

");
#nullable restore
#line 24 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 28 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 31 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreVulgar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 34 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 37 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 40 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AlturaMax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 43 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 46 "/Users/juampebarrios/Documents/GitHub/ObligatorioP3/ObligatorioP32022/Obligatorio/Views/Planta/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Planta>> Html { get; private set; }
    }
}
#pragma warning restore 1591