#pragma checksum "C:\Tashik\My_Resources\C#\My_Website\Portfolio_Website\Views\Overview\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ad254fc0b8f1dbc051a1a5070c239ff6654b78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Overview_index), @"mvc.1.0.view", @"/Views/Overview/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77ad254fc0b8f1dbc051a1a5070c239ff6654b78", @"/Views/Overview/index.cshtml")]
    public class Views_Overview_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Tashik\My_Resources\C#\My_Website\Portfolio_Website\Views\Overview\index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_Design.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("TitleBar", async() => {
                WriteLiteral(@"

    <li> <a href=""https://localhost:44374/Home""> Home </a> </li>
    <li class=""current""> <a href=""https://localhost:44374/Overview""> Overview </a> </li>
    <li> <a href=""https://localhost:44374/Portfolio""> Portfolio </a> </li>
    <li> <a href=""https://localhost:44374/Contributions""> Contributions </a> </li>
    <li> <a href=""https://localhost:44374/About""> About </a> </li>
    <li> <a href=""https://localhost:44374/Contact""> Contact </a> </li>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("DisplayBackground", async() => {
                WriteLiteral(@"
    <section id=""showcase-overview"">
        <div id=""arrow-left"" class=""arrow""></div>
        <div id=""slider"">
            <div class=""slide slide1"">
                <div class=""slide-content"">
                </div>
            </div>
            <div class=""slide slide2"">
                <div class=""slide-content"">
                </div>
            </div>
            <div class=""slide slide3"">
                <div class=""slide-content"">
                </div>
            </div>
            <div class=""slide slide4"">
                <div class=""slide-content"">
                </div>
            </div>
            <div class=""slide slide5"">
                <div class=""slide-content"">
                </div>
            </div>
        </div>
        <div id=""arrow-right"" class=""arrow""></div>
    </section>
");
            }
            );
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
