#pragma checksum "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9e74b10c5bc00311ffc482e0d8d4963e6aed99b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Top), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Top.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Categories/Top.cshtml", typeof(AspNetCore.Areas_Admin_Views_Categories_Top))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9e74b10c5bc00311ffc482e0d8d4963e6aed99b", @"/Areas/Admin/Views/Categories/Top.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bee00843a55a5354e663831da46e9fcc03467c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Top : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriesAdminServiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white float-right mx-3 my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnCategoryAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white btnAddChiledCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddChiled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white btnChiledCategories"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Children", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(148, 51, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Главни категории</h2>\r\n\r\n");
            EndContext();
            BeginContext(199, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc3e08f5cd9445628473d3697d5f1302", async() => {
                BeginContext(341, 44, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> Добави категория");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(389, 195, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Име на категорията</th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 20 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
         foreach (var category in Model)
        {

#line default
#line hidden
            BeginContext(637, 30, true);
            WriteLiteral("        <tr>\r\n            <th>");
            EndContext();
            BeginContext(668, 13, false);
#line 23 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
           Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(681, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(704, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd6fe838ada047eb87e335bd4e26832a", async() => {
                BeginContext(877, 19, true);
                WriteLiteral("Добави подкатегория");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
AddHtmlAttributeValue("", 767, category.Id, 767, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
                                                                                                                                                                   WriteLiteral(category.Id);

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
            BeginContext(900, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(923, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e2ade741d80427f8e0ccbce48cd28ba", async() => {
                BeginContext(1076, 18, true);
                WriteLiteral("Виж подкатегориите");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
                                                                                                                                               WriteLiteral(category.Id);

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
            BeginContext(1098, 22, true);
            WriteLiteral("</th>\r\n        </tr>\r\n");
            EndContext();
#line 27 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
        }

#line default
#line hidden
            BeginContext(1131, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1174, 970, true);
                WriteLiteral(@"
    <script>    
        $(
            $('#btnCategoryAdd').click((event) => {
                event.preventDefault();
                swal({
                    title: ""Добави категория"",
                    input: ""text"",
                    confirmButtonText: ""Добави"",
                    cancelButtonText: ""Отмени"",
                    showCancelButton: true,
                    allowOutsideClick: false,
                    allowEscapeKey: false
                })
                    .then((input) => {
                        if (input['dismiss'] == 'cancel') {

                        } else { 
                            $.ajax({
                                url: event.target.href,
                                headers: {
                                    ""Accept"": ""application/json"",
                                    ""Content-Type"": ""application/json"",
                                    ""RequestVerificationToken"": """);
                EndContext();
                BeginContext(2146, 51, false);
#line 54 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
                                                             Write(AntiForgery.GetAndStoreTokens(Context).RequestToken);

#line default
#line hidden
                EndContext();
                BeginContext(2198, 2512, true);
                WriteLiteral(@"""
                                },
                                method: ""POST"",
                                data: JSON.stringify(input.value)
                            })
                                .done(() => {
                                    location.reload();
                                })
                                .fail(() => {
                                    swal({
                                        title: ""Възникна грешка опитайте отново!""
                                    });
                                })
                        }
                    });
            }),
            $('.btnChiledCategories').click((event) => {
                event.preventDefault();
                $.get(event.target.href, (data) => {
                    let categories = ""<ul>"";
                    for (let category of data) {
                        categories += `<li>${category.name}</li>`;
                    }
                    categories += ""</u");
                WriteLiteral(@"l>"";
                    swal({ 
                        title: 'Подкатегории: ',
                        html: categories
                    });
                });
            }),
            $('.btnAddChiledCategory').click((event) => {
                event.preventDefault();
                $.get(""/Admin/Categories/CategoriesDropDown/"" + event.target.id, (data) => {
                    let obj = {};
                    for (let category of data) {
                        let value = category.value
                        obj[value] = category.text;
                    }
                    swal({
                        title: 'Select Chiled Category',
                        input: 'select',
                        inputOptions: obj,
                        inputPlaceholder: 'Избери категория',
                        cancelButtonText: ""Отмени"",
                        showCancelButton: true,
                    })
                        .then((input) => {
                      ");
                WriteLiteral(@"      if (input['dismiss'] != 'cancel') {
                                $.ajax({
                                    url: event.target.href,
                                    method: ""POST"",
                                    headers: {
                                        ""Accept"": ""application/json"",
                                        ""Content-Type"": ""application/json"",
                                        ""RequestVerificationToken"": """);
                EndContext();
                BeginContext(4712, 51, false);
#line 108 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Admin\Views\Categories\Top.cshtml"
                                                                 Write(AntiForgery.GetAndStoreTokens(Context).RequestToken);

#line default
#line hidden
                EndContext();
                BeginContext(4764, 599, true);
                WriteLiteral(@"""
                                    },
                                    data: JSON.stringify(input.value)
                                })
                                    .done(() => {
                                        location.reload();
                                    })
                                    .fail(() => {
                                        swal(""Възникна грешка опитайте отново!"");
                                    })
                            }
                         })
                });
            })
        )
    </script>
 ");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery AntiForgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriesAdminServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
