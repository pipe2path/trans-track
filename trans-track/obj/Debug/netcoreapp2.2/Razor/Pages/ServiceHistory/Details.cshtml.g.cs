#pragma checksum "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a375d8d344ed073540ae5198c490cf981fbedd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(trans_track.Pages.ServiceHistory.Pages_ServiceHistory_Details), @"mvc.1.0.razor-page", @"/Pages/ServiceHistory/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ServiceHistory/Details.cshtml", typeof(trans_track.Pages.ServiceHistory.Pages_ServiceHistory_Details), null)]
namespace trans_track.Pages.ServiceHistory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\zomon\code\vs\trans-track\trans-track\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\zomon\code\vs\trans-track\trans-track\Pages\_ViewImports.cshtml"
using trans_track;

#line default
#line hidden
#line 3 "D:\zomon\code\vs\trans-track\trans-track\Pages\_ViewImports.cshtml"
using trans_track.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a375d8d344ed073540ae5198c490cf981fbedd8", @"/Pages/ServiceHistory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9186e7640e78667ccec4a775b4174fd514bf1b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ServiceHistory_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(61, 108, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Service</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(170, 53, false);
#line 9 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Service.VehicleID));

#line default
#line hidden
            EndContext();
            BeginContext(223, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(285, 49, false);
#line 12 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Service.VehicleID));

#line default
#line hidden
            EndContext();
            BeginContext(334, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(395, 55, false);
#line 15 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Service.ServiceType));

#line default
#line hidden
            EndContext();
            BeginContext(450, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(512, 51, false);
#line 18 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Service.ServiceType));

#line default
#line hidden
            EndContext();
            BeginContext(563, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(624, 55, false);
#line 21 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Service.ServiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(679, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(741, 51, false);
#line 24 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Service.ServiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(792, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(853, 57, false);
#line 27 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Service.ServiceVendor));

#line default
#line hidden
            EndContext();
            BeginContext(910, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(972, 53, false);
#line 30 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Service.ServiceVendor));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1086, 51, false);
#line 33 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Service.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1199, 47, false);
#line 36 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
       Write(Html.DisplayFor(model => model.Service.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1293, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a375d8d344ed073540ae5198c490cf981fbedd88428", async() => {
                BeginContext(1347, 4, true);
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
#line 41 "D:\zomon\code\vs\trans-track\trans-track\Pages\ServiceHistory\Details.cshtml"
                           WriteLiteral(Model.Service.ID);

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
            BeginContext(1355, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1363, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a375d8d344ed073540ae5198c490cf981fbedd810752", async() => {
                BeginContext(1385, 12, true);
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
            BeginContext(1401, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<trans_track.Pages.ServiceHistory.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<trans_track.Pages.ServiceHistory.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<trans_track.Pages.ServiceHistory.DetailsModel>)PageContext?.ViewData;
        public trans_track.Pages.ServiceHistory.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
