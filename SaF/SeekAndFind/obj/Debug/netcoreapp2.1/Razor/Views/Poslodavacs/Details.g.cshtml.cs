#pragma checksum "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1209d791d70465033bd53f309ca1f1636d0b355f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poslodavacs_Details), @"mvc.1.0.view", @"/Views/Poslodavacs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Poslodavacs/Details.cshtml", typeof(AspNetCore.Views_Poslodavacs_Details))]
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
#line 1 "D:\4.semestar\Saf\SeekAndFind\Views\_ViewImports.cshtml"
using SeekAndFind;

#line default
#line hidden
#line 2 "D:\4.semestar\Saf\SeekAndFind\Views\_ViewImports.cshtml"
using SeekAndFind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1209d791d70465033bd53f309ca1f1636d0b355f", @"/Views/Poslodavacs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2514b68f46f48dcc3e214a51abce349e0c29d5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Poslodavacs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeekAndFind.Models.Poslodavac>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
 if (SeekAndFind.Controllers.HomeController.prijavljenaOsoba is Poslodavac &&
SeekAndFind.Controllers.HomeController.prijavljenaOsoba.KorisnikId == @Model.KorisnikId)
{

#line default
#line hidden
            BeginContext(257, 21, true);
            WriteLiteral("    <h2>Profil</h2>\r\n");
            EndContext();
#line 11 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"


}
else
{

#line default
#line hidden
            BeginContext(294, 34, true);
            WriteLiteral("    <h2>Podaci o poslodavcu</h2>\r\n");
            EndContext();
#line 17 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
}

#line default
#line hidden
            BeginContext(331, 104, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Poslodavac</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(436, 41, false);
#line 24 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(521, 37, false);
#line 27 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(602, 47, false);
#line 30 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OPoslodavcu));

#line default
#line hidden
            EndContext();
            BeginContext(649, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(693, 43, false);
#line 33 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayFor(model => model.OPoslodavcu));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(780, 43, false);
#line 36 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Detalji));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(867, 39, false);
#line 39 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Detalji));

#line default
#line hidden
            EndContext();
            BeginContext(906, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(950, 43, false);
#line 42 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
            EndContext();
            BeginContext(993, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1037, 39, false);
#line 45 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefon));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 41, false);
#line 48 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1205, 37, false);
#line 51 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1286, 40, false);
#line 54 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grad));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1370, 36, false);
#line 57 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Grad));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 36, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
            EndContext();
#line 61 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
 if (SeekAndFind.Controllers.HomeController.prijavljenaOsoba is Poslodavac &&
SeekAndFind.Controllers.HomeController.prijavljenaOsoba.KorisnikId == @Model.KorisnikId)
{

#line default
#line hidden
            BeginContext(1614, 24, true);
            WriteLiteral("    <div>\r\n        <li> ");
            EndContext();
            BeginContext(1638, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfba9fecfff04eb68672d6c96edb212c", async() => {
                BeginContext(1692, 12, true);
                WriteLiteral("Uredi profil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
                                    WriteLiteral(Model.KorisnikId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1708, 43, true);
            WriteLiteral(" </li> \r\n    </div>\r\n    <td>\r\n        <li>");
            EndContext();
            BeginContext(1751, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0ea6c36a3fd49a1b06d93bbef4a52f2", async() => {
                BeginContext(1807, 13, true);
                WriteLiteral("Obriši profil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"
                                     WriteLiteral(Model.KorisnikId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1824, 18, true);
            WriteLiteral("</li>\r\n    </td>\r\n");
            EndContext();
#line 70 "D:\4.semestar\Saf\SeekAndFind\Views\Poslodavacs\Details.cshtml"

}

#line default
#line hidden
            BeginContext(1847, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeekAndFind.Models.Poslodavac> Html { get; private set; }
    }
}
#pragma warning restore 1591
