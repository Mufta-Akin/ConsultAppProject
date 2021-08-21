#pragma checksum "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da5b072beb630a74ba7ed36598dc22b99c98146f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Practice__Ailments), @"mvc.1.0.view", @"/Views/Practice/_Ailments.cshtml")]
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
#line 1 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\_ViewImports.cshtml"
using Consultation.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\_ViewImports.cshtml"
using Consultation.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\_ViewImports.cshtml"
using Consultation.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da5b072beb630a74ba7ed36598dc22b99c98146f", @"/Views/Practice/_Ailments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187f31b766559566e6f23f38276dd61185384fc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Practice__Ailments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Patient>
    {
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
        private global::Consultation.Web.ConditionTagHelper __Consultation_Web_ConditionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h5 class=""mt-2 text-info"">Ailments</h5>
<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>           
            <th style=""width: 65%"">Issue</th>
            <th style=""width: 25%"">Created</th>  
            <th style=""width: 10%"">Active</th>       
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 13 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml"
         foreach(var a in Model.Ailments) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>              \n                <td>");
#nullable restore
#line 15 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml"
               Write(a.Issue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 16 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml"
               Write(a.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \n                <!-- asp-condtion to render done icon if Active and clear icon if inactive -->\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da5b072beb630a74ba7ed36598dc22b99c98146f4760", async() => {
                WriteLiteral("Yes");
            }
            );
            __Consultation_Web_ConditionTagHelper = CreateTagHelper<global::Consultation.Web.ConditionTagHelper>();
            __tagHelperExecutionContext.Add(__Consultation_Web_ConditionTagHelper);
#nullable restore
#line 19 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml"
__Consultation_Web_ConditionTagHelper.Condition = (a.Active);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-condition", __Consultation_Web_ConditionTagHelper.Condition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("            \n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da5b072beb630a74ba7ed36598dc22b99c98146f6169", async() => {
                WriteLiteral("No");
            }
            );
            __Consultation_Web_ConditionTagHelper = CreateTagHelper<global::Consultation.Web.ConditionTagHelper>();
            __tagHelperExecutionContext.Add(__Consultation_Web_ConditionTagHelper);
#nullable restore
#line 20 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml"
__Consultation_Web_ConditionTagHelper.Condition = (!a.Active);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-condition", __Consultation_Web_ConditionTagHelper.Condition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \n                </td>\n            </tr>   \n");
#nullable restore
#line 23 "C:\Users\mufta\OneDrive\AA Consultation base\Consultation-baseE-05\Consultation.Web\Views\Practice\_Ailments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
