#pragma checksum "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Manager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4c0a62326e2c5c3f759b477793326278be51c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Index), @"mvc.1.0.view", @"/Views/Manager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/Index.cshtml", typeof(AspNetCore.Views_Manager_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4c0a62326e2c5c3f759b477793326278be51c1", @"/Views/Manager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe769afbecc4551140740e3f14dc4cf18e1afa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Manager\Index.cshtml"
  
    ViewData["Title"] = "Manager";

#line default
#line hidden
            BeginContext(45, 328, true);
            WriteLiteral(@"
<div class=""jumbotron"" style=""background: linear-gradient(to left, #777, #33AEFF)"">
    <div class=""text-center"">
        <h2 class=""display-4"">Welcome To Leave Management </h2>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-3"">

        <button class=""btn btn-lg btn-facebook btn-block "" value=""Manager""");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                onclick=\"", 373, "\"", 457, 3);
            WriteAttributeValue("", 400, "location.href=\'", 400, 15, true);
#line 16 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Manager\Index.cshtml"
WriteAttributeValue("", 415, Url.Action("ApproveOrReject", "Manager"), 415, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 456, "\'", 456, 1, true);
            EndWriteAttribute();
            BeginContext(458, 162, true);
            WriteLiteral("\r\n                type=\"button\">\r\n            Approve/Reject Leaves\r\n        </button>\r\n        <button class=\"btn btn-lg btn-facebook btn-block \" value=\"Manager\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                onclick=\"", 620, "\"", 699, 3);
            WriteAttributeValue("", 647, "location.href=\'", 647, 15, true);
#line 21 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Manager\Index.cshtml"
WriteAttributeValue("", 662, Url.Action("ApplyLeave", "Manager"), 662, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 698, "\'", 698, 1, true);
            EndWriteAttribute();
            BeginContext(700, 148, true);
            WriteLiteral("\r\n                type=\"button\">\r\n            ApplyLeave\r\n        </button>\r\n        <button class=\"btn btn-lg btn-facebook btn-block \" value=\"Home\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                onclick=\"", 848, "\"", 930, 3);
            WriteAttributeValue("", 875, "location.href=\'", 875, 15, true);
#line 26 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Manager\Index.cshtml"
WriteAttributeValue("", 890, Url.Action("ViewDashboard", "Manager"), 890, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 929, "\'", 929, 1, true);
            EndWriteAttribute();
            BeginContext(931, 147, true);
            WriteLiteral("\r\n                type=\"button\">\r\n            View Dashboard\r\n        </button>\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
