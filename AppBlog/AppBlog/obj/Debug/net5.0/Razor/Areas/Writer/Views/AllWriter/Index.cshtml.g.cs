#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c83300b2024b23de268d1219ccadbfeaec51d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_AllWriter_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/AllWriter/Index.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c83300b2024b23de268d1219ccadbfeaec51d61", @"/Areas/Writer/Views/AllWriter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_AllWriter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header text-center"">
    
      <h1>  <small>Yazarlar</small>  </h1>
    
</div>
<div class=""container"">
<div class=""row"">
	<div class=""col-lg-12"">
		<div class=""main-box clearfix"">
			<div class=""table-responsive"">
				<table class=""table user-list"">
					<thead>
						<tr>
							<th><span>Yazar</span></th>
							<th><span>??yelik Tarihi</span></th>
							<th class=""text-center""><span>Durumu</span></th>
							<th><span>Email</span></th>
							<th>&nbsp;</th>
						</tr>
					</thead>
					<tbody>
");
#nullable restore
#line 29 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
                         foreach (var item in Model)
					   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t   <tr>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t<img src=\"https://bootdey.com/img/Content/avatar/avatar1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 821, "\"", 827, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 841, "\"", 882, 2);
            WriteAttributeValue("", 848, "/Writer/Other/Index/", 848, 20, true);
#nullable restore
#line 34 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
WriteAttributeValue("", 868, item.WriterID, 868, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"user-link\">");
#nullable restore
#line 34 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
                                                                                          Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 35 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
                                 if (item.RoleId==1)
							   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t   <span class=\"user-subhead\">Yazar</span>\n");
#nullable restore
#line 38 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
							   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t   \r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t2013/08/08\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td class=\"text-center\">\r\n");
#nullable restore
#line 45 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
                                 if(item.WriterStatus==true)
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<span class=\"label label-default bg-success\">Aktif</span>\r\n");
#nullable restore
#line 48 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
										}
										else
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<span class=\"label label-default bg-dark\">Aktif De??il</span>\r\n");
#nullable restore
#line 52 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
										}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t<a href=\"#\">");
#nullable restore
#line 55 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
                                       Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td style=\"width: 20%;\">\r\n\t\t\t\t\t\t\t\t<a href=\"#\" class=\"table-link btn btn-primary\">\r\n\t\t\t\t\t\t\t\t\tTakip Et\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1602, "\"", 1643, 2);
            WriteAttributeValue("", 1609, "/Writer/Other/Index/", 1609, 20, true);
#nullable restore
#line 61 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
WriteAttributeValue("", 1629, item.WriterID, 1629, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"table-link btn btn-warning\">\r\n\t\t\t\t\t\t\t\t\tProfil\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\n");
#nullable restore
#line 67 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Writer\Views\AllWriter\Index.cshtml"
					   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						
					</tbody>
				</table>
			</div>
			<ul class=""pagination pull-right"">
				<li><a href=""#""><i class=""fa fa-chevron-left""></i></a></li>
				<li><a href=""#"">1</a></li>
				<li><a href=""#"">2</a></li>
				<li><a href=""#"">3</a></li>
				<li><a href=""#"">4</a></li>
				<li><a href=""#"">5</a></li>
				<li><a href=""#""><i class=""fa fa-chevron-right""></i></a></li>
			</ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
