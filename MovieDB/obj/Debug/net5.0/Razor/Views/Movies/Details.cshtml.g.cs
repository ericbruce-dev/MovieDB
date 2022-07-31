#pragma checksum "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef9e25098b2e89960374a85a954a9a8b22778e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
using MovieDB.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
using MovieDB.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef9e25098b2e89960374a85a954a9a8b22778e7", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20929693dcaafb44f6e41c194896a0c674026529", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-sm-12 col-md-6\">\r\n        <div class=\"row\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 232, "\"", 296, 1);
#nullable restore
#line 10 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
WriteAttributeValue("", 238, _imageService.DecodeImage(Model.Poster, Model.PosterType), 238, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 297, "\"", 303, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100"" />
        </div>
        <div class=""row"">
            <button class=""btn btn-lg btn-block btn-danger font-weight-bold"" data-toggle=""modal"" data-target=""#trailer"">WATCH TRAILER</button>
        </div>
    </div>
    <div class=""col-sm-12 col-md-6"">
        <div class=""row"">
            <div class=""col h5"">
                <span class=""font-weight-bolder mr-2"">TITLE:</span> ");
#nullable restore
#line 19 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col h5\">\r\n                <span class=\"font-weight-bolder mr-2\">RELEASED:</span> ");
            WriteLiteral(" ");
#nullable restore
#line 26 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                                                                                                  Write(Model.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col h5\">\r\n                <span class=\"font-weight-bolder mr-2\">RATING:</span> ");
#nullable restore
#line 33 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                                                Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col h5\">\r\n                <span class=\"font-weight-bolder mr-2\">REVIEWS:</span> ");
#nullable restore
#line 40 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                                                 Write(Model.VoteAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / 10
            </div>
        </div>
        <hr />

        <div class=""row"">
            <div class=""col h5"">
                <span class=""font-weight-bolder mr-2"">OVERVIEW:</span>
            </div>
        </div>

        <div class=""row"">
            <div class=""col"">
                <span class=""h5 ml-4"">");
#nullable restore
#line 53 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                 Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 61 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
     foreach(var actor in Model.Cast.Take(5))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"card mb-3\">\r\n                <div class=\"row no-gutters\">\r\n                    <div class=\"col-md-2\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2086, "\"", 2107, 1);
#nullable restore
#line 68 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2092, actor.ImageUrl, 2092, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" class=\"img-fluid\" style=\"width: 10rem\"/>\r\n                    </div>\r\n                    <div class=\"col-md-10\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">Name: ");
#nullable restore
#line 72 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                                    Write(actor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">Character: ");
#nullable restore
#line 73 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
                                                       Write(actor.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n         </div>\r\n      </div>\r\n");
#nullable restore
#line 80 "D:\Code\MovieDB\MovieDB\Views\Movies\Details.cshtml"
            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IImageService _imageService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
