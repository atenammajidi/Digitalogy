#pragma checksum "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1e63282bef04f8d2f2c6905aa3136a2afc6c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SlidShowComponent_SliderMain), @"mvc.1.0.view", @"/Views/Shared/Components/SlidShowComponent/SliderMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SlidShowComponent/SliderMain.cshtml", typeof(AspNetCore.Views_Shared_Components_SlidShowComponent_SliderMain))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1e63282bef04f8d2f2c6905aa3136a2afc6c82", @"/Views/Shared/Components/SlidShowComponent/SliderMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SlidShowComponent_SliderMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Digitalogygroup .DataLayer .Entities.Products .Tbl_SlidShow>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 496, true);
            WriteLiteral(@"<div class=""col-lg-12 col-md-12 col-sm-12 visible-lg visible-md visible-sm"">
    <div class=""row visible-lg visible-md visible-sm"" id=""main-slide"">
        <div class=""col-lg-12 col-md-12 col-sm-12 visible-lg visible-md visible-sm no-padding-top no-padding-left no-padding-right"" style=""width: 100%;    height: auto;    max-height: 650px;    position: relative;    overflow: hidden;"">

            <div class=""flexslider14"">
                <ul class=""slides"" style=""min-height: 600px;"">

");
            EndContext();
#line 9 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
                     foreach (var sl in Model)
                    {


#line default
#line hidden
            BeginContext(650, 60, true);
            WriteLiteral("                        <li>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 710, "\"", 725, 1);
#line 13 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
WriteAttributeValue("", 717, sl.Link, 717, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(726, 39, true);
            WriteLiteral(">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 765, "\"", 789, 2);
            WriteAttributeValue("", 771, "/Slid/", 771, 6, true);
#line 14 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
WriteAttributeValue("", 777, sl.ImageUrl, 777, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(790, 93, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                            </a>\r\n                        </li>\r\n");
            EndContext();
#line 17 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
                    }

#line default
#line hidden
            BeginContext(906, 504, true);
            WriteLiteral(@"                     
                </ul>
            </div>
            <!-- Slider End -->
        </div>
    </div>
</div>
<div class="" visible-xs col-xs-12"">
    <div class=""row visible-xs"">
        <div class=""visible-xs col-xs-12 no-padding-top no-padding-left no-padding-right"" style=""width: 100%;    height: auto;    max-height: 400px;    position: relative;    overflow: hidden;"">
            <div class=""camera_wrap"" id=""camera_wrap_5"">
                <!-- Slides Container  -->
");
            EndContext();
#line 30 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
                 foreach (var sl in Model)
                {

#line default
#line hidden
            BeginContext(1473, 41, true);
            WriteLiteral("                    <div data-src=\"/Slid/");
            EndContext();
            BeginContext(1515, 11, false);
#line 32 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
                                    Write(sl.ImageUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1526, 13, true);
            WriteLiteral("\" data-link=\"");
            EndContext();
            BeginContext(1540, 7, false);
#line 32 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
                                                             Write(sl.Link);

#line default
#line hidden
            EndContext();
            BeginContext(1547, 10, true);
            WriteLiteral("\"></div>\r\n");
            EndContext();
#line 33 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\Components\SlidShowComponent\SliderMain.cshtml"
                }

#line default
#line hidden
            BeginContext(1576, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Digitalogygroup .DataLayer .Entities.Products .Tbl_SlidShow>> Html { get; private set; }
    }
}
#pragma warning restore 1591
