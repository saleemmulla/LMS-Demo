#pragma checksum "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc449d77c2b2c025d5ae6ca776b071d32fb7c00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\_ViewImports.cshtml"
using LMS.WEB.Portal;

#line default
#line hidden
#line 2 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\_ViewImports.cshtml"
using LMS.WEB.Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc449d77c2b2c025d5ae6ca776b071d32fb7c00", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe769afbecc4551140740e3f14dc4cf18e1afa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Employee";

#line default
#line hidden
            BeginContext(46, 325, true);
            WriteLiteral(@"
<div class=""jumbotron"" style=""background: linear-gradient(to left, #777, #33AEFF)"">
    <div class=""text-center"">
        <h2 class=""display-4"">Welcome To Leave Management </h2>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-3"">

        <button class=""btn btn-lg btn-facebook btn-block "" value=""Home""");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                onclick=\"", 371, "\"", 451, 3);
            WriteAttributeValue("", 398, "location.href=\'", 398, 15, true);
#line 16 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\Index.cshtml"
WriteAttributeValue("", 413, Url.Action("ApplyLeave", "Employee"), 413, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 450, "\'", 450, 1, true);
            EndWriteAttribute();
            BeginContext(452, 82, true);
            WriteLiteral("\r\n                type=\"button\">\r\n            Apply for Leave\r\n        </button>\r\n");
            EndContext();
            BeginContext(763, 71, true);
            WriteLiteral("        <button class=\"btn btn-lg btn-facebook btn-block \" value=\"Home\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                onclick=\"", 834, "\"", 917, 3);
            WriteAttributeValue("", 861, "location.href=\'", 861, 15, true);
#line 26 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\Index.cshtml"
WriteAttributeValue("", 876, Url.Action("ViewDashboard", "Employee"), 876, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 916, "\'", 916, 1, true);
            EndWriteAttribute();
            BeginContext(918, 148, true);
            WriteLiteral("\r\n                type=\"button\">\r\n            View Dashboard\r\n        </button>\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n\r\n    </div>\r\n</div>\r\n \r\n\r\n");
            EndContext();
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