#pragma checksum "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Pages\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b18222371148698437bb42c4a45ae9cecfdcf8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Contacts), @"mvc.1.0.razor-page", @"/Pages/Contacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contacts.cshtml", typeof(AspNetCore.Pages_Contacts), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b18222371148698437bb42c4a45ae9cecfdcf8c", @"/Pages/Contacts.cshtml")]
    public class Pages_Contacts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Pages\Contacts.cshtml"
  
    ViewData["Title"] = "Contacts";

#line default
#line hidden
#line 6 "D:\Projects\C#Projects\Pharmacy\Pharmacy.Web\Pages\Contacts.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(124, 167, true);
            WriteLiteral("<h2 class=\"text-center\">Контакти</h2>\r\n\r\n<div>\r\n    <p>Адрес: Град Ямбол, кв.Васил Левски Бл.1</p>\r\n</div>\r\n<div>\r\n    <p>Телефон за връзка: 0000000000</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pharmacy.Web.Pages.ContactsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pharmacy.Web.Pages.ContactsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pharmacy.Web.Pages.ContactsModel>)PageContext?.ViewData;
        public Pharmacy.Web.Pages.ContactsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
