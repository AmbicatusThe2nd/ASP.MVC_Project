#pragma checksum "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4cf862378302ea9d3c1efdb75a010a478dd4bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Uporabnik), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Uporabnik.cshtml")]
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
#line 1 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\_ViewImports.cshtml"
using Naloga2_Tkalcic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\_ViewImports.cshtml"
using Naloga2_Tkalcic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cf862378302ea9d3c1efdb75a010a478dd4bdf", @"/Views/Shared/EditorTemplates/Uporabnik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f877750a8b16ef9b32654984e3269a1076ccddfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Uporabnik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Naloga2_Tkalcic.Models.Uporabnik>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"form-group row\">\r\n    ");
#nullable restore
#line 4 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.Ime, "Ime", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 6 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.EditorFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 7 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"form-group row\">\r\n    ");
#nullable restore
#line 11 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.Priimek, "Priimek", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 13 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.EditorFor(model => model.Priimek));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.Priimek));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"from-group row\">\r\n    ");
#nullable restore
#line 18 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.DatumRojstva, "Datum Rojstva", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 20 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.EditorFor(model => model.DatumRojstva, new { id = "datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.DatumRojstva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"from-group row\">\r\n    ");
#nullable restore
#line 25 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.EMSO, "EMSO", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 27 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.EditorFor(model => model.EMSO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.EMSO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"from-group row\">\r\n    ");
#nullable restore
#line 32 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.Starost, "Starost", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        <div>\r\n            ");
#nullable restore
#line 35 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
       Write(Html.EditorFor(model => model.Starost, new { id = "spreminjanje" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
       Write(Html.ValidationMessageFor(model => model.Starost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"from-group row\">\r\n    ");
#nullable restore
#line 41 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.KrajRojstva, "Kraj Rojstva", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 43 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.DropDownListFor(model => model.KrajRojstva, Uporabnik.GetItems()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.KrajRojstva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"form-group row\">\r\n    ");
#nullable restore
#line 50 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.Naslov, "Naslov", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 52 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.TextBoxFor(model => model.Naslov));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 53 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.Naslov));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"form-group row\">\r\n    ");
#nullable restore
#line 57 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.PostnaStevilka, "Postna Številka", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 59 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.EditorFor(model => model.PostnaStevilka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 60 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.PostnaStevilka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"from-group row\">\r\n    ");
#nullable restore
#line 64 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.Posta, "Pošta", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 66 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.TextBoxFor(model => model.Posta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 67 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.Posta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"from-group row\">\r\n    ");
#nullable restore
#line 71 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.Drzava, "Država", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 73 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.TextBoxFor(model => model.Drzava));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 74 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.Drzava));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"form-group row\">\r\n    ");
#nullable restore
#line 80 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
Write(Html.LabelFor(model => model.EPosta, "E-Pošta", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 82 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.EditorFor(model => model.EPosta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 83 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Shared\EditorTemplates\Uporabnik.cshtml"
   Write(Html.ValidationMessageFor(model => model.EPosta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Naloga2_Tkalcic.Models.Uporabnik> Html { get; private set; }
    }
}
#pragma warning restore 1591
