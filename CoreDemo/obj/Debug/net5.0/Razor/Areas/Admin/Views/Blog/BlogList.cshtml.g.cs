#pragma checksum "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Areas\Admin\Views\Blog\BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779b9542dfc215bf6a6247c46781118fa4d45918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_BlogList), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/BlogList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779b9542dfc215bf6a6247c46781118fa4d45918", @"/Areas/Admin/Views/Blog/BlogList.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mustafa\source\repos\CoreProjeKamp\CoreDemo\CoreDemo\Areas\Admin\Views\Blog\BlogList.cshtml"
  
    ViewData["Title"] = "BlogList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BlogList</h1>\r\n<br />\r\n");
            WriteLiteral("<a href=\"/Admin/Blog/ExportStaticExcelBlogList\" class=\" btn btn-primary\">Excel Listesini İndir</a>\r\n<script>\r\n    function DownloadExcelBlogList(){\r\n        wind.open(\"/Admin/Blog/ExportStaticExcelBlogList\");\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591