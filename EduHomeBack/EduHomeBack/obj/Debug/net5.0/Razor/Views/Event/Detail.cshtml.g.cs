#pragma checksum "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05582d45101bfd9b42456261ab9c44c7dd9aefb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Detail), @"mvc.1.0.view", @"/Views/Event/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05582d45101bfd9b42456261ab9c44c7dd9aefb", @"/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206aa45d050846d0bf60a4b116f91a8c3b396b14", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px; height: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
Write(await Component.InvokeAsync("Banner", "EventDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Event Details Start -->
<div class=""event-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""event-details"">
                    <div class=""event-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a05582d45101bfd9b42456261ab9c44c7dd9aefb8062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 437, "~/img/event/", 437, 12, true);
#nullable restore
#line 15 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 449, Model.Event.Image, 449, 18, false);

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
            WriteLiteral("\r\n                        <div class=\"event-date\">\r\n                            <h3>");
#nullable restore
#line 17 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                           Write(Model.Event.TimeStart.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 17 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                                       Write(Model.Event.TimeStart.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"event-details-content\">\r\n                        <h2>");
#nullable restore
#line 21 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                       Write(Model.Event.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <ul>\r\n                            <li><span>time:</span> ");
#nullable restore
#line 23 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                              Write(Model.Event.TimeStart.ToString("h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                                                           Write(Model.Event.TimeEnd.ToString("h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><span>venue : </span>");
#nullable restore
#line 24 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                Write(Model.Event.VenuePlace);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                                        Write(Model.Event.VenueCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        ");
#nullable restore
#line 26 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                   Write(Html.Raw(Model.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <div class=\"speakers-area fix\">\r\n                            <h4>speakers</h4>\r\n");
#nullable restore
#line 30 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                             foreach (var speaker in Model.Event.EventSpeakers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-speaker\">\r\n                                    <div class=\"speaker-img\" style=\"height: 80px; width: 90px\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a05582d45101bfd9b42456261ab9c44c7dd9aefb13047", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1635, "~/img/event/", 1635, 12, true);
#nullable restore
#line 34 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 1647, speaker.Speaker.Image, 1647, 22, false);

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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"speaker-name\">\r\n                                        <h5>");
#nullable restore
#line 37 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                       Write(speaker.Speaker.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p>");
#nullable restore
#line 38 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                      Write(speaker.Speaker.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                                 Write(speaker.Speaker.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 41 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""reply-area"">
                        <h3>LEAVE A REPLY</h3>
                        <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05582d45101bfd9b42456261ab9c44c7dd9aefb16379", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>Name</p>
                                    <input type=""text"" name=""name"" id=""name"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Email</p>
                                    <input type=""text"" name=""email"" id=""email"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Subject</p>
                                    <input type=""text"" name=""subject"" id=""subject"">
                                    <p>Massage</p>
                                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                </div>
                            </div>
                            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message");
                WriteLiteral("</span></a>\r\n                            <p class=\"form-messege\"></p>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"blog-sidebar right\">\r\n");
            WriteLiteral(@"                    <div class=""single-blog-widget mb-50"">
                        <h3>categories</h3>
                        <ul>
                            <li><a href=""#"">CSS Engineering (10)</a></li>
                            <li><a href=""#"">Political Science (12)</a></li>
                            <li><a href=""#"">Micro Biology (08)</a></li>
                            <li><a href=""#"">HTML5 &amp; CSS3 (15)</a></li>
                            <li><a href=""#"">Web Design (20)</a></li>
                            <li><a href=""#"">PHP (23)</a></li>
                        </ul>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <div class=""single-blog-banner"">
                            <a href=""blog-details.html"" id=""blog"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a05582d45101bfd9b42456261ab9c44c7dd9aefb20212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            <h2>best<br> eductaion<br> theme</h2>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <h3>latest post</h3>\r\n");
#nullable restore
#line 103 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                         foreach (var item in Model.BlogList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-post mb-30\">\r\n                                <div class=\"single-post-img\">\r\n                                    <a href=\"blog-details.html\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a05582d45101bfd9b42456261ab9c44c7dd9aefb22105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5893, "~/img/blog/", 5893, 11, true);
#nullable restore
#line 108 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 5904, item.Image, 5904, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
                                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05582d45101bfd9b42456261ab9c44c7dd9aefb24140", async() => {
#nullable restore
#line 115 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                    <p>By ");
#nullable restore
#line 116 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                     Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 116 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                                                      Write(item.PublishDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 119 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Views\Event\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Event Details End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
