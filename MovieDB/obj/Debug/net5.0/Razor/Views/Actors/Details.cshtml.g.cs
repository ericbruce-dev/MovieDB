#pragma checksum "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5f1eed69dafd879dbf552d39bb47df3093c1ad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Details), @"mvc.1.0.view", @"/Views/Actors/Details.cshtml")]
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
#line 1 "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml"
using MovieDB.Models.TMDB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1eed69dafd879dbf552d39bb47df3093c1ad8", @"/Views/Actors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20929693dcaafb44f6e41c194896a0c674026529", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActorDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"media\">\r\n    <div class=\"row\">\r\n        <img class=\"h-100 w-100\"");
            BeginWriteAttribute("src", " src=\"", 126, "\"", 151, 1);
#nullable restore
#line 6 "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml"
WriteAttributeValue("", 132, Model.profile_path, 132, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""align-self-center mr-3"" alt=""..."" />
    </div>
    <div class=""media-body"">
        <table class=""table table-hover"">
            <tbody>
                <tr>
                    <td>Name:</td>
                    <td>
                        ");
#nullable restore
#line 14 "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                  <tr>\r\n                    <td>Biography:</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 20 "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.biography);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                  <tr>\r\n                    <td>Birthday:</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                  <tr>\r\n                    <td>Place of Birth:</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "D:\Code\MovieDB\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.place_of_birth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActorDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
