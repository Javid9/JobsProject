#pragma checksum "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca1f4103ebc9bdaf8672ec31afc13c9ae8c8642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Jobs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Jobs/Index.cshtml")]
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
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using JobSearchEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca1f4103ebc9bdaf8672ec31afc13c9ae8c8642", @"/Areas/Admin/Views/Jobs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edfc0a79c4207cebf70fc9665030ce5ac4a058e3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Jobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FeaturedJobList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FeaturedJob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"jobList btn btn-success\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca1f4103ebc9bdaf8672ec31afc13c9ae8c86424182", async() => {
                WriteLiteral("Selected Jobs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n      \r\n   \r\n     <div class=\"jobs-all-container\">\r\n");
#nullable restore
#line 12 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"job-row\">\r\n                            <div class=\"company-logo-img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 422, "\"", 447, 2);
            WriteAttributeValue("", 428, "/images/", 428, 8, true);
#nullable restore
#line 16 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
WriteAttributeValue("", 436, item.Image, 436, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"img-fluid mx-auto d-block\">\r\n                            </div>\r\n                       \r\n                            <div class=\"job-descList\">\r\n                                <h5 class=\"mb-2\"><a href=\"#\" class=\"text-dark\">Title: ");
#nullable restore
#line 20 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                <p class=\"text-muted mb-0\">Category: <b>");
#nullable restore
#line 21 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </p>\r\n                                <p class=\"text-muted mb-0\"><i class=\"mdi mdi-bank mr-2\"></i>");
#nullable restore
#line 22 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                                       Write(item.City.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <ul class=\"list-inline mb-0\">\r\n                                    <li class=\"list-inline-item mr-3\">\r\n                                        <p class=\"text-muted mb-0\"><i class=\"mdi mdi-map-marker mr-2\"></i>");
#nullable restore
#line 25 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                                                     Write(item.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted mb-0\">Email: ");
#nullable restore
#line 26 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted mb-0\">Description: ");
#nullable restore
#line 27 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted mb-0\">Experience: ");
#nullable restore
#line 28 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                          Write(item.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted mb-0\">Minx Salary: ");
#nullable restore
#line 29 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                           Write(item.MinSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted mb-0\">Max Salary: ");
#nullable restore
#line 30 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                          Write(item.MaxSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted mb-0\">User Name: ");
#nullable restore
#line 31 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
                                                                         Write(item.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <p class=""text-muted mb-0""><i class=""mdi mdi-clock-outline mr-2""></i>8 days ago </p>
                                    </li>
                                </ul>
                            </div>

                            <div class=""jobs-button-row"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca1f4103ebc9bdaf8672ec31afc13c9ae8c864211235", async() => {
                WriteLiteral("Add Selected");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"
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
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\Jobs\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
