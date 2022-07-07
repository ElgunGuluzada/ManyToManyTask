#pragma checksum "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031ff776d8726e3e6bf082f55fc65a0478aa7376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Detail), @"mvc.1.0.view", @"/Views/Book/Detail.cshtml")]
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
#line 1 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\_ViewImports.cshtml"
using ManyToManyTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031ff776d8726e3e6bf082f55fc65a0478aa7376", @"/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f65a1aa4a570b3812842d134ccc356133d736f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n        <li> BookName ");
#nullable restore
#line 8 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n");
#nullable restore
#line 10 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
        foreach (var bookAuthor in Model.BookAuthors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span> ");
#nullable restore
#line 12 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
              Write(bookAuthor.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n            <span>");
#nullable restore
#line 13 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
             Write(bookAuthor.Author.SocialAccount.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n");
#nullable restore
#line 14 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
         foreach (var image in Model.Images)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
             if (image.IsMain)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "031ff776d8726e3e6bf082f55fc65a0478aa73765983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 495, "~/img/", 495, 6, true);
#nullable restore
#line 19 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
AddHtmlAttributeValue("", 501, image.ImageUrl, 501, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  <br />\r\n");
#nullable restore
#line 20 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
         foreach (var g in Model.BookGenres)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <span>");
#nullable restore
#line 24 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
           Write(g.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  \r\n");
#nullable restore
#line 25 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Book\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031ff776d8726e3e6bf082f55fc65a0478aa73768567", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <hr />\r\n    \r\n</ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591