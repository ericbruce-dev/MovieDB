#pragma checksum "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "410f22328eca7687a43709ddcdf3812e3606d134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Code\MovieDB\MovieDB\Views\_ViewImports.cshtml"
using MovieDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\MovieDB\MovieDB\Views\_ViewImports.cshtml"
using MovieDB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
using MovieDB.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410f22328eca7687a43709ddcdf3812e3606d134", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20929693dcaafb44f6e41c194896a0c674026529", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LandingPageVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-warning btn-block font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "MovieDB";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .clampOverview {
        display: -webkit-box;
        -webkit-line-clamp: 3;
        -webkit-box-orient: vertical;
        overflow: hidden;
    }

    .clampTitle {
        display: -webkit-box;
        -webkit-line-clamp: 2;
        -webkit-box-orient: vertical;
        overflow: hidden;
    }

    h5.card-title {
        height: 2.5em;
    }
</style>

<section class=""px-4"">
    <div class=""row"">
        <span class=""btn btn-lg btn-block btn-warning font-weight-bolder border-dark"">UPCOMING</span>
    </div>
    <div class=""row"">
        <div class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"">
");
#nullable restore
#line 35 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                  
                    var classText = "active";
                    for (var slide = 0; slide <= 3; slide++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 959, "\"", 991, 2);
            WriteAttributeValue("", 967, "carousel-item", 967, 13, true);
#nullable restore
#line 39 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 980, classText, 981, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 41 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                 foreach (var movie in Model.Upcoming.results.Skip(slide * 4).Take(4))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-sm-3 mb-2\">\r\n                                        <div class=\"card\" style=\"width: 18rem;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1376, "\"", 1400, 1);
#nullable restore
#line 45 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue("", 1382, movie.poster_path, 1382, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                                            <div class=\"card-body\">\r\n                                                <h5 class=\"card-title clampTitle\">");
#nullable restore
#line 47 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                             Write(movie.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <p class=\"card-text clampOverview\">");
#nullable restore
#line 48 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                              Write(movie.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f22328eca7687a43709ddcdf3812e3606d1347526", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(movie.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 53 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 56 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                        classText = "";
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>

<section class=""px-4"">
    <div class=""row"">
        <span class=""btn btn-lg btn-block btn-warning font-weight-bolder border-dark"">NOW PLAYING</span>
    </div>
    <div class=""row"">
        <div class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"">
");
#nullable restore
#line 71 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                  
                    classText = "active";
                    for (var slide = 0; slide <= 3; slide++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 2758, "\"", 2790, 2);
            WriteAttributeValue("", 2766, "carousel-item", 2766, 13, true);
#nullable restore
#line 75 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2779, classText, 2780, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 77 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                 foreach (var movie in Model.NowPlaying.results.Skip(slide * 4).Take(4))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-sm-3 mb-2\">\r\n                                        <div class=\"card\" style=\"width: 18rem;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3177, "\"", 3201, 1);
#nullable restore
#line 81 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue("", 3183, movie.poster_path, 3183, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                                            <div class=\"card-body\">\r\n                                                <h5 class=\"card-title clampTitle\">");
#nullable restore
#line 83 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                             Write(movie.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <p class=\"card-text clampOverview\">");
#nullable restore
#line 84 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                              Write(movie.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f22328eca7687a43709ddcdf3812e3606d13413527", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(movie.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 89 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 92 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                        classText = "";
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>

<section class=""px-4"">
    <div class=""row"">
        <span class=""btn btn-lg btn-block btn-warning font-weight-bolder border-dark"">POPULAR</span>
    </div>
    <div class=""row"">
        <div class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"">
");
#nullable restore
#line 107 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                  
                    classText = "active";
                    for (var slide = 0; slide <= 3; slide++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 4555, "\"", 4587, 2);
            WriteAttributeValue("", 4563, "carousel-item", 4563, 13, true);
#nullable restore
#line 111 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4576, classText, 4577, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 113 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                 foreach (var movie in Model.Popular.results.Skip(slide * 4).Take(4))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-sm-3 mb-2\">\r\n                                        <div class=\"card\" style=\"width: 18rem;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 4971, "\"", 4995, 1);
#nullable restore
#line 117 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue("", 4977, movie.poster_path, 4977, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                                            <div class=\"card-body\">\r\n                                                <h5 class=\"card-title clampTitle\">");
#nullable restore
#line 119 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                             Write(movie.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <p class=\"card-text clampOverview\">");
#nullable restore
#line 120 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                              Write(movie.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f22328eca7687a43709ddcdf3812e3606d13419528", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(movie.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 125 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 128 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                        classText = "";
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>

<section class=""px-4"">
    <div class=""row"">
        <span class=""btn btn-lg btn-block btn-warning font-weight-bolder border-dark"">TOP RATED</span>
    </div>
    <div class=""row"">
        <div class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"">
");
#nullable restore
#line 143 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                  
                    classText = "active";
                    for (var slide = 0; slide <= 3; slide++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 6351, "\"", 6383, 2);
            WriteAttributeValue("", 6359, "carousel-item", 6359, 13, true);
#nullable restore
#line 147 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6372, classText, 6373, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 149 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                 foreach (var movie in Model.TopeRated.results.Skip(slide * 4).Take(4))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-sm-3 mb-2\">\r\n                                        <div class=\"card\" style=\"width: 18rem;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 6769, "\"", 6793, 1);
#nullable restore
#line 153 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
WriteAttributeValue("", 6775, movie.poster_path, 6775, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                                            <div class=\"card-body\">\r\n                                                <h5 class=\"card-title clampTitle\">");
#nullable restore
#line 155 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                             Write(movie.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <p class=\"card-text clampOverview\">");
#nullable restore
#line 156 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                              Write(movie.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f22328eca7687a43709ddcdf3812e3606d13425536", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(movie.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 161 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 164 "D:\Code\MovieDB\MovieDB\Views\Home\Index.cshtml"
                        classText = "";
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LandingPageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
