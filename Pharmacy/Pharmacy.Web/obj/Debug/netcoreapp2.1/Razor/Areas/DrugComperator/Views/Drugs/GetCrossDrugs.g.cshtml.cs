#pragma checksum "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2cf51aae1c7dbbd7b193e20a479882b55099e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DrugComperator_Views_Drugs_GetCrossDrugs), @"mvc.1.0.view", @"/Areas/DrugComperator/Views/Drugs/GetCrossDrugs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DrugComperator/Views/Drugs/GetCrossDrugs.cshtml", typeof(AspNetCore.Areas_DrugComperator_Views_Drugs_GetCrossDrugs))]
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
#line 1 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Web;

#line default
#line hidden
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Web.Areas.Shop.Models;

#line default
#line hidden
#line 4 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Services.Shop.Models;

#line default
#line hidden
#line 5 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Web.Areas.DrugComperator.Models;

#line default
#line hidden
#line 6 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Web.Areas.Admin.Models;

#line default
#line hidden
#line 7 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\_ViewImports.cshtml"
using Pharmacy.Services.DrugComperator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2cf51aae1c7dbbd7b193e20a479882b55099e8f", @"/Areas/DrugComperator/Views/Drugs/GetCrossDrugs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24eec365c83743a353d5499f7a6496be59a8550", @"/Areas/DrugComperator/Views/_ViewImports.cshtml")]
    public class Areas_DrugComperator_Views_Drugs_GetCrossDrugs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrossDrugsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100px; width: 100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
  
    ViewData["Title"] = "GetCrossDrugs";

#line default
#line hidden
            BeginContext(77, 329, true);
            WriteLiteral(@"
<h2 class=""text-center"">Противодействащи лекарства</h2>

<div class=""container"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th></th>
                <th>Вид</th>
                <th>Цена</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
             for (int i = 0; i < Model.CrossDrugs.Ids.Count; i++)
            {
                //for (int j = 0; j < Model.CrossDrugs.Ids[i].Count; j++)
                //{

#line default
#line hidden
            BeginContext(584, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(638, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06a0bab2a40145c2b5e6429c3594128d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 648, "~/ProductsImages/", 648, 17, true);
#line 24 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
AddHtmlAttributeValue("", 665, Model.CrossDrugs.ImgNames[i], 665, 29, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(735, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(771, 25, false);
#line 25 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
                       Write(Model.CrossDrugs.Names[i]);

#line default
#line hidden
            EndContext();
            BeginContext(796, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(832, 26, false);
#line 26 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
                       Write(Model.CrossDrugs.Prices[i]);

#line default
#line hidden
            EndContext();
            BeginContext(858, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(893, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e59d8e56ab2a42ebab4410dd8ab282e6", async() => {
                BeginContext(1020, 12, true);
                WriteLiteral("Към продукта");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
                                                                                                                     WriteLiteral(Model.CrossDrugs.Ids[i]);

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
            BeginContext(1036, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 29 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
                //  }
            }

#line default
#line hidden
            BeginContext(1108, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1153, 132, false);
#line 36 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Areas\DrugComperator\Views\Drugs\GetCrossDrugs.cshtml"
Write(Html.Partial("_PagesPartial", new Pharmacy.Common.ViewModelWithPages { AllPages = Model.AllPages, CurrentPage = Model.CurrentPage }));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 1, true);
            WriteLiteral(";");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrossDrugsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591