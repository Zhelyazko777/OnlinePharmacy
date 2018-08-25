#pragma checksum "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eecf1b3797c539e3d95cc9cad548ecdd14c5210"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_Index))]
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
#line 1 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Pharmacy.Web;

#line default
#line hidden
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Pharmacy.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Pharmacy.Web.Areas.Admin.Models;

#line default
#line hidden
#line 4 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Pharmacy.Services.Admin.Models;

#line default
#line hidden
#line 5 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Pharmacy.Services.Shop.Models;

#line default
#line hidden
#line 6 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Pharmacy.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eecf1b3797c539e3d95cc9cad548ecdd14c5210", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bee00843a55a5354e663831da46e9fcc03467c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersWithPagesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btnUserDetails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(73, 306, true);
            WriteLiteral(@"
<h2 class=""text-center"">Потребители</h2>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>#</th>
            <th>Потребителкско име</th>
            <th>Имейл</th>
            <th>Дата на регистрация</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
          
            var counter = 0;
         

#line default
#line hidden
            BeginContext(433, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 21 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
         foreach (var user in Model.Users)
        {

#line default
#line hidden
            BeginContext(488, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(532, 9, false);
#line 24 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
                        Write(++counter);

#line default
#line hidden
            EndContext();
            BeginContext(542, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(566, 13, false);
#line 25 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
           Write(user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(579, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(603, 10, false);
#line 26 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(613, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(637, 23, false);
#line 27 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
           Write(user.DateOfRegistration);

#line default
#line hidden
            EndContext();
            BeginContext(660, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(683, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51080549a9b94553803fa7a9098bdbbe", async() => {
                BeginContext(807, 7, true);
                WriteLiteral("Детайли");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
                                                                               WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(818, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(841, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e534a121a74ef8a794b06e3fed96af", async() => {
                BeginContext(951, 6, true);
                WriteLiteral("Изтрии");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
                                                                                 WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(961, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 31 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(994, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1021, 116, false);
#line 35 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Users\Index.cshtml"
Write(Html.Partial("_PagesPartial", new ViewModelWithPages { AllPages = Model.AllPages, CurrentPage = Model.CurrentPage }));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1158, 495, true);
                WriteLiteral(@" 
    <script>
        $('.btnUserDetails').click((event) => {
            event.preventDefault();
            $.get(event.target.href, (data) => {
                swal({
                    title: `Информация за потрибител: ${data.username}`,
                    html: `<ul><li>Address: ${data.address}</li><li>Full Name: ${data.fullName}</li><li>Phone Number: ${data.phoneNumber}</li><li>Email: ${data.email}</li></ul>`
                });
            })
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersWithPagesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591