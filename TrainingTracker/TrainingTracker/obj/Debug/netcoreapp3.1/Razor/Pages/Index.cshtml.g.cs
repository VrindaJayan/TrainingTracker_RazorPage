#pragma checksum "E:\Microservice\MyApp\TrainingTracker\TrainingTracker\TrainingTracker\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0571e091b6de0e4ecd6fe7d265bfcf53fb2f285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TrainingTracker.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace TrainingTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker\TrainingTracker\Pages\_ViewImports.cshtml"
using TrainingTracker;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0571e091b6de0e4ecd6fe7d265bfcf53fb2f285", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c4cc336ec6e07f4eb87aa4d83a043d4226fd45", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Microservice\MyApp\TrainingTracker\TrainingTracker\TrainingTracker\Pages\Index.cshtml"
      
        ViewData["Title"] = "Home page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row mb-auto"">
        <div class=""col-md-4"">
            <div class=""row no-gutters border mb-4"">
                <div class=""col p-4 mb-4 "">
                    <p class=""card-text"">
                        Training Tracker
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""row no-gutters border mb-4"">
                <div class=""col p-4 d-flex flex-column position-static"">
                    <p class=""card-text mb-auto"">
                        You can add and update your training details
                    </p>
                 </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""row no-gutters border mb-4"">
                <div class=""col p-4 d-flex flex-column"">
                    <p class=""card-text mb-auto"">
                        For checking the traning status.
                    </p>
                 </div>
            </div");
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
