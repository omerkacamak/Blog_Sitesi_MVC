#pragma checksum "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Message\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c06208a2625c26fbec41c80afca2d7d46118d91e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Message_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Message/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Message\Views\Home\Index.cshtml"
using Datam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06208a2625c26fbec41c80afca2d7d46118d91e", @"/Areas/Message/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9206f725d37e516a065428b6eb8b0391948773f", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Message_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Mesaj>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Message\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
<div class=""row clearfix"">
    <div class=""col-lg-12"">
        <div class=""card chat-app"">
            <div id=""plist"" class=""people-list"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text""><i class=""fa fa-search""></i></span>
                    </div>
                    <input type=""text"" class=""form-control"" placeholder=""Search..."">
                </div>
");
#nullable restore
#line 21 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Message\Views\Home\Index.cshtml"
               foreach (var item in Model)
{
   
    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Message\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MesajKisileri",new{id=@item.MesajID}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\omerk\source\repos\AppBlog\AppBlog\Areas\Message\Views\Home\Index.cshtml"
                                                                       
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""chat"">
                <div class=""chat-header clearfix"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <a href=""javascript:void(0);"" data-toggle=""modal"" data-target=""#view_info"">
                                <img src=""https://bootdey.com/img/Content/avatar/avatar2.png"" alt=""avatar"">
                            </a>
                            <div class=""chat-about"">
                                <h6 class=""m-b-0"">Aiden Chavez</h6>
                                <small>Last seen: 2 hours ago</small>
                            </div>
                        </div>
                        <div class=""col-lg-6 hidden-sm text-right"">
                            <a href=""javascript:void(0);"" class=""btn btn-outline-secondary""><i class=""fa fa-camera""></i></a>
                            <a href=""javascript:void(0);"" class=""btn btn-outline-primary""><i class=""fa fa-image""></i></a>
     ");
            WriteLiteral(@"                       <a href=""javascript:void(0);"" class=""btn btn-outline-info""><i class=""fa fa-cogs""></i></a>
                            <a href=""javascript:void(0);"" class=""btn btn-outline-warning""><i class=""fa fa-question""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""chat-history"">
                    <ul class=""m-b-0"">
                        <li class=""clearfix"">
                            <div class=""message-data text-right"">
                                <span class=""message-data-time"">10:10 AM, Today</span>
                                <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""avatar"">
                            </div>
                            <div class=""message other-message float-right""> Hi Aiden, how are you? How is the project coming along? </div>
                        </li>
                        <li class=""clearfix"">
                            <div class=""message-dat");
            WriteLiteral(@"a"">
                                <span class=""message-data-time"">10:12 AM, Today</span>
                            </div>
                            <div class=""message my-message"">Are we meeting today?</div>                                    
                        </li>                               
                        <li class=""clearfix"">
                            <div class=""message-data"">
                                <span class=""message-data-time"">10:15 AM, Today</span>
                            </div>
                            <div class=""message my-message"">Project has been already finished and I have results to show you.</div>
                        </li>
                    </ul>
                </div>
                <div class=""chat-message clearfix"">
                    <div class=""input-group mb-0"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""><i class=""fa fa-send""></i></span>
        ");
            WriteLiteral(@"                </div>
                        <input type=""text"" class=""form-control"" placeholder=""Enter text here..."">                                    
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Mesaj>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
