#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd5b8c433a210371d84ba6a22e89565115f7ff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HomePage_Views_Home_Index), @"mvc.1.0.view", @"/Areas/HomePage/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd5b8c433a210371d84ba6a22e89565115f7ff3", @"/Areas/HomePage/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_HomePage_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/person-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
  
    // ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/blogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("AnaSlideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<section id=\"posts\" class=\"posts\">\r\n    <div class=\"container\" data-aos=\"fade-up\">\r\n        <div class=\"row g-5\">\r\n\r\n            <!--SON BLOGU GETİR SOL TARAF-->\r\n            <div class=\"col-lg-4\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                 foreach (var item3 in Model.Take(3))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"post-entry-1 lg\">\r\n                        <a href=\"single-post.html\"><img");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 603, 1);
#nullable restore
#line 24 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
WriteAttributeValue("", 578, item3.BlogThumbnailImage, 578, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 604, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n                        <div class=\"post-meta\"><span class=\"date\">");
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                                             Write(item3.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">&bullet;</span> <span>");
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                                                                                                                          Write(item3.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        <h2><a href=\"single-post.html\">");
#nullable restore
#line 26 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                                  Write(item3.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                        <p class=\"mb-4 d-block\">");
#nullable restore
#line 27 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                           Write(item3.BlogContent.Substring(0,400));

#line default
#line hidden
#nullable disable
            WriteLiteral("... <a href=\"#\">Devamını Oku</a></p>\r\n\r\n                        <div class=\"d-flex align-items-center author\">\r\n                            <div class=\"photo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5bd5b8c433a210371d84ba6a22e89565115f7ff37686", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                            <div class=\"name\">\r\n                                <h3 class=\"m-0 p-0\">");
#nullable restore
#line 32 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                               Write(item3.Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 36 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n            <!--END SON BLOGU GETİR SOL TARAF-->\r\n            \r\n            \r\n            <!--Sağ taraftaki küçük SON blolgar-->\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"row g-5\">\r\n");
#nullable restore
#line 48 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                     foreach (var item2 in Model.Take(11))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                         if(item2 == Model[0] || item2 == Model[1] || item2 == Model[2] )
                        {
                            continue;
                        }




                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-6 border-start custom-border\">\r\n\r\n                            <div class=\"post-entry-1\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2191, "\"", 2228, 2);
            WriteAttributeValue("", 2198, "/Blog/Home/Index/", 2198, 17, true);
#nullable restore
#line 63 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
WriteAttributeValue("", 2215, item2.BlogID, 2215, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img src=\"assets/img/post-landscape-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2272, "\"", 2278, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n\r\n                            </div>\r\n                            <h2 class=\"text-center\"><a");
            BeginWriteAttribute("href", " href=\"", 2396, "\"", 2433, 2);
            WriteAttributeValue("", 2403, "/Blog/Home/Index/", 2403, 17, true);
#nullable restore
#line 66 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
WriteAttributeValue("", 2420, item2.BlogID, 2420, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                                                                        Write(item2.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <p class=\"mb-4 d-block text-center\">\r\n                                ");
#nullable restore
#line 68 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                           Write(item2.BlogContent.Substring(0,40));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                <a");
            BeginWriteAttribute("class", " class=\"", 2633, "\"", 2641, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2642, "\"", 2679, 2);
            WriteAttributeValue("", 2649, "/Blog/Home/Index/", 2649, 17, true);
#nullable restore
#line 69 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
WriteAttributeValue("", 2666, item2.BlogID, 2666, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <b> Devamını Oku</b></a>\r\n                            </p>\r\n                            <div class=\"post-meta text-center\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2841, "\"", 2883, 2);
            WriteAttributeValue("", 2848, "/Writer/Other/Index/", 2848, 20, true);
#nullable restore
#line 72 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
WriteAttributeValue("", 2868, item2.WriterID, 2868, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"date\">");
#nullable restore
#line 72 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                                                                      Write(item2.Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> <span class=\"mx-1\">&bullet;</span>\r\n                                <span class=\"date\">");
#nullable restore
#line 73 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                              Write(item2.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <br>\r\n                                <span>");
#nullable restore
#line 75 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                                 Write(item2.BlogCreateDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            </div>\r\n\r\n\r\n                            <hr>\r\n\r\n\r\n\r\n\r\n                        </div>\r\n");
#nullable restore
#line 86 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
                         


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <!-- End Sağ taraftaki küçük SON blolgar-->\r\n            \r\n            \r\n            \r\n            <!--HAVA VE HABERLER-->\r\n            ");
#nullable restore
#line 100 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("CallWeatherNews"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <!--HAVA VE HABERLER-->\r\n\r\n\r\n\r\n\r\n        </div> \r\n    </div>\r\n</section> \r\n\r\n");
#nullable restore
#line 110 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\HomePage\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("IlginiziCekebilir"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<!-- Diğer -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591