#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2154a228182e9e076a9321b1a2385a5b1ab50f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\_ViewImports.cshtml"
using AppBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\_ViewImports.cshtml"
using AppBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2154a228182e9e076a9321b1a2385a5b1ab50f", @"/Views/Shared/Components/TopMenu/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TopMenu_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<nav id=\"navbar\" class=\"navbar\">\r\n    <ul>\r\n        <li><a href=\"/HomePage\">Ana Sayfa</a></li>\r\n");
#nullable restore
#line 8 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a href=\"/Writer/Home/Index\">Profilim</a></li>\r\n            <li><a href=\"/Blog/Add/Index\">Yeni Yaz?? </a></li>\r\n");
#nullable restore
#line 12 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        <li class=\"dropdown\">\r\n            <a href=\"#\"><span>Kategoriler</span> <i class=\"bi bi-chevron-down dropdown-indicator\"></i></a>\r\n            <ul>\r\n");
#nullable restore
#line 33 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1302, 2);
            WriteAttributeValue("", 1257, "/Category/Blogs/Index?isim=", 1257, 27, true);
#nullable restore
#line 35 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
WriteAttributeValue("", 1284, item.CategoryName, 1284, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
                                                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 36 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </li>\r\n\r\n        <li><a href=\"/kesfet\">Ke??fet</a></li>\r\n");
#nullable restore
#line 42 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
         using (Html.BeginForm("ara","Home",new{area="Search"},FormMethod.Get))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""input-group mx-5"">
            
              <input name=""ara"" type=""search"" class=""form-control rounded bg-grey"" placeholder=""Search"" aria-label=""Search"" aria-describedby=""search-addon"" />

            <button type=""submit"" id=""klik""  class=""btn""><span class=""bi-search""></span></button>
            
            
        </li>
");
#nullable restore
#line 52 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\TopMenu\default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'#klik\').click(function() {\r\n            console.log(\"ARA ARA\")\r\n        })\r\n    </script>\r\n                    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
