#pragma checksum "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0dc883524679256874c01c07826f6b4feea666a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\_ViewImports.cshtml"
using EduHomeBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\_ViewImports.cshtml"
using EduHomeBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0dc883524679256874c01c07826f6b4feea666a", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206aa45d050846d0bf60a4b116f91a8c3b396b14", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
  
    ViewData["Title"] = "About Index";
    AboutViewModel aboutViewModel = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"about-area pb-155\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-content\">\r\n                    <h2>");
#nullable restore
#line 16 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                   Write(Html.Raw(aboutViewModel.HomeAbout.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 17 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                  Write(Html.Raw(aboutViewModel.HomeAbout.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a class=\"default-btn\" href=\"about.html\">view courses</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0dc883524679256874c01c07826f6b4feea666a5208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 737, "~/img/about/", 737, 12, true);
#nullable restore
#line 23 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 749, aboutViewModel.HomeAbout.Image, 749, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n\r\n<!-- Teacher Start -->\r\n");
            WriteLiteral("<!-- Teacher End -->\r\n\r\n\r\n\r\n\r\n<!-- Testimonial Area Start -->\r\n<div class=\"testimonial-area pt-110 pb-105 text-center\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"testimonial-owl owl-theme owl-carousel\">\r\n");
#nullable restore
#line 56 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                 foreach (var item in aboutViewModel.Testimonial)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0dc883524679256874c01c07826f6b4feea666a7828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1980, "~/img/testimonial/", 1980, 18, true);
#nullable restore
#line 62 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1998, item.Image, 1998, 11, false);

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
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
#nullable restore
#line 65 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 66 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                                   Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h5>");
#nullable restore
#line 67 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                                   Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 72 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Testimonial Area End -->\r\n");
            WriteLiteral("<section class=\"notice-area two pt-140\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                <div class=\"notice-right-wrapper mb-25 pb-25\">\r\n                    <h3>");
#nullable restore
#line 84 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                   Write(aboutViewModel.HomeVideoTour.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"notice-video\">\r\n                        <div class=\"video-icon video-hover\">\r\n                            <a class=\"video-popup\"");
            BeginWriteAttribute("href", " href=\"", 3025, "\"", 3067, 1);
#nullable restore
#line 87 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
WriteAttributeValue("", 3032, aboutViewModel.HomeVideoTour.Video, 3032, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
#nullable restore
#line 98 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                         foreach (var item in aboutViewModel.HomeNoticeBoard)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
#nullable restore
#line 101 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 102 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 104 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\About\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            WriteLiteral(" ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
