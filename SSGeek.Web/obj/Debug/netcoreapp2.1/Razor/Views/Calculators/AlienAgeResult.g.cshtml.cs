#pragma checksum "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Calculators\AlienAgeResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0e2f9c0362834ccfbb18007711124d47526782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculators_AlienAgeResult), @"mvc.1.0.view", @"/Views/Calculators/AlienAgeResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculators/AlienAgeResult.cshtml", typeof(AspNetCore.Views_Calculators_AlienAgeResult))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0e2f9c0362834ccfbb18007711124d47526782", @"/Views/Calculators/AlienAgeResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61666b4e3e96fdb9425a34c0ec9ec56f57180e64", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculators_AlienAgeResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlienAgeModel>
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
#line 2 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Calculators\AlienAgeResult.cshtml"
  
    ViewData["Title"] = "AlienAgeResult";

#line default
#line hidden
            BeginContext(72, 101, true);
            WriteLiteral("\r\n<h2>AlienAgeResults</h2>\r\n\r\n<section id=\"calculatorResult\" class=\"centeredPanel\">\r\n    <p>\r\n       ");
            EndContext();
            BeginContext(173, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c2a8f40e5a94d02ab2395447ebcf9e5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 183, "~/images/", 183, 9, true);
#line 10 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Calculators\AlienAgeResult.cshtml"
AddHtmlAttributeValue("", 192, Model.EndingAge, 192, 18, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 210, ".jpg", 210, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(216, 30, true);
            WriteLiteral("\r\n    </p>\r\n    <p>If you are ");
            EndContext();
            BeginContext(247, 18, false);
#line 12 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Calculators\AlienAgeResult.cshtml"
             Write(Model.AgeToConvert);

#line default
#line hidden
            EndContext();
            BeginContext(265, 38, true);
            WriteLiteral(" years old on Earth then you would be ");
            EndContext();
            BeginContext(304, 23, false);
#line 12 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Calculators\AlienAgeResult.cshtml"
                                                                      Write(Model.GetConvertedAge());

#line default
#line hidden
            EndContext();
            BeginContext(327, 14, true);
            WriteLiteral(" years old on ");
            EndContext();
            BeginContext(342, 15, false);
#line 12 "C:\Users\Daniel Mueller\Team Exercises\c-week-8-pair-exercises-team-7\34-ssgeek-exercises-pair\SSGeek.Web\Views\Calculators\AlienAgeResult.cshtml"
                                                                                                            Write(Model.EndingAge);

#line default
#line hidden
            EndContext();
            BeginContext(357, 16, true);
            WriteLiteral("</p>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlienAgeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591