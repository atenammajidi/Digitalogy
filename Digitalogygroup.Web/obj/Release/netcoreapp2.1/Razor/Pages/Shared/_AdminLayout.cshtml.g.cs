#pragma checksum "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f339936cd9c776733a93d27200f0904aa76fd8fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__AdminLayout), @"mvc.1.0.view", @"/Pages/Shared/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_AdminLayout.cshtml", typeof(AspNetCore.Pages_Shared__AdminLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f339936cd9c776733a93d27200f0904aa76fd8fb", @"/Pages/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CustomCss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n\r\n");
            EndContext();
            BeginContext(29, 783, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c886bda2df134861b1226b6f906fdce7", async() => {
                BeginContext(35, 700, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <title>پنل مدیریت</title>

    <!-- Core CSS - Include with every page -->
    <link href=""/AdminContent/css/bootstrap-rtl.css"" rel=""stylesheet"">
    <link href=""/AdminContent/font-awesome/css/font-awesome.css"" rel=""stylesheet"">

    <!-- Page-Level Plugin CSS - Dashboard -->
    <link href=""/AdminContent/css/plugins/morris/morris-0.4.3.min.css"" rel=""stylesheet"">
    <link href=""/AdminContent/css/plugins/timeline/timeline.css"" rel=""stylesheet"">

    <!-- SB Admin CSS - Include with every page -->
    <link href=""/AdminContent/css/sb-admin.css"" rel=""stylesheet"">

    ");
                EndContext();
                BeginContext(735, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0790b30556c44f9ac5f2d74e43d0890", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(801, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(816, 5482, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c6a754546f04d05b40b3b23b8b46cb2", async() => {
                BeginContext(822, 848, true);
                WriteLiteral(@"

    <div id=""wrapper"">

        <nav class=""navbar navbar-default navbar-fixed-top"" role=""navigation"" style=""margin-bottom: 0"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".sidebar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""/Admin""></a>
            </div>
            <!-- /.navbar-header -->



            <div class=""navbar-default navbar-static-side"" role=""navigation"">
                <div class=""sidebar-collapse"">
                    <ul class=""nav"" id=""side-menu"">
");
                EndContext();
                BeginContext(2128, 3295, true);
                WriteLiteral(@"
                        <li>
                            <a href=""/Admin""><i class=""fa fa-home"" aria-hidden=""true""></i> پنل ادمین</a>
                        </li>

                        <li>
                            <a href=""#""><i class=""fa fa-user"" aria-hidden=""true""></i> مدیریت کاربران<span class=""fa arrow""></span></a>
                            <ul class=""nav nav-second-level"">
                                <li>
                                    <a href=""/Admin/Roles"">
                                        <i class=""fa fa-hand-paper-o"" aria-hidden=""true""></i>
                                        دسترسی ها
                                    </a>
                                </li>
                                <li>

                                    <a href=""/Admin/ManageUsers"">
                                        <i class=""fa fa-user-circle"" aria-hidden=""true""></i>
                                        کاربران
                                    </a>
      ");
                WriteLiteral(@"                          </li>
                            </ul>
                            <!-- /.nav-second-level -->
                        </li>

                        <li>
                            <a href=""#""><i class=""fa fa-bar-chart-o fa-fw""></i> مدیریت محصولات<span class=""fa arrow""></span></a>
                            <ul class=""nav nav-second-level"">
                                <li>
                                    <a href=""/Admin/Groups""> گروه ها  </a>
                                </li>

                                <li>
                                    <a href=""/Admin/Products"">  محصولات </a>
                                </li>

                            </ul>
                        </li>

                        <li>
                            <a href=""#""><i class=""fa fa-bar-chart-o fa-fw""></i> مدیریت متن های ثابت <span class=""fa arrow""></span></a>
                            <ul class=""nav nav-second-level"">
                                <l");
                WriteLiteral(@"i>
                                    <a href=""/Admin/Content"">متن های ثابت</a>
                                </li>

                            </ul>

                        </li>
                        <li>
                            <a href=""#""><i class=""fa fa-bar-chart-o fa-fw""></i> مدیریت اسلایدشو<span class=""fa arrow""></span></a>
                            <ul class=""nav nav-second-level"">
                                <li>
                                    <a href=""/Admin/SlidShow/Create"">  ایجاد اسلایدشو  </a>
                                </li>

                                <li>
                                    <a href=""/Admin/SlidShow/Index"">  مدیریت اسلایدشو </a>
                                </li>

                            </ul>
                        </li>
                        <li>
                            <a href=""/Logout""><i class=""fa fa-dashboard fa-fw""></i> خروج </a>
                        </li>

                    </ul>
              ");
                WriteLiteral("      <!-- /#side-menu -->\r\n                </div>\r\n                <!-- /.sidebar-collapse -->\r\n            </div>\r\n            <!-- /.navbar-static-side -->\r\n        </nav>\r\n\r\n        <div id=\"page-wrapper\">\r\n            ");
                EndContext();
                BeginContext(5424, 12, false);
#line 133 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5436, 821, true);
                WriteLiteral(@"
        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
    <!-- Core Scripts - Include with every page -->
    <script src=""/AdminContent/js/jquery-1.10.2.js""></script>
    <script src=""/AdminContent/js/bootstrap.min.js""></script>
    <script src=""/AdminContent/js/plugins/metisMenu/jquery.metisMenu.js""></script>

    <!-- Page-Level Plugin Scripts - Dashboard -->
    <script src=""/AdminContent/js/plugins/morris/raphael-2.1.0.min.js""></script>
    <script src=""/AdminContent/js/plugins/morris/morris.js""></script>

    <!-- SB Admin Scripts - Include with every page -->
    <script src=""/AdminContent/js/sb-admin.js""></script>

    <!-- Page-Level Demo Scripts - Dashboard - Use for reference -->
    <script src=""/AdminContent/js/demo/dashboard-demo.js""></script>
    ");
                EndContext();
                BeginContext(6258, 31, false);
#line 153 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Shared\_AdminLayout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(6289, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6298, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
