#pragma checksum "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971e182f89b359cbcb737742eafc61e83683f8e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBlog/Default.cshtml")]
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
#line 1 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\_ViewImports.cshtml"
using EduHomeFrontToBack25062022.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\_ViewImports.cshtml"
using EduHomeFrontToBack25062022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971e182f89b359cbcb737742eafc61e83683f8e1", @"/Views/Shared/Components/SideBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b94b9e002193b50af18a14f38e29f0522064a44", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SideBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-post mb-30\">\r\n                                    <div class=\"single-post-img\">\r\n                                        <a  href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "971e182f89b359cbcb737742eafc61e83683f8e14482", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 258, "~/img/blog/", 258, 11, true);
#nullable restore
#line 7 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
AddHtmlAttributeValue("", 269, item.ImageUrl, 269, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <div class=""blog-hover"">
                                                <i class=""fa fa-link""></i>
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""single-post-content"">
                                        <h4><a href=""blog-details.html"">");
#nullable restore
#line 14 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        <p>By ");
#nullable restore
#line 15 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
                                         Write(item.Writer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  June ");
#nullable restore
#line 15 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
                                                                        Write(item.CreateTime.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
                                                                                              Write(item.CreateTime.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\n");
#nullable restore
#line 18 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\SideBlog\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
