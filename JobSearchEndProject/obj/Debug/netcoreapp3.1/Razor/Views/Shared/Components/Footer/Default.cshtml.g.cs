#pragma checksum "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8635330f430f12001da454a0fb0a2aaf9ec5473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8635330f430f12001da454a0fb0a2aaf9ec5473", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d8be59ac70f473ae4690afee60c7338b38433f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Shared\Components\Footer\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- footer start -->
<footer class=""footer pt-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""text-dark"">
                    <h3 class=""mb-4 footer-list-title text-white f-17"">Joobsy</h3>
                    <p class=""footer-desc"">At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium</p>
                    <ul class=""footer-icons list-inline mb-4"">
                        <li class=""list-inline-item""><a");
            BeginWriteAttribute("href", " href=\"", 580, "\"", 602, 1);
#nullable restore
#line 15 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 587, Model.Facebook, 587, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 603, "\"", 611, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-facebook\"></i></a></li>\r\n                        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 711, "\"", 732, 1);
#nullable restore
#line 16 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 718, Model.Twitter, 718, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 733, "\"", 741, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-twitter\"></i></a></li>\r\n                        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 840, "\"", 863, 1);
#nullable restore
#line 17 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 847, Model.Instagram, 847, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 864, "\"", 872, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-instagram\"></i></a></li>\r\n                        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 993, 1);
#nullable restore
#line 18 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 980, Model.Google, 980, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 994, "\"", 1002, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""mdi mdi-google""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""row"">
                    <div class=""col-lg-3"">
                        <div>
                            <p class=""text-white mb-4 footer-list-title f-17"">Company</p>
                            <ul class=""list-unstyled footer-list-menu"">
                                <li><a href=""#"">About Us</a></li>
                                <li><a href=""#"">Media & Press</a></li>
                                <li><a href=""#"">Career</a></li>
                                <li><a href=""#"">Blog</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div>
                            <p class=""text-white mb-4 footer-list-title f-17"">Resources</p>
                            <ul class=""list-unstyled footer-list-menu"">");
            WriteLiteral(@"
                                <li><a href=""#"">Help & Support</a></li>
                                <li><a href=""#"">Privacy Policy</a></li>
                                <li><a href=""#"">Terms & Conditions</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div>
                            <p class=""text-white mb-4 footer-list-title f-17"">More Info</p>
                            <ul class=""list-unstyled footer-list-menu"">
                                <li><a href=""#"">Pricing</a></li>
                                <li><a href=""#"">For Marketing</a></li>
                                <li><a href=""#"">For CEOs </a></li>
                                <li><a href=""#"">For Agencies</a></li>
                                <li><a href=""#"">Our Apps</a></li>
                            </ul>
                        </div>
                    </div>
                    <div");
            WriteLiteral(@" class=""col-lg-3"">
                        <div>
                            <p class=""text-white mb-4 footer-list-title f-17"">Help center</p>
                            <ul class=""list-unstyled footer-list-menu"">
                                <li><a href=""#"">Accounting </a></li>
                                <li><a href=""#"">Billing</a></li>
                                <li><a href=""#"">General Question</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</footer>
<!-- footer end -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
