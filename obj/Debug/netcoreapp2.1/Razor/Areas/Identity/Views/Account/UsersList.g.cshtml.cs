#pragma checksum "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b29dfc2521e53a6dcc8655c1903421ea500b740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Account_UsersList), @"mvc.1.0.view", @"/Areas/Identity/Views/Account/UsersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/Account/UsersList.cshtml", typeof(AspNetCore.Areas_Identity_Views_Account_UsersList))]
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
#line 1 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b29dfc2521e53a6dcc8655c1903421ea500b740", @"/Areas/Identity/Views/Account/UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c100f65cc6ac2b23557f5eec39651e71189c1a", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Account_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boven.Areas.Identity.Models.UsersListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
 if ((await AuthorizationService.AuthorizeAsync(User, "RequireEmployeeRole")).Succeeded)
    {



#line default
#line hidden
            BeginContext(249, 147, true);
            WriteLiteral("        <table>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Namn</th>\r\n                <th>Roller</th>\r\n            </tr>\r\n");
            EndContext();
#line 15 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
             foreach (Boven.Areas.Identity.Models.User user in Model.Users)
            {

#line default
#line hidden
            BeginContext(488, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(535, 7, false);
#line 18 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
                   Write(user.ID);

#line default
#line hidden
            EndContext();
            BeginContext(542, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(574, 9, false);
#line 19 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
                   Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(583, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(640, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b6dad2a7ae34335a07806e8d0880f08", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 21 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = user.Roles;

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
            BeginContext(681, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(734, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d981af2f028a457aa263976ef65377d0", async() => {
                BeginContext(810, 16, true);
                WriteLiteral("Radera användare");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
                                                                            WriteLiteral(user.Name);

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
            BeginContext(830, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 25 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
            }

#line default
#line hidden
            BeginContext(875, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
#line 27 "\\Rigagatandator\5_dev\HT18\Kurser_HT_18\36_45_dotnet_uppsala\dev\asp_net\Uppgift5c\Boven\Areas\Identity\Views\Account\UsersList.cshtml"
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boven.Areas.Identity.Models.UsersListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591