#pragma checksum "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2088acfe7a4d4d8e2493c91341ef561092cfe5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recomendations_Add), @"mvc.1.0.view", @"/Views/Recomendations/Add.cshtml")]
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
#line 1 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\_ViewImports.cshtml"
using ColmSheehan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\_ViewImports.cshtml"
using ColmSheehan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2088acfe7a4d4d8e2493c91341ef561092cfe5d6", @"/Views/Recomendations/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a1daacfc84e49c5fad12594767f92066d32b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Recomendations_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recommendation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
  
    ViewData["Title"] = "Add Review";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- ======= Hero Section ======= -->\r\n    <section");
            BeginWriteAttribute("id", " id=\"", 122, "\"", 127, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1>\r\n            Page for adding reviews\r\n        </h1>\r\n        \r\n");
#nullable restore
#line 12 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
             using (var form = Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.LabelFor(m => m.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.TextBoxFor(m => m.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.ValidationMessageFor(m => m.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.LabelFor(m => m.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.TextBoxFor(m => m.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.ValidationMessageFor(m => m.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 33 "C:\Users\Colm Sheehan\source\repos\ColmSheehan\Views\Recomendations\Add.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n       \r\n\r\n\r\n    </section><!-- End Hero -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recommendation> Html { get; private set; }
    }
}
#pragma warning restore 1591
