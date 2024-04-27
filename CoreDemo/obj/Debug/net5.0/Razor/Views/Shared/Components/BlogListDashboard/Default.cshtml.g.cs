#pragma checksum "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c115dc03b1e968daef18ff20354602dd200a8b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c115dc03b1e968daef18ff20354602dd200a8b0", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Blog Başlığı </th>
                                <th> Kategori </th>
                                <th> Tarih </th>
                                <th> Last Update </th>
                                <th> Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 21 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1002, "\"", 1023, 1);
#nullable restore
#line 25 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1008, item.BlogImage, 1008, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> \r\n                                </td>\r\n                                    <td>");
#nullable restore
#line 27 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 29 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 31 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                 Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> WD-12345 </td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1579, 2);
            WriteAttributeValue("", 1549, "/Blog/BlogReadAll/", 1549, 18, true);
#nullable restore
#line 33 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1567, item.BlogID, 1567, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-gradient-dark\">Detaylar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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