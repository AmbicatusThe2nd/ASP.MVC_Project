#pragma checksum "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Film\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0389695c4f6801cc97c4ed29492ae530d7401300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Uredi), @"mvc.1.0.view", @"/Views/Film/Uredi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0389695c4f6801cc97c4ed29492ae530d7401300", @"/Views/Film/Uredi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f877750a8b16ef9b32654984e3269a1076ccddfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Naloga2_Tkalcic.Models.Film>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Film\Uredi.cshtml"
  
    ViewData["Title"] = "Uredi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Uredi Podatke</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Film\Uredi.cshtml"
 using (Html.BeginForm("Uredi", "Film", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Film\Uredi.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Film\Uredi.cshtml"
                          ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-outline-primary\" value=\"Potrdi\">\r\n");
#nullable restore
#line 13 "C:\Users\PunisherTFB\Documents\Faks\DSR\Again\Naloga2_Tkalcic\Views\Film\Uredi.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Naloga2_Tkalcic.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
