#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76324be72a68423df92c2bfa8873de12266ffdb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Kesfet_Views_Shared_Components_HaftaninBlogu_default), @"mvc.1.0.view", @"/Areas/Kesfet/Views/Shared/Components/HaftaninBlogu/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76324be72a68423df92c2bfa8873de12266ffdb8", @"/Areas/Kesfet/Views/Shared/Components/HaftaninBlogu/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Kesfet_Views_Shared_Components_HaftaninBlogu_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<section class=""category-section"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""section-header d-flex justify-content-between align-items-center mb-5"">
            <h2>Haftanın En Popüler Yazısı - <span class=""date text-muted"">");
#nullable restore
#line 10 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                      Write(Model[0].Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
            <div><a href=""category.html"" class=""more""></a></div>
        </div>

        <div class=""row"">
            <div class=""col-md-9"">
                x

                <div class=""d-lg-flex post-entry-2"">
                    <a href=""#"" class=""me-4 thumbnail mb-4 mb-lg-0 d-inline-block"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 676, "\"", 710, 1);
#nullable restore
#line 20 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 682, Model[0].BlogThumbnailImage, 682, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 711, "\"", 717, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                    </a>\r\n                    <div>\r\n                        <div class=\"post-meta\"><span class=\"date\">");
#nullable restore
#line 23 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                             Write(Model[0].Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">&bullet;</span> <span>");
#nullable restore
#line 23 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                                                                             Write(Model[0].BlogCreateDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        <h3><a href=\"single-post.html\">");
#nullable restore
#line 24 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                  Write(Model[0].BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>    <span class=\"post-meta\"> Beğeni : ");
#nullable restore
#line 24 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                                               Write(Model[0].Begeni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                        <p>");
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                      Write(Model[0].BlogContent.Substring(0,400));

#line default
#line hidden
#nullable disable
            WriteLiteral("... <a");
            BeginWriteAttribute("href", " href=\"", 1213, "\"", 1253, 2);
            WriteAttributeValue("", 1220, "/Blog/Home/Index/", 1220, 17, true);
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 1237, Model[0].BlogID, 1237, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b> Devamını Oku</b></a></p>\r\n                        <div class=\"d-flex align-items-center author\">\r\n                            <div class=\"photo\"><img src=\"assets/img/person-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1438, "\"", 1444, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></div>\r\n                            <div class=\"name\">\r\n                                <h3 class=\"m-0 p-0\">");
#nullable restore
#line 29 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                               Write(Model[0].Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                            </div>
                        </div>
                    </div>
                </div>



                <!--DİĞER YAZILARI-->

                <h1>Bazı Diğer Popüler Yazılar</h1>
                
                    




                        <div class=""row"">
                            <div class=""col-lg-4"">
                                <div class=""post-entry-1 border-bottom"">
                                    <a href=""single-post.html""><img src=""assets/img/post-landscape-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2150, "\"", 2156, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n                                    <div class=\"post-meta\"><span class=\"date\">");
#nullable restore
#line 51 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                         Write(Model[2].Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">&bullet;</span> <span>");
#nullable restore
#line 51 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                                                                                         Write(Model[2].BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                    <h2 class=\"mb-2\"><a");
            BeginWriteAttribute("href", " href=\"", 2454, "\"", 2494, 2);
            WriteAttributeValue("", 2461, "/Blog/Home/Index/", 2461, 17, true);
#nullable restore
#line 52 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 2478, Model[2].BlogID, 2478, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                            Write(Model[2].BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                    <span class=\"author mb-3 d-block\">");
#nullable restore
#line 53 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                 Write(Model[2].Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <p class=\"mb-4 d-block\">\r\n                                        ");
#nullable restore
#line 55 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                   Write(Model[2].BlogContent.Substring(0,200));

#line default
#line hidden
#nullable disable
            WriteLiteral("... <a");
            BeginWriteAttribute("href", " href=\"", 2778, "\"", 2818, 2);
            WriteAttributeValue("", 2785, "/Blog/Home/Index/", 2785, 17, true);
#nullable restore
#line 55 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 2802, Model[2].BlogID, 2802, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <b>Devamını Oku</b>
                                        </a>
                                    </p>
                                </div>

                                <div class=""post-entry-1"">
                                    <div class=""post-meta""><span class=""date"">");
#nullable restore
#line 62 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                         Write(Model[3].Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">&bullet;</span> <span>");
#nullable restore
#line 62 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                                                                                         Write(Model[3].BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                    <h2 class=\"mb-2\"><a");
            BeginWriteAttribute("href", " href=\"", 3349, "\"", 3389, 2);
            WriteAttributeValue("", 3356, "/Blog/Home/Index/", 3356, 17, true);
#nullable restore
#line 63 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 3373, Model[3].BlogID, 3373, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                            Write(Model[3].BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                    <span class=\"author mb-3 d-block\">");
#nullable restore
#line 64 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                 Write(Model[3].Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                            </div>
                            <div class=""col-lg-8"">
                                <div class=""post-entry-1"">
                                    <a href=""single-post.html""><img src=""assets/img/post-landscape-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3820, "\"", 3826, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n                                    <div class=\"post-meta\"><span class=\"date\">");
#nullable restore
#line 70 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                         Write(Model[1].Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">&bullet;</span> <span>");
#nullable restore
#line 70 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                                                                                         Write(Model[1].BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                    <h2 class=\"mb-2\"><a");
            BeginWriteAttribute("href", " href=\"", 4124, "\"", 4164, 2);
            WriteAttributeValue("", 4131, "/Blog/Home/Index/", 4131, 17, true);
#nullable restore
#line 71 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 4148, Model[1].BlogID, 4148, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                                                            Write(Model[1].BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                    <span class=\"author mb-3 d-block\">Jenny Wilson</span>\r\n                                    <p class=\"mb-4 d-block\">");
#nullable restore
#line 73 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
                                                       Write(Model[1].BlogContent.Substring(0,200));

#line default
#line hidden
#nullable disable
            WriteLiteral("...<a");
            BeginWriteAttribute("href", " href=\"", 4390, "\"", 4430, 2);
            WriteAttributeValue("", 4397, "/Blog/Home/Index/", 4397, 17, true);
#nullable restore
#line 73 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Kesfet\Views\Shared\Components\HaftaninBlogu\default.cshtml"
WriteAttributeValue("", 4414, Model[1].BlogID, 4414, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <b>Devamını Oku</b>    
                                    </a> </p>
                                </div>
                            </div>
                        </div>


                    
                



            </div>

            <div class=""col-md-3"">
                <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""single-post.html"">How to Avoid Distraction and Stay Focused During Video Calls?</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                </div>

                <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""single-pos");
            WriteLiteral(@"t.html"">17 Pictures of Medium Length Hair in Layers That Will Inspire Your New Haircut</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                </div>

                <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""single-post.html"">9 Half-up/half-down Hairstyles for Long and Medium Hair</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                </div>

                <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""single-post.html"">Life Insurance And Pregnancy: A Working Mom’s Guide</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilso");
            WriteLiteral(@"n</span>
                </div>

                <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""single-post.html"">The Best Homemade Masks for Face (keep the Pimples Away)</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                </div>

                <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""single-post.html"">10 Life-Changing Hacks Every Working Mom Should Know</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                </div>
            </div>
        </div>
    </div>
</section>");
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