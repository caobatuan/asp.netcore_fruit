#pragma checksum "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d3211d9aadfa76f917e932329f4d93dac28e1c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminTinDangs_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminTinDangs/Delete.cshtml")]
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
#nullable restore
#line 1 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\_ViewImports.cshtml"
using webbanhang_plus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\_ViewImports.cshtml"
using webbanhang_plus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d3211d9aadfa76f917e932329f4d93dac28e1c1", @"/Areas/Admin/Views/AdminTinDangs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184ea98fb6cbc62724d1d33716ce695e1d1e3c54", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminTinDangs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webbanhang_plus.Models.TinDang>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TinDang</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Scontents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Scontents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Alias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Alias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsHot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsHot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsNewfeed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsNewfeed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MetaKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MetaKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MetaDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MetaDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Views));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Views));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3211d9aadfa76f917e932329f4d93dac28e1c116843", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d3211d9aadfa76f917e932329f4d93dac28e1c117110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 114 "D:\.net\.net core api\jwt basic\luyện bài tập\webbanhang_plus\webbanhang_plus\Areas\Admin\Views\AdminTinDangs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3211d9aadfa76f917e932329f4d93dac28e1c118946", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webbanhang_plus.Models.TinDang> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
