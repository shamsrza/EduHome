#pragma checksum "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "668665aee166b4c3c031a3ad5759bc8b02004e79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668665aee166b4c3c031a3ad5759bc8b02004e79", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30e7a7401bf77be070341e40101d21903e51345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Index";
    HomeViewModel homeViewModel = Model;
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area two\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n        <!-- Start Slingle Slide -->\r\n");
#nullable restore
#line 12 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
         foreach(var item in homeViewModel.SliderImages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 399, "\"", 452, 4);
            WriteAttributeValue("", 407, "background-image:", 407, 17, true);
            WriteAttributeValue(" ", 424, "url(img/slider/", 425, 16, true);
#nullable restore
#line 14 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 440, item.Image, 440, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 451, ")", 451, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <!-- Start Slider Content -->
            <div class=""slider-content-area"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-10 col-md-offset-1"">
                            <div class=""slide-content-wrapper"">
                                <div class=""slide-content text-center"">
                                    <h2>");
#nullable restore
#line 22 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                   Write(homeViewModel.Slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                    <p>");
#nullable restore
#line 23 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                  Write(homeViewModel.Slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                    <a class=""default-btn"" href=""about.html"">Learn more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 32 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n\r\n\r\n<!-- Service Start -->\r\n<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 42 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
             foreach(var item in homeViewModel.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                <div class=\"single-service\">\r\n                    <h3><a href=\"teacher.html\">");
#nullable restore
#line 46 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    <p>");
#nullable restore
#line 47 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Service End -->


<!-- About Start -->
<div class=""about-area pb-155"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
                    <h2>");
#nullable restore
#line 64 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                   Write(Html.Raw(homeViewModel.HomeAbout.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 65 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                  Write(Html.Raw(homeViewModel.HomeAbout.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a class=\"default-btn\" href=\"about.html\">view courses</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7911349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2466, "~/img/about/", 2466, 12, true);
#nullable restore
#line 71 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2478, homeViewModel.HomeAbout.Image, 2478, 30, false);

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
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->

<!-- Courses Area Start -->
<div class=""courses-area two pt-150 pb-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7913294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>COURSES WE OFFER</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 91 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
             foreach(var item in homeViewModel.HomeCourseOffers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                <div class=\"single-course\">\r\n                    <div class=\"course-img\">\r\n                        <a href=\"course-details.html\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7915076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3383, "~/img/course/", 3383, 13, true);
#nullable restore
#line 97 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3396, item.Image, 3396, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
                    </div>
                    <div class=""course-content"">
                        <h3><a href=""course-details.html"">");
#nullable restore
#line 104 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        <p>");
#nullable restore
#line 105 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 110 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Courses Area End -->


<!-- Notice Start -->
<section class=""notice-area two pt-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>");
#nullable restore
#line 123 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.HomeVideoTour.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"notice-video\">\r\n                        <div class=\"video-icon video-hover\">\r\n                            <a class=\"video-popup\"");
            BeginWriteAttribute("href", " href=\"", 4522, "\"", 4563, 1);
#nullable restore
#line 126 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 4529, homeViewModel.HomeVideoTour.Video, 4529, 34, false);

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
#line 137 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                         foreach (var item in homeViewModel.HomeNoticeBoard)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
#nullable restore
#line 140 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 141 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n");
#nullable restore
#line 143 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->


<!-- Event Area Start -->
<div class=""event-area two text-center pt-100 pb-145"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7921103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>UPCOMMING EVENTS</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 165 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
             foreach (var item in homeViewModel.HomeEventArea)
            {
                if (count == 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
               Write(Html.Raw("<div class='col-md-6 col-sm-12 col-xs-12'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                                           ;
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
               Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                       ;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
               Write(Html.Raw("<div class='col-md-6 col-sm-12 col-xs-12'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                                           ;
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"single-event mb-35\">\r\n                    <div class=\"event-img\">\r\n                        <a href=\"event-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7924378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6456, "~/img/event/", 6456, 12, true);
#nullable restore
#line 179 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6468, item.Image, 6468, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"event-content text-left\">\r\n                        <h3>");
#nullable restore
#line 182 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h4><a href=\"event-details.html\">");
#nullable restore
#line 183 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                        <ul>\r\n                            <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 185 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                        Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 186 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                           Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 193 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 195 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
       Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Event Area End -->

<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
#nullable restore
#line 206 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                 foreach (var item in homeViewModel.Testimonial) 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7928997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7901, "~/img/testimonial/", 7901, 18, true);
#nullable restore
#line 212 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7919, item.Image, 7919, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("           \r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
#nullable restore
#line 215 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 216 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                   Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h5>");
#nullable restore
#line 217 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                   Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 222 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->


<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7932299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>LATEST FROM BLOG</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 242 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
             foreach (var item in homeViewModel.HomeBlogArea)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-img\">\r\n                            <a href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "668665aee166b4c3c031a3ad5759bc8b02004e7934057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9223, "~/img/blog/", 9223, 11, true);
#nullable restore
#line 247 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9234, item.Image, 9234, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                            <div class=""blog-hover"">
                                <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                            </div>
                        </div>
                        <div class=""blog-content"">
                            <div class=""blog-top"">
                                <p>");
#nullable restore
#line 254 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                              Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /  ");
#nullable restore
#line 254 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                              Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / <i class=\"fa fa-comments-o\"></i> ");
#nullable restore
#line 254 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                                                            Write(item.CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"blog-bottom\">\r\n                                <h2><a href=\"blog-details.html\">");
#nullable restore
#line 257 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n                                <a href=\"blog-details.html\">read more</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 263 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n");
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
