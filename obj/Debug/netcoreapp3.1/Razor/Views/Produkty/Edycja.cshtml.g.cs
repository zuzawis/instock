#pragma checksum "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8c898885cf8436fd7d071b93d50c7f112f5360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produkty_Edycja), @"mvc.1.0.view", @"/Views/Produkty/Edycja.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8c898885cf8436fd7d071b93d50c7f112f5360", @"/Views/Produkty/Edycja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ab4790eedc05e8d8b3d6e78393b67a80f22571", @"/Views/_ViewImports.cshtml")]
    public class Views_Produkty_Edycja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InStock.Database.Produkt>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Produkty/Edycja"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Edycja produktu</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec8c898885cf8436fd7d071b93d50c7f112f53604228", async() => {
                WriteLiteral("\n  <div class=\"row mb-3\">\n    <div class=\"col-3\">\n      <label for=\"K\">Kod produktu</label>\n      <input type=\"text\" class=\"form-control\" placeholder=\"Kod\" name=\"Kod\"");
                BeginWriteAttribute("value", " value=\"", 309, "\"", 327, 1);
#nullable restore
#line 12 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 317, Model.Kod, 317, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    </div>\n    <div class=\"col-9\">\n      <label for=\"Nazwa\">Nazwa</label>\n      <input type=\"text\" class=\"form-control\" placeholder=\"Nazwa\" name=\"Nazwa\"");
                BeginWriteAttribute("value", " value=\"", 482, "\"", 502, 1);
#nullable restore
#line 16 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 490, Model.Nazwa, 490, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    </div>\n  </div>\n    <div class=\"row mb-3\">\n     <div class=\"col\">\n      <label for=\"Ilość rozmiaru XS\">Rozmiar XS</label>\n      <input type=\"number\" class=\"form-control\" placeholder=\"Ilość rozmiaru XS\" name=\"RozmiarXS\"");
                BeginWriteAttribute("value", " value=\"", 727, "\"", 751, 1);
#nullable restore
#line 22 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 735, Model.RozmiarXS, 735, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" max=\"5\">\n    </div>\n    <div class=\"col\">\n      <label for=\"Ilość rozmiaru S\">Rozmiar S</label>\n      <input type=\"number\" class=\"form-control\" placeholder=\"Ilość rozmiaru S\" name=\"RozmiarS\"");
                BeginWriteAttribute("value", " value=\"", 951, "\"", 974, 1);
#nullable restore
#line 26 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 959, Model.RozmiarS, 959, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" max=\"5\">\n    </div>\n    <div class=\"col\">\n      <label for=\"Ilość rozmiaru M\">Rozmiar M</label>\n      <input type=\"number\" class=\"form-control\" placeholder=\"Ilość rozmiaru M\" name=\"RozmiarM\"");
                BeginWriteAttribute("value", " value=\"", 1174, "\"", 1197, 1);
#nullable restore
#line 30 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 1182, Model.RozmiarM, 1182, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" max=\"5\">\n    </div>\n    <div class=\"col\">\n      <label for=\"Ilość rozmiaru L\">Rozmiar L</label>\n      <input type=\"number\" class=\"form-control\" placeholder=\"Ilość rozmiaru L\" name=\"RozmiarL\"");
                BeginWriteAttribute("value", " value=\"", 1397, "\"", 1420, 1);
#nullable restore
#line 34 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 1405, Model.RozmiarL, 1405, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" max=\"5\">\n    </div>\n    <div class=\"col\">\n      <label for=\"Ilość rozmiaru XL\">Rozmiar XL</label>\n      <input type=\"number\" class=\"form-control\" placeholder=\"Ilość rozmiaru XL\" name=\"RozmiarXL\"");
                BeginWriteAttribute("value", " value=\"", 1624, "\"", 1648, 1);
#nullable restore
#line 38 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 1632, Model.RozmiarXL, 1632, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" max=\"5\">\n    </div>\n    </div>\n   <div class=\"row mb-3\">\n    <div class=\"col\">\n      <label for=\"Cena\">Cena</label>\n      <input type=\"text\" class=\"form-control\" placeholder=\"Cena\" name=\"Cena\"");
                BeginWriteAttribute("value", " value=\"", 1850, "\"", 1869, 1);
#nullable restore
#line 44 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 1858, Model.Cena, 1858, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    </div>\n   </div>\n      <input type=\"hidden\" class=\"form-control\" placeholder=\"ProduktId\" name=\"ProduktId\"");
                BeginWriteAttribute("value", " value=\"", 1981, "\"", 2005, 1);
#nullable restore
#line 47 "/Users/zuziawisniewska/Documents/studia/semV/pp/roboczyprojekt/zuzannawisniewska-instock/Views/Produkty/Edycja.cshtml"
WriteAttributeValue("", 1989, Model.ProduktId, 1989, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n  <button type=\"submit\" class=\"btn btn-primary\">Edytuj</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InStock.Database.Produkt> Html { get; private set; }
    }
}
#pragma warning restore 1591
