#pragma checksum "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbcd4b3dfab66b23639c828994c83967c6d17f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrainingDetails_Details), @"mvc.1.0.view", @"/Views/TrainingDetails/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbcd4b3dfab66b23639c828994c83967c6d17f84", @"/Views/TrainingDetails/Details.cshtml")]
    public class Views_TrainingDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainingTracker_Backend.Model.TimesheetDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TimesheetDetailsModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrainingStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrainingEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrainingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1355, "\"", 1382, 1);
#nullable restore
#line 46 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker_Backend\TrainingTracker_Backend\Views\TrainingDetails\Details.cshtml"
WriteAttributeValue("", 1370, Model.EmpId, 1370, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainingTracker_Backend.Model.TimesheetDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
