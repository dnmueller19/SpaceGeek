#pragma checksum "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cf3d8d3dc1d1cd8c49aa7f2c52bfdfa670f590f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_ViewCart), @"mvc.1.0.view", @"/Views/Store/ViewCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/ViewCart.cshtml", typeof(AspNetCore.Views_Store_ViewCart))]
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
#line 1 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\_ViewImports.cshtml"
using SSGeek.Web;

#line default
#line hidden
#line 2 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\_ViewImports.cshtml"
using SSGeek.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf3d8d3dc1d1cd8c49aa7f2c52bfdfa670f590f", @"/Views/Store/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61666b4e3e96fdb9425a34c0ec9ec56f57180e64", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(113, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";

#line default
#line hidden
            BeginContext(182, 30, true);
            WriteLiteral("\r\n<h2>ViewCart</h2>\r\n\r\n<div>\r\n");
            EndContext();
#line 11 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
     foreach (var item in Model.Items)
    { 

#line default
#line hidden
            BeginContext(260, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(271, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "383384aa33e344579e67d6757d1f54f0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 281, "~/images/", 281, 9, true);
#line 13 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
AddHtmlAttributeValue("", 290, item.Product.ImageName, 290, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(315, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(333, 17, false);
#line 14 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
      Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(350, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(368, 32, false);
#line 15 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
      Write(item.Product.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(400, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(418, 13, false);
#line 16 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
      Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(431, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(449, 27, false);
#line 17 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
      Write(item.SubTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(476, 62, true);
            WriteLiteral("</p>\r\n        <p></p>\r\n        <p>Grand Total</p>\r\n        <p>");
            EndContext();
            BeginContext(539, 30, false);
#line 20 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"
      Write(Model.GrandTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(569, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Store\ViewCart.cshtml"

    }

#line default
#line hidden
            BeginContext(584, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591