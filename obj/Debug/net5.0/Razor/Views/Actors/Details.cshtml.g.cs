#pragma checksum "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7e9be73eeae2480fbd36e137fcdfe4412964a3"
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
#line 1 "C:\Users\ebruc\source\repos\MovieDB\Views\_ViewImports.cshtml"
using MovieDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ebruc\source\repos\MovieDB\Views\_ViewImports.cshtml"
using MovieDB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml"
using MovieDB.Models.TMDB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7e9be73eeae2480fbd36e137fcdfe4412964a3", @"/Views/Actors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20929693dcaafb44f6e41c194896a0c674026529", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActorDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row media\">\r\n<div class=\"col-sm-12 col-md-3\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 117, "\"", 142, 1);
#nullable restore
#line 6 "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml"
WriteAttributeValue("", 123, Model.profile_path, 123, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""h-100 w-100 mr-3"" alt=""..."" />
</div>
    <div class=""media-body col-sm-12 col-md-9"">
        <table class=""table table-hover"">
            <tbody>
                <tr>
                    <td>Name:</td>
                    <td>
                        ");
#nullable restore
#line 14 "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                    <tr>\r\n                    <td>Biography:</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 20 "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.biography);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                    <tr>\r\n                    <td>Birthday:</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                    <tr>\r\n                    <td>Place of Birth:</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\ebruc\source\repos\MovieDB\Views\Actors\Details.cshtml"
                   Write(Model.place_of_birth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
