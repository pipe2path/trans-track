#pragma checksum "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f699d9ef2208baa64ba9282f3ce2657510659579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(trans_track.Pages.Vehicles.Pages_Vehicles_Details), @"mvc.1.0.razor-page", @"/Pages/Vehicles/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Vehicles/Details.cshtml", typeof(trans_track.Pages.Vehicles.Pages_Vehicles_Details), null)]
namespace trans_track.Pages.Vehicles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\code\vs\trans-track\trans-track\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\code\vs\trans-track\trans-track\Pages\_ViewImports.cshtml"
using trans_track;

#line default
#line hidden
#line 3 "D:\code\vs\trans-track\trans-track\Pages\_ViewImports.cshtml"
using trans_track.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f699d9ef2208baa64ba9282f3ce2657510659579", @"/Pages/Vehicles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9186e7640e78667ccec4a775b4174fd514bf1b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vehicles_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 132, true);
            WriteLiteral("\r\n<h1>Vehicle Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        \r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(187, 48, false);
#line 11 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Vehicle.Make));

#line default
#line hidden
            EndContext();
            BeginContext(235, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-4\">\r\n                ");
            EndContext();
            BeginContext(308, 44, false);
#line 14 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
           Write(Html.DisplayFor(model => model.Vehicle.Make));

#line default
#line hidden
            EndContext();
            BeginContext(352, 64, true);
            WriteLiteral("\r\n            </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(417, 49, false);
#line 17 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Model));

#line default
#line hidden
            EndContext();
            BeginContext(466, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(527, 45, false);
#line 20 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Model));

#line default
#line hidden
            EndContext();
            BeginContext(572, 93, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(666, 48, false);
#line 25 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Year));

#line default
#line hidden
            EndContext();
            BeginContext(714, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(776, 44, false);
#line 28 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Year));

#line default
#line hidden
            EndContext();
            BeginContext(820, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(881, 52, false);
#line 31 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(933, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(995, 48, false);
#line 34 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1104, 51, false);
#line 37 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.License));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1217, 47, false);
#line 40 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.License));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1325, 47, false);
#line 43 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.VIN));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1434, 43, false);
#line 46 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.VIN));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1538, 57, false);
#line 49 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.DatePurchased));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1657, 53, false);
#line 52 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.DatePurchased));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1771, 53, false);
#line 55 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.PricePaid));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1886, 49, false);
#line 58 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.PricePaid));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1996, 57, false);
#line 61 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.PurchasedFrom));

#line default
#line hidden
            EndContext();
            BeginContext(2053, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2115, 53, false);
#line 64 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.PurchasedFrom));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 394, true);
            WriteLiteral(@"
        </dd>
        <dd class=""col-sm-10"">
        </dd>
        <dt class=""col-sm-10"" style=""color:darkred"">
            Services
        </dt>
        <dd>
            <table class=""table"">
                <tr>
                    <th>Type</th>
                    <th>Date</th>
                    <th>Vendor</th>
                    <th>Mileage</th>
                </tr>
");
            EndContext();
#line 79 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                 foreach (var item in Model.Vehicle.Services)
                {

#line default
#line hidden
            BeginContext(2644, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2729, 46, false);
#line 83 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceType));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2867, 46, false);
#line 86 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(2913, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3005, 48, false);
#line 89 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceVendor));

#line default
#line hidden
            EndContext();
            BeginContext(3053, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3145, 42, false);
#line 92 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(3187, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 95 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3266, 69, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3335, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f699d9ef2208baa64ba9282f3ce265751065957914430", async() => {
                BeginContext(3389, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                           WriteLiteral(Model.Vehicle.ID);

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
            BeginContext(3397, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3405, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f699d9ef2208baa64ba9282f3ce265751065957916744", async() => {
                BeginContext(3427, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3443, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<trans_track.Pages.Vehicle.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<trans_track.Pages.Vehicle.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<trans_track.Pages.Vehicle.DetailsModel>)PageContext?.ViewData;
        public trans_track.Pages.Vehicle.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
