#pragma checksum "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c4affdc4fc166caca4c5d633d353e20b805ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_SlidShow_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/SlidShow/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/SlidShow/Index.cshtml", typeof(AspNetCore.Pages_Admin_SlidShow_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c4affdc4fc166caca4c5d633d353e20b805ec1", @"/Pages/Admin/SlidShow/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_SlidShow_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(74, 170, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h2 class=\"page-header\">لیست اسلایدشو </h2>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n\r\n");
            EndContext();
            BeginContext(258, 505, true);
            WriteLiteral(@"    <div class=""col-md-8"">
        <div class=""panel panel-success"">

            <div class=""panel-heading"">
                لیست اسلاید شو
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">

                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            ");
            EndContext();
            BeginContext(763, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6093a1d5fb445e4ab835d53deb5844a", async() => {
                BeginContext(820, 19, true);
                WriteLiteral("افزودن اسلاید  جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(843, 36, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n");
            EndContext();
            BeginContext(1152, 568, true);
            WriteLiteral(@"                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>عنوان</th>
                                    <th>دسته</th>
                                    <th>عملیات</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 48 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                 foreach (var gp in Model.SlidShowList)
                                {

#line default
#line hidden
            BeginContext(1828, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1907, 5, false);
#line 51 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                   Write(gp.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1912, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1960, 8, false);
#line 52 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                   Write(gp.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1968, 51, true);
            WriteLiteral("  </td>\r\n                                    <td>\r\n");
            EndContext();
#line 54 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                           if (gp.Parent == 1)
                                            {

#line default
#line hidden
            BeginContext(2128, 26, true);
            WriteLiteral(" <span>اسلایدر اصلی</span>");
            EndContext();
#line 55 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                                                       }
                                            else if (gp.Parent == 2)
                                            {

#line default
#line hidden
            BeginContext(2272, 26, true);
            WriteLiteral(" <span>اسلایدر راست</span>");
            EndContext();
#line 57 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                                                       }
                                            else if (gp.Parent == 3)
                                            {

#line default
#line hidden
            BeginContext(2416, 24, true);
            WriteLiteral(" <span>اسلایدر چپ</span>");
            EndContext();
#line 59 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                                                     }
                                            else  
                                            {

#line default
#line hidden
            BeginContext(2540, 19, true);
            WriteLiteral(" <span>   - </span>");
            EndContext();
#line 61 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                                                }

#line default
#line hidden
            BeginContext(2563, 127, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2690, "\"", 2724, 2);
            WriteAttributeValue("", 2697, "/Admin/SlidShow/Edit/", 2697, 21, true);
#line 64 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
WriteAttributeValue("", 2718, gp.Id, 2718, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2725, 130, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                            ویرایش\r\n                                        </a>");
            EndContext();
            BeginContext(3068, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 72 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\SlidShow\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3187, 191, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n \r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ayoobifurniture.Web.Pages.Admin.SlidShow.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ayoobifurniture.Web.Pages.Admin.SlidShow.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ayoobifurniture.Web.Pages.Admin.SlidShow.IndexModel>)PageContext?.ViewData;
        public Ayoobifurniture.Web.Pages.Admin.SlidShow.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591