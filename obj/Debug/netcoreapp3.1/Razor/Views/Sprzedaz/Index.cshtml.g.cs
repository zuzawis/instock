#pragma checksum "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0309a24b394343cc48e5954d5757ad2284d5df0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sprzedaz_Index), @"mvc.1.0.view", @"/Views/Sprzedaz/Index.cshtml")]
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
#line 1 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/_ViewImports.cshtml"
using InStock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/_ViewImports.cshtml"
using InStock.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0309a24b394343cc48e5954d5757ad2284d5df0b", @"/Views/Sprzedaz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ab4790eedc05e8d8b3d6e78393b67a80f22571", @"/Views/_ViewImports.cshtml")]
    public class Views_Sprzedaz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<InStock.Database.Sprzedaz>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Sprzedane</h1>

<p id=""date""></p>
<script>
    document.getElementById(""date"").innerHTML = Date();
</script>


<style>
    table {
        width: 100%;
        border-color: #000000;
    }

    th,
    td {
        padding: 7px 10px 10px 10px;
    }

    th {
        text-transform: uppercase;
        font-size: 90%;
        text-align: center;
    }

    tr.even {
        background-color: #efefef;
    }

    tr.hover {
        background-color: #c3e6e5;
    }
</style>

<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th style=""vertical-align: middle"">Data</th>
            <th style=""vertical-align: middle"">Kod</th>
            <th style=""vertical-align: middle"">Nazwa</th>
            <th style=""vertical-align: middle"">Ilosc</th>
            <th style=""vertical-align: middle"">Cena</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 52 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
         foreach (var sprzedane in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 55 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
               Write(sprzedane.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 56 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
               Write(sprzedane.Produkt.Kod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 57 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
               Write(sprzedane.Produkt.Nazwa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <div>\n                        Rozmiar XS: ");
#nullable restore
#line 60 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
                               Write(sprzedane.RozmiarXS);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div>\n                        Rozmiar S: ");
#nullable restore
#line 63 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
                              Write(sprzedane.RozmiarS);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div>\n                        Rozmiar M: ");
#nullable restore
#line 66 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
                              Write(sprzedane.RozmiarM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div>\n                        Rozmiar L: ");
#nullable restore
#line 69 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
                              Write(sprzedane.RozmiarL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div>\n                        Rozmiar XL: ");
#nullable restore
#line 72 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
                               Write(sprzedane.RozmiarXL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </td>\n                <td>");
#nullable restore
#line 75 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
               Write(sprzedane.Produkt.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 77 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Sprzedaz/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<InStock.Database.Sprzedaz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
