#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c06b239bcba6d96b67efa634e8fc731ff231d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Category_Views_List_Index), @"mvc.1.0.view", @"/Areas/Category/Views/List/Index.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\_ViewImports.cshtml"
using AppBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\_ViewImports.cshtml"
using AppBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c06b239bcba6d96b67efa634e8fc731ff231d5", @"/Areas/Category/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Category_Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<div class=""containexr"">
    <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""white-ox"">
                            <h3 class=""box-title"">KATEGORİLER</h3>
                            
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"">
                                    <thead>
                                        <tr>
                                            <th class=""border-top-0"">ID</th>
                                            <th class=""border-top-0"">Kategori Adı</th>
                                            <th class=""border-top-0"">Kategori Durumu</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
                                         foreach (var item in Model)
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <tr>\r\n                                            <td>");
#nullable restore
#line 28 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
                                           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 29 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 30 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
                                           Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            \r\n                                        </tr>\n");
#nullable restore
#line 33 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\List\Index.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
</div>


");
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