#pragma checksum "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\_content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de349e75a15681e8feb42abe989837f3c7872c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__content), @"mvc.1.0.view", @"/Views/Shared/_content.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_content.cshtml", typeof(AspNetCore.Views_Shared__content))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de349e75a15681e8feb42abe989837f3c7872c18", @"/Views/Shared/_content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Digitalogygroup.Core.DTOs.Item_ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 25, true);
            WriteLiteral("\r\n\r\n<div dir=\"rtl\">\r\n    ");
            EndContext();
            BeginContext(84, 34, false);
#line 5 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Views\Shared\_content.cshtml"
Write(Html.Raw(Model.Content.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(118, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Digitalogygroup.Core.DTOs.Item_ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
