#pragma checksum "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352c8e29e0c7f237e3897de26789f69ab6683d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oglas_Delete), @"mvc.1.0.view", @"/Views/Oglas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Oglas/Delete.cshtml", typeof(AspNetCore.Views_Oglas_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352c8e29e0c7f237e3897de26789f69ab6683d3f", @"/Views/Oglas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2514b68f46f48dcc3e214a51abce349e0c29d5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Oglas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeekAndFind.Models.Oglas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 103, true);
            WriteLiteral("\r\n<br />\r\n\r\n<h2>Brisanje oglasa</h2>\r\n\r\n<h3>Jeste li sigurni da želite obrisati oglas?</h3>\r\n\r\n<br />\r\n");
            EndContext();
            BeginContext(180, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b345695c00fe478db269af8da152518b", async() => {
                BeginContext(206, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(212, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb7fdf0dd21d42598ea2fbcad2591a25", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 15 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OglasId);

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
                BeginContext(253, 114, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Obriši oglas\" class=\"btn btn-default\" />\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(374, 81, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(456, 45, false);
#line 27 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Zanimanje));

#line default
#line hidden
            EndContext();
            BeginContext(501, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(545, 47, false);
#line 30 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Zanimanje.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(592, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(638, 41, false);
#line 34 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(679, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(723, 37, false);
#line 37 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(760, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(804, 52, false);
#line 40 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Poslodavac.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(856, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(900, 48, false);
#line 43 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Poslodavac.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(948, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(992, 40, false);
#line 46 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1076, 36, false);
#line 49 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1156, 54, false);
#line 52 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumObjavljivanja));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1254, 50, false);
#line 55 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DatumObjavljivanja));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1348, 47, false);
#line 58 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumIsteka));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1439, 43, false);
#line 61 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DatumIsteka));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1526, 44, false);
#line 64 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Aktuelan));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1614, 40, false);
#line 67 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Aktuelan));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1698, 40, false);
#line 70 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Grad));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1782, 36, false);
#line 73 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Grad));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 388, true);
            WriteLiteral(@"
        </dd>
    </dl>
    <div>
        <table class=""table"">
            <thead>
                <tr style=""padding : 5px; text-align:center"">
                    <th>Jezici</th>
                    <th>Fakultet</th>
                    <th>Srednja skola</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
");
            EndContext();
#line 88 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                          
                            foreach (var jezik in Model.JeziciOglasa)
                            {
                                

#line default
#line hidden
            BeginContext(2369, 17, false);
#line 91 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                           Write(jezik.Jezik.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2389, 16, true);
            WriteLiteral(" | Nivo Citanja ");
            EndContext();
            BeginContext(2406, 17, false);
#line 91 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                                                                Write(jezik.NivoCitanja);

#line default
#line hidden
            EndContext();
            BeginContext(2423, 15, true);
            WriteLiteral(", Nivo pisanja ");
            EndContext();
            BeginContext(2439, 17, false);
#line 91 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                                                                                                 Write(jezik.NivoPisanja);

#line default
#line hidden
            EndContext();
            BeginContext(2456, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 92 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2523, 55, true);
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n");
            EndContext();
#line 97 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                          
                            foreach (var fakultet in Model.FakultetiOglasa)
                            {
                                

#line default
#line hidden
            BeginContext(2747, 23, false);
#line 100 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                           Write(fakultet.Fakultet.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(2770, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 101 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2837, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 105 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                          
                            foreach (var srednjaSkola in Model.SrednjaSkolaOglasa)
                            {
                                

#line default
#line hidden
            BeginContext(3066, 31, false);
#line 108 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                           Write(srednjaSkola.SrednjaSkola.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(3097, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 109 "D:\4.semestar\Saf\SeekAndFind\Views\Oglas\Delete.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(3164, 146, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <li>");
            EndContext();
            BeginContext(3310, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bdc8d40fa984f7b91cf3bfa61e2fdee", async() => {
                BeginContext(3332, 21, true);
                WriteLiteral("Nazad na listu oglasa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3357, 15, true);
            WriteLiteral("</li>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeekAndFind.Models.Oglas> Html { get; private set; }
    }
}
#pragma warning restore 1591