#pragma checksum "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a979d8a31aa745dccb091ae1143aa8311fd47b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ApplyLeave), @"mvc.1.0.view", @"/Views/Employee/ApplyLeave.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/ApplyLeave.cshtml", typeof(AspNetCore.Views_Employee_ApplyLeave))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a979d8a31aa745dccb091ae1143aa8311fd47b3", @"/Views/Employee/ApplyLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe769afbecc4551140740e3f14dc4cf18e1afa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ApplyLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LMS.WEB.Portal.Models.LeaveModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApplyLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 22, true);
            WriteLiteral("<h4>Apply Leave</h4>\r\n");
            EndContext();
#line 3 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
  
    Userdetails userdetails = (Userdetails)TempData["userdetails"];

#line default
#line hidden
#line 6 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(169, 37, true);
            WriteLiteral("    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(206, 3175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a979d8a31aa745dccb091ae1143aa8311fd47b37206", async() => {
                BeginContext(304, 258, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-2"">Badge</div>
                <div class=""col-md-4"">
                    <input type=""text"" id=""BadgeNumber"" name=""BadgeNumber"" readonly='readonly' autocomplete=""off"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value =", 562, "", 610, 1);
                WriteAttributeValue("", 570, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#line 13 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                               if (Model != null){ 

#line default
#line hidden
                    BeginContext(592, 17, false);
#line 13 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                              Write(Model.BadgeNumber);

#line default
#line hidden
                    EndContext();
#line 13 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                                     }

#line default
#line hidden
                    PopWriter();
                }
                ), 570, 40, false);
                EndWriteAttribute();
                BeginContext(610, 245, true);
                WriteLiteral(" >\r\n                </div>\r\n\r\n                <div class=\"col-md-2\">Employee Name</div>\r\n                <div class=\"col-md-4\">  <input type=\"text\" id=\"EmployeeName\" name=\"EmployeeName\" readonly=\'readonly\' autocomplete=\"off\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 855, "", 903, 1);
                WriteAttributeValue("", 862, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#line 17 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                    if (Model != null) {

#line default
#line hidden
                    BeginContext(884, 18, false);
#line 17 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                                   Write(Model.EmployeeName);

#line default
#line hidden
                    EndContext();
#line 17 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                                                           }

#line default
#line hidden
                    PopWriter();
                }
                ), 862, 41, false);
                EndWriteAttribute();
                BeginContext(903, 317, true);
                WriteLiteral(@" ></div>
            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-2"">Department</div>
                <div class=""col-md-4"">
                    <input type=""text"" id=""DepartmentName"" name=""DepartmentName"" readonly='readonly' autocomplete=""off"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=", 1220, "", 1270, 1);
                WriteAttributeValue("", 1227, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#line 23 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                    if (Model != null) {

#line default
#line hidden
                    BeginContext(1249, 20, false);
#line 23 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                   Write(Model.DepartmentName);

#line default
#line hidden
                    EndContext();
#line 23 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                                             }

#line default
#line hidden
                    PopWriter();
                }
                ), 1227, 43, false);
                EndWriteAttribute();
                BeginContext(1270, 237, true);
                WriteLiteral(" >\r\n                </div>\r\n\r\n                <div class=\"col-md-2\">Manager</div>\r\n                <div class=\"col-md-4\">  <input type=\"text\" id=\"ManagerName\" name=\"ManagerName\" readonly=\'readonly\' autocomplete=\"off\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1507, "", 1555, 1);
                WriteAttributeValue("", 1514, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#line 27 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                  if (Model != null) {

#line default
#line hidden
                    BeginContext(1536, 17, false);
#line 27 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                                 Write(Model.ManagerName);

#line default
#line hidden
                    EndContext();
#line 27 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                                                                                                                                                                                                         }

#line default
#line hidden
                    PopWriter();
                }
                ), 1514, 41, false);
                EndWriteAttribute();
                BeginContext(1555, 179, true);
                WriteLiteral("></div>\r\n            </div>\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-2\">Type Of Leave</div>\r\n                <div class=\"col-md-4\">\r\n");
                EndContext();
#line 33 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                    if (Model.LeaveType != null)
                   {

#line default
#line hidden
                BeginContext(1806, 21, true);
                WriteLiteral("                     ");
                EndContext();
                BeginContext(1827, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a979d8a31aa745dccb091ae1143aa8311fd47b315866", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 35 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LeaveTypeId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.LeaveType, "LeaveTypeId", "LeaveTypeName"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1945, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 36 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
                   }

#line default
#line hidden
                BeginContext(1967, 236, true);
                WriteLiteral("</div>\r\n            </div>\r\n\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-2\">\r\n                    From Date\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2204, 123, false);
#line 45 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
               Write(Html.EditorFor(model => @model.LeaveFromDate, new { htmlAttributes = new { @class = "form-control oso", @type = "date" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2327, 139, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-2\">To Date</div>\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2467, 121, false);
#line 49 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
               Write(Html.EditorFor(model => @model.LeaveToDate, new { htmlAttributes = new { @class = "form-control oso", @type = "date" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2588, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2610, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a979d8a31aa745dccb091ae1143aa8311fd47b319752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 50 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LeaveToDate);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2676, 698, true);
                WriteLiteral(@"
                </div>
            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-2"">Reason</div>
                <div class=""col-md-4"">
                    <input type=""text"" id=""Reason"" name=""Reason""  autocomplete=""off""  class=""form-control"" required autofocus>
                </div>

            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-2"">
                    <button class=""btn btn-lg btn-facebook btn-block "" value=""Home""
                            type=""submit"">
                        Submit
                    </button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3381, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 72 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
}

#line default
#line hidden
            BeginContext(3398, 393, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""aModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""aModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""aModalLabel"">Message</h4>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(3792, 14, false);
#line 82 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
           Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(3806, 123, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3929, "\"", 3987, 3);
            WriteAttributeValue("", 3939, "location.href=\'", 3939, 15, true);
#line 85 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
WriteAttributeValue("", 3954, Url.Action("Index", "Employee"), 3954, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 3986, "\'", 3986, 1, true);
            EndWriteAttribute();
            BeginContext(3988, 171, true);
            WriteLiteral(">OK</button>\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 91 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
  
    if (ViewBag.Result != null)
    {

#line default
#line hidden
            BeginContext(4203, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(4211, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a979d8a31aa745dccb091ae1143aa8311fd47b326407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4262, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(4272, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a979d8a31aa745dccb091ae1143aa8311fd47b327596", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4339, 153, true);
            WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            $(function () {\r\n                $(\"#aModal\").modal(\'show\');\r\n            });\r\n        </script>\r\n");
            EndContext();
#line 101 "C:\Users\saleem_mulla\Documents\SaleemWork\P\Personal\Source\LMS\LMS.WEB.Portal\Views\Employee\ApplyLeave.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LMS.WEB.Portal.Models.LeaveModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
