#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e33b1b46f38baa7068df496f97ef63ba2b214b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Category_Views_Blogs_Index), @"mvc.1.0.view", @"/Areas/Category/Views/Blogs/Index.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e33b1b46f38baa7068df496f97ef63ba2b214b4", @"/Areas/Category/Views/Blogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Category_Views_Blogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post-landscape-6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/blogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n<div class=\"row\">\r\n\r\n <div class=\"col-md-9\" data-aos=\"fade-up\">\r\n            \r\n");
#nullable restore
#line 14 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
             foreach (var item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <h3 class=\"category-title\">Kategori: ");
#nullable restore
#line 16 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
                                               Write(Model[0].Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <div class=\"d-md-flex post-entry-2 half\">\r\n              <a href=\"#\" class=\"me-4 thumbnail\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e33b1b46f38baa7068df496f97ef63ba2b214b45531", async() => {
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
            WriteLiteral("\r\n              </a>\r\n              <div>\r\n                <div class=\"post-meta\"><span class=\"date\">");
#nullable restore
#line 22 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">&bullet;</span> <span>");
#nullable restore
#line 22 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
                                                                                                                                 Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <h3><a href=\"single-post.html\">");
#nullable restore
#line 23 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
                                          Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>");
#nullable restore
#line 24 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
              Write(item.BlogContent.Substring(0,200));

#line default
#line hidden
#nullable disable
            WriteLiteral("... <a");
            BeginWriteAttribute("href", " href=\"", 922, "\"", 958, 2);
            WriteAttributeValue("", 929, "/Blog/Home/Index/", 929, 17, true);
#nullable restore
#line 24 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 946, item.BlogID, 946, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <b> Devamını Oku</b> </a></p>\r\n                <div class=\"d-flex align-items-center author\">\r\n                  <div class=\"photo\"><img src=\"assets/img/person-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1127, "\"", 1133, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></div>\r\n                  <div class=\"name\">\r\n                    <h3 class=\"m-0 p-0\">");
#nullable restore
#line 28 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
                                   Write(item.Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\n");
#nullable restore
#line 33 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Category\Views\Blogs\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           


            
          </div>

           <div class=""col-md-3"">
            <!-- ======= Sidebar ======= -->
            <div class=""aside-block"">

              <ul class=""nav nav-pills custom-tab-nav mb-4"" id=""pills-tab"" role=""tablist"">
                <li class=""nav-item"" role=""presentation"">
                  <button class=""nav-link active"" id=""pills-popular-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-popular"" type=""button"" role=""tab"" aria-controls=""pills-popular"" aria-selected=""true"">Popular</button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                  <button class=""nav-link"" id=""pills-trending-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-trending"" type=""button"" role=""tab"" aria-controls=""pills-trending"" aria-selected=""false"">Trending</button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                  <button class=""nav-link"" id=""pills-latest-tab"" data-bs-toggle=""pill"" data-bs-t");
            WriteLiteral(@"arget=""#pills-latest"" type=""button"" role=""tab"" aria-controls=""pills-latest"" aria-selected=""false"">Latest</button>
                </li>
              </ul>

              <div class=""tab-content"" id=""pills-tabContent"">

                <!-- Popular -->
                <div class=""tab-pane fade show active"" id=""pills-popular"" role=""tabpanel"" aria-labelledby=""pills-popular-tab"">
                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Sport</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">How to Avoid Distraction and Stay Focused During Video Calls?</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
    ");
            WriteLiteral(@"                <h2 class=""mb-2""><a href=""#"">17 Pictures of Medium Length Hair in Layers That Will Inspire Your New Haircut</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">9 Half-up/half-down Hairstyles for Long and Medium Hair</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">Life Insurance And Pregnancy: A Working Mom’s Guide</a></h2>
                    <span class=""author mb-3 d-b");
            WriteLiteral(@"lock"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Business</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">The Best Homemade Masks for Face (keep the Pimples Away)</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">10 Life-Changing Hacks Every Working Mom Should Know</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>
                </div> <!-- End Popular -->

                <!-- Trending -->
                <div class=""tab-pane fade"" i");
            WriteLiteral(@"d=""pills-trending"" role=""tabpanel"" aria-labelledby=""pills-trending-tab"">
                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">17 Pictures of Medium Length Hair in Layers That Will Inspire Your New Haircut</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">9 Half-up/half-down Hairstyles for Long and Medium Hair</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <");
            WriteLiteral(@"div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">Life Insurance And Pregnancy: A Working Mom’s Guide</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Sport</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">How to Avoid Distraction and Stay Focused During Video Calls?</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>
                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Business</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">The Bes");
            WriteLiteral(@"t Homemade Masks for Face (keep the Pimples Away)</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">10 Life-Changing Hacks Every Working Mom Should Know</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>
                </div> <!-- End Trending -->

                <!-- Latest -->
                <div class=""tab-pane fade"" id=""pills-latest"" role=""tabpanel"" aria-labelledby=""pills-latest-tab"">
                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a h");
            WriteLiteral(@"ref=""#"">Life Insurance And Pregnancy: A Working Mom’s Guide</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Business</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">The Best Homemade Masks for Face (keep the Pimples Away)</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">10 Life-Changing Hacks Every Working Mom Should Know</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

      ");
            WriteLiteral(@"            <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Sport</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">How to Avoid Distraction and Stay Focused During Video Calls?</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Lifestyle</span> <span class=""mx-1"">&bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">17 Pictures of Medium Length Hair in Layers That Will Inspire Your New Haircut</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                  <div class=""post-entry-1 border-bottom"">
                    <div class=""post-meta""><span class=""date"">Culture</span> <span class=""mx-1"">&");
            WriteLiteral(@"bullet;</span> <span>Jul 5th '22</span></div>
                    <h2 class=""mb-2""><a href=""#"">9 Half-up/half-down Hairstyles for Long and Medium Hair</a></h2>
                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                  </div>

                </div> <!-- End Latest -->

              </div>
            </div>

            <div class=""aside-block"">
              <h3 class=""aside-title"">Video</h3>
              <div class=""video-post"">
                <a href=""https://www.youtube.com/watch?v=AiFfDjmd0jU"" class=""glightbox link-video"">
                  <span class=""bi-play-fill""></span>
                  <img src=""assets/img/post-landscape-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11289, "\"", 11295, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                </a>
              </div>
            </div><!-- End Video -->

            <div class=""aside-block"">
              <h3 class=""aside-title"">Categories</h3>
              <ul class=""aside-links list-unstyled"">
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Business</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Culture</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Sport</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Food</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Politics</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Celebrity</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Startups</a></li>
                <li><a href=""category.html""><i class=""bi bi-chevron-right""></i> Trave");
            WriteLiteral(@"l</a></li>
              </ul>
            </div><!-- End Categories -->

            <div class=""aside-block"">
              <h3 class=""aside-title"">Tags</h3>
              <ul class=""aside-tags list-unstyled"">
                <li><a href=""category.html"">Business</a></li>
                <li><a href=""category.html"">Culture</a></li>
                <li><a href=""category.html"">Sport</a></li>
                <li><a href=""category.html"">Food</a></li>
                <li><a href=""category.html"">Politics</a></li>
                <li><a href=""category.html"">Celebrity</a></li>
                <li><a href=""category.html"">Startups</a></li>
                <li><a href=""category.html"">Travel</a></li>
              </ul>
            </div><!-- End Tags -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
