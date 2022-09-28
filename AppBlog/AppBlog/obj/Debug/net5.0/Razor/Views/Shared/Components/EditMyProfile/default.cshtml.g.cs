#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2c2c016ae6addc9f09c18c6f5cf1f80d0af909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EditMyProfile_default), @"mvc.1.0.view", @"/Views/Shared/Components/EditMyProfile/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d2c2c016ae6addc9f09c18c6f5cf1f80d0af909", @"/Views/Shared/Components/EditMyProfile/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_EditMyProfile_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Writer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"




<div class=""contasiner"">
<div class=""row gutters"">
<div class=""col-xl-3 col-lg-3 col-md-12 col-sm-12 col-12"">
<div class=""card h-100"">
	<div class=""card-body"">
		<div class=""account-settings"">
			<div class=""user-profile"">
				<div class=""user-avatar"">
					<img class=""w-50	"" src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Maxwell Admin"">
				</div>
				<h5 class=""user-name"">Yuki Hayashi</h5>
				<h6 class=""user-email"">yuki@Maxwell.com</h6>
			</div>
			<div class=""about"">
				<h5>About</h5>
				<p>I'm Yuki. Full Stack Designer I enjoy creating user-centric, delightful and human experiences.</p>
			</div>
		</div>
	</div>
</div>
</div>
<div class=""col-xl-9 col-lg-9 col-md-12 col-sm-12 col-12"">
<div class=""card h-100"">
	<div class=""card-body"">
		<div class=""row gutters"">
			<div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
				<h6 class=""mb-2 text-primary"">Personal Details</h6>
			</div>
");
#nullable restore
#line 36 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
             using (Html.BeginForm("Index", "Crud", new {area="Writer"}, FormMethod.Post))
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"row gutters\">\r\n\t\t\t\t<div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
#nullable restore
#line 41 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.HiddenFor(i=>i.WriterID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.HiddenFor(i=>i.WriterStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.HiddenFor(i=>i.WriterID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 44 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.Label("İsim"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 45 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.TextBoxFor(i=>i.WriterName, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
#nullable restore
#line 50 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.Label("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 51 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.TextBoxFor(i=>i.WriterMail, new{@class="form-control",type="email"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\t\t\r\n\r\n\r\n\t\t\t<div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
#nullable restore
#line 58 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.Label("Hakkında"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 59 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.TextBoxFor(i=>i.WriterAbout, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
#nullable restore
#line 65 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.Label("Şifre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 66 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.TextBoxFor(i=>i.WriterPassword, new{@class="form-control",type="password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t\r\n\t\t<div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t");
#nullable restore
#line 72 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.Label("Fotoğraf"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 73 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
               Write(Html.TextBoxFor(i=>i.WriterImage, new{@class="form-control",type="password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\r\n\t\t\r\n\t\t\r\n\t\t</div>\r\n");
            WriteLiteral("\t\t<button type=\"submit\" class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 82 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Shared\Components\EditMyProfile\default.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\r\n\t\t\t\r\n\t\t\t\r\n\t\t\t\r\n\t\t</div>\r\n\t\t\r\n\t\t</div>\r\n\t\t\r\n\t</div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591