#pragma checksum "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96371ee34ebdaeedaa211c907c257d813af1dc6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Details.cshtml", typeof(AspNetCore.Views_User_Details))]
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
#line 1 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\_ViewImports.cshtml"
using Assign_02_V2;

#line default
#line hidden
#line 2 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\_ViewImports.cshtml"
using Assign_02_V2.Models;

#line default
#line hidden
#line 1 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
using Assign_02_V2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96371ee34ebdaeedaa211c907c257d813af1dc6a", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82087d54c412d68301862afe15292fcfdd80f15a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assign_02_V2.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListOfUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(182, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
  
    ViewData["Title"] = "List of users";


#line default
#line hidden
            BeginContext(235, 1145, true);
            WriteLiteral(@"
<div>
    <h4>Details:</h4>
    <hr />
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Username
                </th>
                <th>
                    Password
                </th>
                <th>
                    First name
                </th>
                <th>
                    Last name
                </th>
                <th>
                    Mobile number
                </th>
                <th>
                    Email
                </th>
                <th>
                    Street
                </th>
                <th>
                    City
                </th>
                <th>
                    Province
                </th>
                <th>
                    Postal code
                </th>
                <th>
                    Country
                </th>
                <th>
                    Admin
                </th>
                <th>");
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1381, 40, false);
#line 62 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1489, 40, false);
#line 65 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1597, 41, false);
#line 68 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1706, 40, false);
#line 71 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1814, 44, false);
#line 74 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1926, 37, false);
#line 77 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2031, 38, false);
#line 80 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2137, 36, false);
#line 83 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2241, 40, false);
#line 86 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.Province));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2349, 42, false);
#line 89 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2459, 39, false);
#line 92 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2498, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2566, 70, false);
#line 95 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
               Write(Html.CheckBox("Is admin", (userManager.IsInRoleAsync(Model, "Admin"))));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 95, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(2731, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae607e95049d4eb298f79d5cf3d4097f", async() => {
                BeginContext(2777, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Augusto\Google Drive\COMP3973\Assignment01_V2\Assign_02_V2\Views\User\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2785, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(2797, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daf6ebc8c4c043b38ea968390c546dfc", async() => {
                BeginContext(2825, 12, true);
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
            BeginContext(2841, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<AppRole> roleManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assign_02_V2.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
