#pragma checksum "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f90bdea66eab9b516d705958259de67edb0024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Course_Delete), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Course/Delete.cshtml")]
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
#line 1 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\_ViewImports.cshtml"
using EduHomeBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\_ViewImports.cshtml"
using EduHomeBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f90bdea66eab9b516d705958259de67edb0024", @"/Areas/AdminPanel/Views/Course/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a091d7e2c89af78b3bdf95cc7fa8119a09a3f7", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Course_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Course Details</h4>\r\n                <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90f90bdea66eab9b516d705958259de67edb00245468", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 293, "~/img/course/", 293, 13, true);
#nullable restore
#line 12 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
AddHtmlAttributeValue("", 306, Model.Image, 306, 12, false);

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
            WriteLiteral("</div>\r\n                <div style=\" margin-top: 60px\">\r\n                    <h2 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p style=\"margin-bottom: 50px\">");
#nullable restore
#line 15 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                              Write(Model.Couse.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div style="" margin-top: 60px"">
                    <h4 class=""card-title"" style=""text-transform: uppercase"">course features</h4>
                    <ul class=""list-star"">
                        <li style=""text-transform: uppercase""><span style=""font-weight: bold"">STARTS: </span> ");
#nullable restore
#line 20 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                         Write(Model.Couse.Starts.ToString("dd MMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li style=\"text-transform: uppercase\"><span style=\"font-weight: bold\">DURATION:  </span> ");
#nullable restore
#line 21 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                            Write(Model.Couse.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li style=\"text-transform: uppercase\"><span style=\"font-weight: bold\">CLASS DURATION: </span> ");
#nullable restore
#line 22 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                                 Write(Model.Couse.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li style=\"text-transform: uppercase\"><span style=\"font-weight: bold\">SKILL LEVEL: </span> ");
#nullable restore
#line 23 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                              Write(Model.Couse.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li style=\"text-transform: uppercase\"><span style=\"font-weight: bold\">STUDENTS: </span> ");
#nullable restore
#line 24 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                           Write(Model.Couse.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li style=\"text-transform: uppercase\"><span style=\"font-weight: bold\">ASSESMENTS: </span> ");
#nullable restore
#line 25 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                             Write(Model.Couse.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li style=\"text-transform: uppercase\"><span style=\"font-weight: bold\">COURSE FEE: </span> ");
#nullable restore
#line 26 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                                                                                             Write(Model.Couse.CourseFee);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>

        </div>
    </div>
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"" style=""text-transform: uppercase"">about course</h4>
                <p style=""margin-bottom: 50px"">");
#nullable restore
#line 37 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                          Write(Model.Couse.AboutCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h4 class=\"card-title\" style=\"text-transform: uppercase\">how to apply</h4>\r\n                <p style=\"margin-bottom: 50px\">");
#nullable restore
#line 40 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                          Write(Model.Couse.HowToApply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h4 class=\"card-title\" style=\"text-transform: uppercase\">certification</h4>\r\n                <p>");
#nullable restore
#line 43 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
              Write(Html.Raw(Model.Couse.Certification));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h4 class=\"card-title\" style=\"text-transform: uppercase; margin-top: 50px\">Category</h4>\r\n                <p style=\"margin-bottom: 50px\">");
#nullable restore
#line 46 "C:\Users\srzayeva\Desktop\ASP.NET\EduHomeBack\EduHomeBack\Areas\AdminPanel\Views\Course\Delete.cshtml"
                                          Write(Model.Couse.CourseList.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div style=\"margin-right: 20px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90f90bdea66eab9b516d705958259de67edb002413530", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n     </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90f90bdea66eab9b516d705958259de67edb002414789", async() => {
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseList> Html { get; private set; }
    }
}
#pragma warning restore 1591