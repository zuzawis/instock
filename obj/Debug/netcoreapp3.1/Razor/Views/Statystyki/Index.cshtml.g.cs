#pragma checksum "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Statystyki/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba5968835597c71af7d35c5feee1aed73f84a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statystyki_Index), @"mvc.1.0.view", @"/Views/Statystyki/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba5968835597c71af7d35c5feee1aed73f84a62", @"/Views/Statystyki/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ab4790eedc05e8d8b3d6e78393b67a80f22571", @"/Views/_ViewImports.cshtml")]
    public class Views_Statystyki_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Statystyki</h1>
<button onclick=""window.location.href='/statystyki/sprzedazdnia'"" class=""btn btn-dark"">Sprzedaż dnia</button>
<button onclick=""window.location.href='/statystyki/sprzedazrozmiarowek'"" class=""btn btn-dark"">Sprzedaż rozmiarówek</button>
<button onclick=""window.location.href='/statystyki/sprzedazmiesieczna'"" class=""btn btn-dark"">Sprzedaż miesięczna</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
