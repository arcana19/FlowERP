#pragma checksum "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ff02d80b5e26f1cdd4b2b89eb6f0163d71a910"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Delete), @"mvc.1.0.view", @"/Views/Staffs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staffs/Delete.cshtml", typeof(AspNetCore.Views_Staffs_Delete))]
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
#line 1 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\_ViewImports.cshtml"
using FlowAuth;

#line default
#line hidden
#line 2 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\_ViewImports.cshtml"
using FlowAuth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ff02d80b5e26f1cdd4b2b89eb6f0163d71a910", @"/Views/Staffs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89129962b79090d0f1ae5f5d5048e447eef01cf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowAuth.Models.Staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Staff</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(241, 46, false);
#line 15 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_type));

#line default
#line hidden
            EndContext();
            BeginContext(287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(331, 42, false);
#line 18 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_type));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 50, false);
#line 21 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_fullName));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 46, false);
#line 24 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_fullName));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(601, 50, false);
#line 27 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_position));

#line default
#line hidden
            EndContext();
            BeginContext(651, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(695, 46, false);
#line 30 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_position));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(785, 52, false);
#line 33 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_emp_nature));

#line default
#line hidden
            EndContext();
            BeginContext(837, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(881, 48, false);
#line 36 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_emp_nature));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(973, 50, false);
#line 39 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_res_addr));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1067, 46, false);
#line 42 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_res_addr));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1157, 51, false);
#line 45 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_cellphone));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1252, 47, false);
#line 48 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_cellphone));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1343, 47, false);
#line 51 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_email));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1434, 43, false);
#line 54 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_email));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1521, 45, false);
#line 57 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1610, 41, false);
#line 60 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1695, 49, false);
#line 63 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_country));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1788, 45, false);
#line 66 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_country));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1877, 47, false);
#line 69 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_idNum));

#line default
#line hidden
            EndContext();
            BeginContext(1924, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1968, 43, false);
#line 72 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_idNum));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2055, 50, false);
#line 75 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_passport));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2149, 46, false);
#line 78 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_passport));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2239, 51, false);
#line 81 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_incomeTax));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2334, 47, false);
#line 84 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_incomeTax));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2425, 52, false);
#line 87 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_medicalAid));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2521, 48, false);
#line 90 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_medicalAid));

#line default
#line hidden
            EndContext();
            BeginContext(2569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2613, 54, false);
#line 93 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_medicalAidNo));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2711, 50, false);
#line 96 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_medicalAidNo));

#line default
#line hidden
            EndContext();
            BeginContext(2761, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2805, 54, false);
#line 99 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_nextKin_name));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2903, 50, false);
#line 102 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_nextKin_name));

#line default
#line hidden
            EndContext();
            BeginContext(2953, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2997, 59, false);
#line 105 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_nextKin_cellphone));

#line default
#line hidden
            EndContext();
            BeginContext(3056, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3100, 55, false);
#line 108 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_nextKin_cellphone));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3199, 46, false);
#line 111 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_rate));

#line default
#line hidden
            EndContext();
            BeginContext(3245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3289, 42, false);
#line 114 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_rate));

#line default
#line hidden
            EndContext();
            BeginContext(3331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3375, 51, false);
#line 117 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_leaveDays));

#line default
#line hidden
            EndContext();
            BeginContext(3426, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3470, 47, false);
#line 120 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_leaveDays));

#line default
#line hidden
            EndContext();
            BeginContext(3517, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3561, 49, false);
#line 123 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff_lastDay));

#line default
#line hidden
            EndContext();
            BeginContext(3610, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3654, 45, false);
#line 126 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Staff_lastDay));

#line default
#line hidden
            EndContext();
            BeginContext(3699, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3737, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96acdaaeb7a8432f9877b5d26e8c22de", async() => {
                BeginContext(3763, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3773, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55fd7b7d097c4fc49b08e3ffd6937010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 131 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Staffs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3814, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3898, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e5b6ee2dc849ff88ccdaab786d0640", async() => {
                    BeginContext(3920, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3936, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3949, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowAuth.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591