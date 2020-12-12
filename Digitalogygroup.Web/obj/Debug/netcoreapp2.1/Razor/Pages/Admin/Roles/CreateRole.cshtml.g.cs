#pragma checksum "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d38f0a96fb8ba47ee2787d4ce70824097e717a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_CreateRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/CreateRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/CreateRole.cshtml", typeof(AspNetCore.Pages_Admin_Roles_CreateRole), null)]
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
#line 2 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
using Digitalogygroup.DataLayer.Entities.Permissions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38f0a96fb8ba47ee2787d4ce70824097e717a59", @"/Pages/Admin/Roles/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_CreateRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
  
    ViewData["Title"] = "افزودن نقش";
    List<Tbl_Permission> permissions = ViewData["Permissions"] as List<Tbl_Permission>;


#line default
#line hidden
            BeginContext(261, 177, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">افزودن نقش جدید</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(438, 3595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34da2987b745410692e37bfcf21afe59", async() => {
                BeginContext(488, 385, true);
                WriteLiteral(@"
        <div class=""col-md-8"">
            <div class=""panel panel-success"">
                <div class=""panel-heading"">
                    نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label>عنوان فارسی نقش</label>
                        ");
                EndContext();
                BeginContext(873, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0470e6df84bd4a2798ed15adb14f57eb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 29 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitleFa);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(940, 50, true);
                WriteLiteral("\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(990, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f59d2fd722e4bb38418ecb877439ba3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 31 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitleFa);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1041, 132, true);
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <label>عنوان انگلیسی نقش</label>\r\n                        ");
                EndContext();
                BeginContext(1173, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efed0af41b28497490a7638f14095b27", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 35 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitleEn);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1240, 50, true);
                WriteLiteral("\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(1290, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6200777f23be473c89ec982568e3ba96", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 37 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitleEn);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1341, 596, true);
                WriteLiteral(@"
                    <br />
                    <div class=""form-group"">
                        <input type=""submit"" value=""ذخیره اطلاعات"" class=""btn btn-success"" />
                    </div>
                </div>


                <!-- /.panel-body -->
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    دسترسی های نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <ul>
");
                EndContext();
#line 56 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
                BeginContext(2061, 114, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2175, "\"", 2207, 1);
#line 59 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2183, permission.PermissionId, 2183, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2208, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(2213, 26, false);
#line 59 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                Write(permission.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2239, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 61 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                 if (permissions.Any(p => p.ParentID == permission.ParentID))
                                {

#line default
#line hidden
                BeginContext(2373, 42, true);
                WriteLiteral("                                    <ul>\r\n");
                EndContext();
#line 64 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                        {

#line default
#line hidden
                BeginContext(2583, 146, true);
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2729, "\"", 2754, 1);
#line 67 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2737, sub.PermissionId, 2737, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2755, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(2760, 19, false);
#line 67 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                         Write(sub.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2779, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 68 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                 if (permissions.Any(p => p.ParentID == sub.ParentID))
                                                {

#line default
#line hidden
                BeginContext(2936, 60, true);
                WriteLiteral("                                                    <ul>\r\n\r\n");
                EndContext();
#line 72 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                        {

#line default
#line hidden
                BeginContext(3190, 178, true);
                WriteLiteral("                                                            <li>\r\n                                                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3368, "\"", 3394, 1);
#line 75 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 3376, sub2.PermissionId, 3376, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3395, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(3400, 20, false);
#line 75 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                          Write(sub2.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(3420, 69, true);
                WriteLiteral("\r\n                                                            </li>\r\n");
                EndContext();
#line 77 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(3548, 59, true);
                WriteLiteral("                                                    </ul>\r\n");
                EndContext();
#line 79 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                }

#line default
#line hidden
                BeginContext(3658, 51, true);
                WriteLiteral("                                            </li>\r\n");
                EndContext();
#line 81 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3752, 43, true);
                WriteLiteral("                                    </ul>\r\n");
                EndContext();
#line 83 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                }

#line default
#line hidden
                BeginContext(3830, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 85 "D:\mahmodkhani\Digitalogygroup\Digitalogygroup.Web\Pages\Admin\Roles\CreateRole.cshtml"
                        }

#line default
#line hidden
                BeginContext(3892, 134, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4033, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(4045, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4b2b3223d7e40efa1db11b330e4c443", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4090, 44, true);
            WriteLiteral("\r\n<script src=\"`/js/script.js\"></script>\r\n\r\n");
            EndContext();
            BeginContext(4134, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbef01aa08a42c88fa6ef457512f243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4187, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "489aba4f36c14e72b295b8305de2de8e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4246, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Digitalogygroup.Web.Pages.Admin.Roles.CreateRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Digitalogygroup.Web.Pages.Admin.Roles.CreateRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Digitalogygroup.Web.Pages.Admin.Roles.CreateRoleModel>)PageContext?.ViewData;
        public Digitalogygroup.Web.Pages.Admin.Roles.CreateRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
