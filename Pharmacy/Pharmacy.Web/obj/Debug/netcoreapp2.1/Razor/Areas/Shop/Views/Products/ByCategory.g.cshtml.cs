#pragma checksum "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bea9f0d8784fde673a4d3ac7b2da6bad090368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Shop_Views_Products_ByCategory), @"mvc.1.0.view", @"/Areas/Shop/Views/Products/ByCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Shop/Views/Products/ByCategory.cshtml", typeof(AspNetCore.Areas_Shop_Views_Products_ByCategory))]
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
#line 1 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Web;

#line default
#line hidden
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Web.Areas.Shop.Models;

#line default
#line hidden
#line 4 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Services.Shop.Models;

#line default
#line hidden
#line 5 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Web.Components;

#line default
#line hidden
#line 6 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Common;

#line default
#line hidden
#line 7 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\_ViewImports.cshtml"
using Pharmacy.Services.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bea9f0d8784fde673a4d3ac7b2da6bad090368", @"/Areas/Shop/Views/Products/ByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596934e8d847aa51d9adcfa0dfff20a035d686d7", @"/Areas/Shop/Views/_ViewImports.cshtml")]
    public class Areas_Shop_Views_Products_ByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/shop-homepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right my-1 mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml"
  
    ViewData["Title"] = "ByCategory";

#line default
#line hidden
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(92, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(98, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7faea1722e3a44ea9e329d0bf2a84808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(154, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
#line 10 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(192, 34, true);
            WriteLiteral("    <div class=\"col-12\">\r\n        ");
            EndContext();
            BeginContext(226, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa7ddc18fc044652928fc51decee0335", async() => {
                BeginContext(335, 41, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Добави продукт");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(380, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 15 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml"
}

#line default
#line hidden
            BeginContext(397, 51, true);
            WriteLiteral("<div class=\"px-3\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(450, 50, false);
#line 18 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml"
    Write(await Component.InvokeAsync<CategoriesComponent>());

#line default
#line hidden
            EndContext();
            BeginContext(501, 96, true);
            WriteLiteral("\r\n        <div class=\"container col-lg-9 my-5\">\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(598, 41, false);
#line 21 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml"
           Write(Html.Partial("_Products", Model.Products));

#line default
#line hidden
            EndContext();
            BeginContext(639, 109, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- /.row -->\r\n    </div>\r\n    <!-- /.col-lg-9 -->\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(749, 116, false);
#line 29 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\Shop\Views\Products\ByCategory.cshtml"
Write(Html.Partial("_PagesPartial", new ViewModelWithPages { AllPages = Model.AllPages, CurrentPage = Model.CurrentPage }));

#line default
#line hidden
            EndContext();
            BeginContext(865, 1, true);
            WriteLiteral("s");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
