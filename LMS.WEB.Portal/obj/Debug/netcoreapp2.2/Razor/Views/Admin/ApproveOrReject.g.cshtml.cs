#pragma checksum "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53cabde792574fc09e17ca834f64c96c4bf3c55b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ApproveOrReject), @"mvc.1.0.view", @"/Views/Admin/ApproveOrReject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ApproveOrReject.cshtml", typeof(AspNetCore.Views_Admin_ApproveOrReject))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cabde792574fc09e17ca834f64c96c4bf3c55b", @"/Views/Admin/ApproveOrReject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe769afbecc4551140740e3f14dc4cf18e1afa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ApproveOrReject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
  
    ViewData["Title"] = "ApproveOrReject";

#line default
#line hidden
            BeginContext(51, 979, true);
            WriteLiteral(@"<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"">
    $(function () {
        $('[id*=btnOK]').on('click', function () {
            var id = $(this).closest('tr').find('td').eq(0).html().trim();
            $.post(""/Manager/ApproveOrRejectLeave"", { ID: id,stausCode:2 }, function (r) {
            });
        });
    });
    $(function () {
        $('[id*=btnCancel]').on('click', function () {
            var id = $(this).closest('tr').find('td').eq(0).html().trim();
            $.post(""/Manager/ApproveOrRejectLeave"", { ID: id, stausCode:3 }, function (r) {
            });
        });
    });
</script>
<div class=""row"">
    <div class=""col-md-6"">
        <h5>Approve or Reject leaves of your employee </h5>
    </div>
    <div class=""col-md-4"">
    </div>
    <div class=""col-md-2"">
        <button type=""button"" class=""btn btn-link btn-lg float-right""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1030, "\"", 1085, 3);
            WriteAttributeValue("", 1040, "location.href=\'", 1040, 15, true);
#line 28 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
WriteAttributeValue("", 1055, Url.Action("Index", "Admin"), 1055, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 1084, "\'", 1084, 1, true);
            EndWriteAttribute();
            BeginContext(1086, 457, true);
            WriteLiteral(@">Back</button>
    </div>
</div>
<hr />
<table id=""leavetable"" class=""table table-bordered"">
    <thead bgcolor=""lightblue"">
        <tr>
            <th>Leave ID</th>
            <th>BadgeNumber</th>
            <th>EmployeeName</th>
            <th>DepartmentName</th>
            <th>From Date</th>
            <th>To Date</th>
            <th>No of Leave</th>
            <th>Approve/Reject</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 46 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
         foreach (LeaveModel lm in Model)
        {

#line default
#line hidden
            BeginContext(1597, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1636, 5, false);
#line 49 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1641, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1669, 14, false);
#line 50 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.BadgeNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1683, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1711, 15, false);
#line 51 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.EmployeeName);

#line default
#line hidden
            EndContext();
            BeginContext(1726, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1754, 17, false);
#line 52 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(1771, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1799, 38, false);
#line 53 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.LeaveFromDate.ToString("dd-MM-yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1865, 36, false);
#line 54 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.LeaveToDate.ToString("dd-MM-yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1929, 17, false);
#line 55 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
               Write(lm.NumberOfLeaves);

#line default
#line hidden
            EndContext();
            BeginContext(1946, 109, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <button id=\"btnOK\" type=\"button\" class=\"btn-sm btn-primary\" ");
            EndContext();
            BeginContext(2057, 42, false);
#line 57 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
                                                                            Write(lm.Status > 1 ? "disabled='disabled'" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2100, 97, true);
            WriteLiteral(">ok</button>\r\n                    <button id=\"btnCancel\" type=\"button\" class=\"btn-sm btn-danger\" ");
            EndContext();
            BeginContext(2199, 42, false);
#line 58 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
                                                                               Write(lm.Status > 1 ? "disabled='disabled'" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2242, 55, true);
            WriteLiteral(">X</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 61 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Admin\ApproveOrReject.cshtml"
        }

#line default
#line hidden
            BeginContext(2308, 195, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h6>Note: In case of Approved/Rejected Leave action button will be disabled.  </h6>\r\n    </div>\r\n</div>\r\n\r\n");
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