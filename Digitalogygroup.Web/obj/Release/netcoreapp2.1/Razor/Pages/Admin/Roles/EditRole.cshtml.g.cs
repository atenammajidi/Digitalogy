#pragma checksum "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207fb8f5ea0f923b69f08c35af8b22fbe65d9140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_EditRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/EditRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/EditRole.cshtml", typeof(AspNetCore.Pages_Admin_Roles_EditRole), @"{id}")]
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
#line 2 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
using Ayoobifurniture.DataLayer.Entities.Permissions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207fb8f5ea0f923b69f08c35af8b22fbe65d9140", @"/Pages/Admin/Roles/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_EditRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
  
    ViewData["Title"] = "ویرایش نقش";
    List<Tbl_Permission> permissions = ViewData["Permissions"] as List<Tbl_Permission>;


#line default
#line hidden
            BeginContext(268, 170, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">ویرایش نقش</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(438, 3884, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "594a7ba7ae2f4841a5fbe4cf0be01405", async() => {
                BeginContext(488, 158, true);
                WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            <div class=\"panel panel-success\">\r\n                <div class=\"panel-heading\">\r\n                    ویرایش نقش \"");
                EndContext();
                BeginContext(647, 22, false);
#line 23 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                           Write(Model.Role.RoleTitleFa);

#line default
#line hidden
                EndContext();
                BeginContext(669, 131, true);
                WriteLiteral("\"\r\n                </div>\r\n                <!-- /.panel-heading -->\r\n                <div class=\"panel-body\">\r\n                    ");
                EndContext();
                BeginContext(800, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f52c564f59545139c506e0632153832", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 27 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(841, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(863, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd16744747e41358574ba65dc49a691", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.IsDelete);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(910, 128, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label>عنوان فارسی نقش</label>\r\n                        ");
                EndContext();
                BeginContext(1038, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bab6e817bf5048ef8e9454489c7c9802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 31 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitleFa);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1105, 158, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>عنوان انگلیسی نقش</label>\r\n                        ");
                EndContext();
                BeginContext(1263, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f5a0c69988d4a37b7457a424964833d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 35 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitleEn);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1330, 490, true);
                WriteLiteral(@"
                    </div>

                    <input type=""submit"" value=""ذخیره اطلاعات"" class=""btn btn-success"" />
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
");
                EndContext();
#line 50 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                      
                        List<int> SelectedPermissions = ViewData["SelectedPermissions"] as List<int>;
                    

#line default
#line hidden
                BeginContext(1970, 26, true);
                WriteLiteral("                    <ul>\r\n");
                EndContext();
#line 54 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
                BeginContext(2120, 115, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\" ");
                EndContext();
                BeginContext(2237, 77, false);
#line 57 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                             Write((SelectedPermissions.Any(p => p == permission.PermissionId) ? "checked" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(2315, 8, true);
                WriteLiteral(" value=\"");
                EndContext();
                BeginContext(2324, 23, false);
#line 57 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                    Write(permission.PermissionId);

#line default
#line hidden
                EndContext();
                BeginContext(2347, 5, true);
                WriteLiteral("\" /> ");
                EndContext();
                BeginContext(2353, 26, false);
#line 57 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                 Write(permission.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2379, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 59 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                 if (permissions.Any(p => p.ParentID == permission.ParentID))
                                {

#line default
#line hidden
                BeginContext(2513, 42, true);
                WriteLiteral("                                    <ul>\r\n");
                EndContext();
#line 62 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                        {

#line default
#line hidden
                BeginContext(2723, 121, true);
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" ");
                EndContext();
                BeginContext(2846, 70, false);
#line 65 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                   Write((SelectedPermissions.Any(p => p == sub.PermissionId) ? "checked" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(2917, 34, true);
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
                EndContext();
                BeginContext(2952, 16, false);
#line 65 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                             Write(sub.PermissionId);

#line default
#line hidden
                EndContext();
                BeginContext(2968, 5, true);
                WriteLiteral("\" /> ");
                EndContext();
                BeginContext(2974, 19, false);
#line 65 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                   Write(sub.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2993, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 66 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                 if (permissions.Any(p => p.ParentID == sub.ParentID))
                                                {

#line default
#line hidden
                BeginContext(3150, 60, true);
                WriteLiteral("                                                    <ul>\r\n\r\n");
                EndContext();
#line 70 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                        {

#line default
#line hidden
                BeginContext(3404, 153, true);
                WriteLiteral("                                                            <li>\r\n                                                                <input type=\"checkbox\" ");
                EndContext();
                BeginContext(3559, 71, false);
#line 73 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                   Write((SelectedPermissions.Any(p => p == sub2.PermissionId) ? "checked" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(3631, 34, true);
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
                EndContext();
                BeginContext(3666, 17, false);
#line 73 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                              Write(sub2.PermissionId);

#line default
#line hidden
                EndContext();
                BeginContext(3683, 5, true);
                WriteLiteral("\" /> ");
                EndContext();
                BeginContext(3689, 20, false);
#line 73 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                                     Write(sub2.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(3709, 69, true);
                WriteLiteral("\r\n                                                            </li>\r\n");
                EndContext();
#line 75 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(3837, 59, true);
                WriteLiteral("                                                    </ul>\r\n");
                EndContext();
#line 77 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                                }

#line default
#line hidden
                BeginContext(3947, 51, true);
                WriteLiteral("                                            </li>\r\n");
                EndContext();
#line 79 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4041, 43, true);
                WriteLiteral("                                    </ul>\r\n");
                EndContext();
#line 81 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                                }

#line default
#line hidden
                BeginContext(4119, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 83 "D:\mahmodkhani\Ayoobifurniture\Ayoobifurniture.Web\Pages\Admin\Roles\EditRole.cshtml"
                        }

#line default
#line hidden
                BeginContext(4181, 134, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4322, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ayoobifurniture.Web.Pages.Admin.Roles.EditRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ayoobifurniture.Web.Pages.Admin.Roles.EditRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ayoobifurniture.Web.Pages.Admin.Roles.EditRoleModel>)PageContext?.ViewData;
        public Ayoobifurniture.Web.Pages.Admin.Roles.EditRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
