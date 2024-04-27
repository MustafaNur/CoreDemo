#pragma checksum "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee701ee7f23a0ca15745f7b2a7061abaeade7ca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee701ee7f23a0ca15745f7b2a7061abaeade7ca9", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--/main-->
<section class=""main-content-w3layouts-agileits"">
	<div class=""container"">
		<h3 class=""tittle"">Blog Gönderileri</h3>
		<div class=""inner-sec"">
			<!--left-->
			<div class=""left-blog-info-w3layouts-agileits text-left"">
				<div class=""row"">
					
");
#nullable restore
#line 16 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-lg-4 card mb-5\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 501, "\"", 539, 3);
            WriteAttributeValue("", 508, "/Blog/BlogReadAll/", 508, 18, true);
#nullable restore
#line 19 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 526, item.BlogID, 526, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 538, "/", 538, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 554, "\"", 575, 1);
#nullable restore
#line 20 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 560, item.BlogImage, 560, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 607, "\"", 613, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:300px;\">\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 26 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                        Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-comment\"></i> 0\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 36 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1204, "\"", 1241, 2);
            WriteAttributeValue("", 1211, "/Blog/BlogReadAll/", 1211, 18, true);
#nullable restore
#line 42 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1229, item.BlogID, 1229, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 46 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                               Write(item.BlogContent.Substring(0, Math.Min(130, item.BlogContent.Length)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                     if (item.BlogContent.Length > 130)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<span>...</span> \r\n");
#nullable restore
#line 50 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1527, "\"", 1565, 3);
            WriteAttributeValue("", 1534, "/Blog/BlogReadAll/", 1534, 18, true);
#nullable restore
#line 52 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1552, item.BlogID, 1552, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1564, "/", 1564, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<!--//left-->\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n<!--//main-->");
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
