#pragma checksum "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52694df9b3942f2c6b1ab7c1bb26e5a769f252f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_Detail), @"mvc.1.0.view", @"/Views/Candidate/Detail.cshtml")]
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
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52694df9b3942f2c6b1ab7c1bb26e5a769f252f", @"/Views/Candidate/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d8be59ac70f473ae4690afee60c7338b38433f", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Apply>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid d-block mx-auto rounded-circle img-thumbnail mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/featured-job/img-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""candidates-profile-bg"">
    <div class=""bg-overlay""></div>
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-6"">
                <div class=""candidates-profile-details text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b52694df9b3942f2c6b1ab7c1bb26e5a769f252f5894", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 354, "~/images/apply/", 354, 15, true);
#nullable restore
#line 14 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
AddHtmlAttributeValue("", 369, Model.Image, 369, 12, false);

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
            WriteLiteral("\r\n                    <h4 class=\"text-white candidates-profile-name mb-2\">");
#nullable restore
#line 15 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                   Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"text-white-50 mb-2\"><i class=\"mdi mdi-bank mr-2\"></i>");
#nullable restore
#line 16 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                              Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul class=\"candidates-profile-icons list-inline mb-3\">\r\n                        <li class=\"list-inline-item text-white-50 pr-2 f-16\">");
#nullable restore
#line 18 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                        Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        <li class=""list-inline-item""><a href=""#"" class=""text-warning""><i class=""mdi mdi-star""></i></a></li>
                        <li class=""list-inline-item""><a href=""#"" class=""text-warning""><i class=""mdi mdi-star""></i></a></li>
                        <li class=""list-inline-item""><a href=""#"" class=""text-warning""><i class=""mdi mdi-star""></i></a></li>
                        <li class=""list-inline-item""><a href=""#"" class=""text-warning""><i class=""mdi mdi-star""></i></a></li>
                        <li class=""list-inline-item""><a href=""#"" class=""text-warning""><i class=""mdi mdi-star""></i></a></li>
                    </ul>

                    <ul class=""candidates-profile-social-icons list-inline mb-0"">
                        <li class=""list-inline-item""><a");
            BeginWriteAttribute("href", " href=\"", 1635, "\"", 1657, 1);
#nullable restore
#line 27 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
WriteAttributeValue("", 1642, Model.Facebook, 1642, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1658, "\"", 1666, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-facebook\"></i></a></li>\r\n                        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1766, "\"", 1787, 1);
#nullable restore
#line 28 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
WriteAttributeValue("", 1773, Model.Twitter, 1773, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1788, "\"", 1796, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-twitter\"></i></a></li>\r\n                        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1895, "\"", 1918, 1);
#nullable restore
#line 29 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
WriteAttributeValue("", 1902, Model.Instagram, 1902, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1919, "\"", 1927, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-instagram\"></i></a></li>\r\n                        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 2028, "\"", 2048, 1);
#nullable restore
#line 30 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
WriteAttributeValue("", 2035, Model.Google, 2035, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2049, "\"", 2057, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""mdi mdi-google-plus""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- end home -->



<!-- CANDIDATES PROFILE START -->
<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h3 class=""text-dark"">About</h3>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""job-detail mt-2 p-4"">
                    <div class=""job-detail-desc"">
                        <p class=""text-muted f-14 mb-3"">");
#nullable restore
#line 54 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                   Write(Model.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <hr>
                    <ul class=""list-inline mt-3 mb-0"">
                        <li class=""list-inline-item mr-3"">
                            <a href=""#"" class=""text-muted f-15 mb-0""><i class=""mdi mdi-map-marker mr-2""></i>");
#nullable restore
#line 59 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n\r\n                        <li class=\"list-inline-item mr-3\">\r\n                            <a href=\"#\" class=\"text-muted f-15 mb-0\"><i class=\"mdi mdi-web mr-2\"></i>");
#nullable restore
#line 63 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                                Write(Model.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n\r\n                        <li class=\"list-inline-item mr-3\">\r\n                            <a href=\"#\" class=\"text-muted f-15 mb-0\"><i class=\"mdi mdi-email mr-2\"></i>");
#nullable restore
#line 67 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n\r\n                        <li class=\"list-inline-item mr-3\">\r\n                            <a href=\"#\" class=\"text-muted f-15 mb-0\"><i class=\"mdi mdi-cellphone-iphone mr-2\"></i>");
#nullable restore
#line 71 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

        

     

        <div class=""row"">
            <div class=""col-lg-12"">
                <h3 class=""text-dark mt-4 mb-4"">Education</h3>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""job-detail candidates-profile-education text-center text-muted mb-5 mt-5"">
                    <div class=""profile-education-icon"">
                        <i class=""mdi mdi-school""></i>
                    </div>
                    <h6 class=""text-uppercase f-17""><a href=""#"" class=""text-muted"">");
#nullable restore
#line 94 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                              Write(Model.UniversityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                    <p class=\"f-14 mb-1\">");
#nullable restore
#line 95 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                    Write(Model.StartUniversity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 95 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                             Write(Model.GraduationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"f-14 mb-0\">");
#nullable restore
#line 96 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                    Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <hr class=""mt-2 mb-2"">
                    <p class=""f-14 mb-0"">Suspendisse faucibus et pellentesque egestas lacus ante convallis.</p>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-12"">
                <h3 class=""text-dark mb-4"">Experience</h3>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""job-detail job-list-box mt-4 p-4"">
                    <div class=""row justify-content-around"">
                        <div class=""col-lg-3"">
                            <div class=""company-brand-logo text-center mb-4"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b52694df9b3942f2c6b1ab7c1bb26e5a769f252f18119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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

                        <div class=""col-lg-7"">
                            <div class=""job-list-desc candidates-profile-exp-desc"">
                                <h5 class=""f-19 mb-2""><a href=""#"" class=""text-dark"">");
#nullable restore
#line 121 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                               Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                <p class=\"text-muted mb-0 f-16\">");
#nullable restore
#line 122 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                           Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"text-muted mb-0 f-16\">");
#nullable restore
#line 123 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                           Write(Model.StartCompanyDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 123 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                     Write(Model.EndCompanyDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"text-muted mb-0 f-16\">Salary : ");
#nullable restore
#line 124 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                    Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n                                <p class=\"text-muted mb-0 f-16\"><i class=\"mdi mdi-bank mr-2\"></i>");
#nullable restore
#line 125 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                            Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"text-muted mb-0 f-16\"><i class=\"mdi mdi-map-marker mr-2\"></i>");
#nullable restore
#line 126 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Candidate\Detail.cshtml"
                                                                                                  Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- CANDIDATES PROFILE END -->\r\n\r\n\r\n<!-- subscribe start -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b52694df9b3942f2c6b1ab7c1bb26e5a769f252f22652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- subscribe end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Apply> Html { get; private set; }
    }
}
#pragma warning restore 1591