#pragma checksum "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Views\Shared\Components\ContentComponent\ContentWithID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078fa354628a6cd3d323fdb4b0c7a652833f33a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentComponent_ContentWithID), @"mvc.1.0.view", @"/Views/Shared/Components/ContentComponent/ContentWithID.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ContentComponent/ContentWithID.cshtml", typeof(AspNetCore.Views_Shared_Components_ContentComponent_ContentWithID))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078fa354628a6cd3d323fdb4b0c7a652833f33a9", @"/Views/Shared/Components/ContentComponent/ContentWithID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentComponent_ContentWithID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ayoobifurniture.Core.DTOs.Item_ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(59, 34, false);
#line 3 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Views\Shared\Components\ContentComponent\ContentWithID.cshtml"
Write(Html.Raw(Model.Content.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(93, 7, true);
            WriteLiteral("\r\n \r\n\r\n");
            EndContext();
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ayoobifurniture.Core.DTOs.Item_ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
