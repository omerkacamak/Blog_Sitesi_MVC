#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0013f614afc98af56d7b608df3889667e68d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Register), @"mvc.1.0.view", @"/Views/Login/Register.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0013f614afc98af56d7b608df3889667e68d30", @"/Views/Login/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Writer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
 using (Html.BeginForm("Register","Login",FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section");
            BeginWriteAttribute("class", " class=\"", 122, "\"", 130, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color: #508bfc;"">
  <div class=""container py-5 "">
    <div class=""row d-flex justify-content-center align-items-center "">
      <div class=""col-12 col-md-8 col-lg-6 col-xl-5"">
        <div class=""card shadow-2-strong"" style=""border-radius: 1rem;"">
          <div class=""card-body p-5 text-center"">

            <h3 class=""mb-5"">Kayıt Ol</h3>

            <div class=""form-outline mb-4"">
             
              ");
#nullable restore
#line 21 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.TextBoxFor(i=>i.WriterName, new{@class="form-control form-control-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              ");
#nullable restore
#line 22 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.ValidationMessageFor(i=>i.WriterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             ");
#nullable restore
#line 23 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
        Write(Html.Label("İsim"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-outline mb-4\">\r\n              ");
#nullable restore
#line 27 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.TextBoxFor(i=>i.WriterLastName, new{@class="form-control form-control-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               ");
#nullable restore
#line 28 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
          Write(Html.ValidationMessageFor(i=>i.WriterLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <label class=\"form-label\" for=\"typePasswordX-2\">Soyisim</label>\r\n            </div>\r\n             <div class=\"form-outline mb-4\">\r\n              ");
#nullable restore
#line 32 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.TextBoxFor(i=>i.WriterMail, new{@class="form-control form-control-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               ");
#nullable restore
#line 33 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
          Write(Html.ValidationMessageFor(i=>i.WriterMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <label class=\"form-label\" for=\"typePasswordX-2\">Email</label>\r\n            </div>\r\n\r\n             <div class=\"form-outline mb-4\">\r\n              ");
#nullable restore
#line 38 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.TextBoxFor(i=>i.NickName, new{@class="form-control form-control-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               ");
#nullable restore
#line 39 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
          Write(Html.ValidationMessageFor(i=>i.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <label class=\"form-label\" for=\"typePasswordX-2\">Kullanıcı Adı</label>\r\n            </div>\r\n\r\n             <div class=\"form-outline mb-4\">\r\n              ");
#nullable restore
#line 44 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.TextBoxFor(i=>i.WriterPassword, new{@class="form-control form-control-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               ");
#nullable restore
#line 45 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
          Write(Html.ValidationMessageFor(i=>i.WriterPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <label class=\"form-label\" for=\"typePasswordX-2\">Şifre</label>\r\n            </div>\r\n\r\n             <div class=\"form-outline mb-4\">\r\n              ");
#nullable restore
#line 50 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
         Write(Html.TextBoxFor(i=>i.WriterAbout, new{@class="form-control form-control-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               ");
#nullable restore
#line 51 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"
          Write(Html.ValidationMessageFor(i=>i.WriterAbout));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
              <label class=""form-label"" for=""typePasswordX-2"">Hakknıda</label>
            </div>

            <!-- Checkbox -->
            <div class=""form-check d-flex justify-content-start mb-4"">
              <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2448, "\"", 2456, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""form1Example3"" />
              <label class=""form-check-label"" for=""form1Example3""> Remember password </label>
            </div>

         

            <hr class=""my-4"">

            <button class=""btn btn-lg btn-block btn-primary"" style=""background-color: #dd4b39;""
              type=""submit""><i class=""fab fa-google me-2""></i> Kayıt Ol</button>
              
            <a href=""/Login/Index"" class=""btn btn-lg btn-block btn-primary text-white"" style=""background-color:blue;""
              type=""button""><i class=""fab fa-google me-2""></i>Ana Sayfa</a>
            

            
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
");
#nullable restore
#line 79 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Views\Login\Register.cshtml"

}

#line default
#line hidden
#nullable disable
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
