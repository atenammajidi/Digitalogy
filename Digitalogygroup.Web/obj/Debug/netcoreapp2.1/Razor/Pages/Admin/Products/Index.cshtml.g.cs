#pragma checksum "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dafa1b2edd3f26b17264375ee3448aa8712dd99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Products_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Products/Index.cshtml", typeof(AspNetCore.Pages_Admin_Products_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dafa1b2edd3f26b17264375ee3448aa8712dd99", @"/Pages/Admin/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Products_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
  
    ViewData["Title"] = "محصولات";

#line default
#line hidden
            BeginContext(110, 653, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h2 class=""page-header"">لیست محصولات</h2>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">


        <div class=""panel panel-success"">

            <div class=""panel-heading"">
                لیست محصولات
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">




                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            ");
            EndContext();
            BeginContext(763, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e3595b11be942b7b6e758a8a8959e52", async() => {
                BeginContext(827, 17, true);
                WriteLiteral("افزودن محصول جدید");
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
            BeginContext(848, 732, true);
            WriteLiteral(@"

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>نام محصول</th>
                                    <th>نام سرگروه</th>
                                    <th>زبان</th>
                                    <th>شرح کوتاه محصول</th>
                                    <th>وضعیت</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 47 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                 foreach (var gp in Model.VM)
                                {

#line default
#line hidden
            BeginContext(1678, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1765, 15, false);
#line 50 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                       Write(gp.ProductTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1832, 13, false);
#line 51 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                       Write(gp.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1845, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1897, 11, false);
#line 52 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                       Write(gp.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1908, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1960, 16, false);
#line 53 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                       Write(gp.ProdShortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1976, 55, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n\r\n");
            EndContext();
#line 56 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                             if (gp.IsActive)
                                            {

#line default
#line hidden
            BeginContext(2141, 82, true);
            WriteLiteral("                                                <p class=\"text-success\">فعال</p>\r\n");
            EndContext();
#line 59 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2367, 85, true);
            WriteLiteral("                                                <p class=\"text-danger\">غیر فعال</p>\r\n");
            EndContext();
#line 63 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2499, 141, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2640, "\"", 2685, 2);
            WriteAttributeValue("", 2647, "/Admin/Products/EditProduct/", 2647, 28, true);
#line 67 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue("", 2675, gp.ProdID, 2675, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2686, 188, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                                ویرایش\r\n                                            </a>\r\n\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2874, "\"", 2918, 2);
            WriteAttributeValue("", 2881, "/Admin/Products/AddMorePic/", 2881, 27, true);
#line 71 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue("", 2908, gp.ProdID, 2908, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2919, 234, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                                               افزودن تصویر\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 76 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Products\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3188, 186, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Digitalogygroup.Web.Pages.Admin.Products.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Digitalogygroup.Web.Pages.Admin.Products.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Digitalogygroup.Web.Pages.Admin.Products.IndexModel>)PageContext?.ViewData;
        public Digitalogygroup.Web.Pages.Admin.Products.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
