#pragma checksum "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de093a84f4d6503d4a5b3c031aa2aeea789ca261"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de093a84f4d6503d4a5b3c031aa2aeea789ca261", @"/Pages/Vehicles/Details.cshtml")]
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
            BeginContext(54, 114, true);
            WriteLiteral("\r\n<h1>Vehicle Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(169, 48, false);
#line 10 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Make));

#line default
#line hidden
            EndContext();
            BeginContext(217, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(278, 44, false);
#line 13 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Make));

#line default
#line hidden
            EndContext();
            BeginContext(322, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(383, 49, false);
#line 16 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Model));

#line default
#line hidden
            EndContext();
            BeginContext(432, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(493, 45, false);
#line 19 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Model));

#line default
#line hidden
            EndContext();
            BeginContext(538, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(599, 48, false);
#line 22 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Year));

#line default
#line hidden
            EndContext();
            BeginContext(647, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(708, 44, false);
#line 25 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Year));

#line default
#line hidden
            EndContext();
            BeginContext(752, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(813, 52, false);
#line 28 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(865, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(926, 48, false);
#line 31 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(974, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1035, 51, false);
#line 34 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.License));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1147, 47, false);
#line 37 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.License));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1255, 47, false);
#line 40 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.VIN));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1363, 43, false);
#line 43 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.VIN));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1467, 57, false);
#line 46 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.DatePurchased));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1585, 53, false);
#line 49 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.DatePurchased));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1699, 53, false);
#line 52 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.PricePaid));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1813, 49, false);
#line 55 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.PricePaid));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1923, 57, false);
#line 58 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vehicle.PurchasedFrom));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2041, 53, false);
#line 61 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vehicle.PurchasedFrom));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 128, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n        </dd>\r\n        <dd class=\"col-sm-8\" id=\"vehicle_img\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2222, "\"", 2270, 1);
#line 66 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
WriteAttributeValue("", 2228, Html.DisplayFor(m => m.Vehicle.ImagePath), 2228, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2271, 635, true);
            WriteLiteral(@" alt=""Image"" width=""300"" height=""200"" />
        </dd>
        <dd class=""col-sm-10"">
        </dd>

    </dl>
    <dl class=""row"">
        <dt class=""col-md-10"" style=""color:darkred"">
            Services
        </dt>
        <dd class=""col-md-10"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Type</th>
                        <th scope=""col"">Date</th>
                        <th scope=""col"">Vendor</th>
                        <th scope=""col"">Mileage</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 87 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                     foreach (var item in Model.Vehicle.Services)
                    {

#line default
#line hidden
            BeginContext(2996, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3081, 51, false);
#line 91 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3132, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3224, 46, false);
#line 94 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(3270, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3362, 48, false);
#line 97 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ServiceVendor));

#line default
#line hidden
            EndContext();
            BeginContext(3410, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3502, 42, false);
#line 100 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(3544, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 103 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(3627, 93, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3720, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de093a84f4d6503d4a5b3c031aa2aeea789ca26115194", async() => {
                BeginContext(3774, 4, true);
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
#line 110 "D:\code\vs\trans-track\trans-track\Pages\Vehicles\Details.cshtml"
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
            BeginContext(3782, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3790, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de093a84f4d6503d4a5b3c031aa2aeea789ca26117508", async() => {
                BeginContext(3812, 12, true);
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
            BeginContext(3828, 12, true);
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
