#pragma checksum "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263ed7656d7e065411bbacda71fb866976f5fdf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Index), @"mvc.1.0.view", @"/Views/Shared/Index.cshtml")]
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
#line 1 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\_ViewImports.cshtml"
using BlessTrading.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\_ViewImports.cshtml"
using BlessTrading.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263ed7656d7e065411bbacda71fb866976f5fdf4", @"/Views/Shared/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d36d08325e7678d47650d926c9fe921cb3dbe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cardicons.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "PayPal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Visa Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Master Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "American Express", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("creditly-card-form agileinfo_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!--checkout-->
<section class=""banner-bottom-wthreelayouts py-lg-5 py-3"">
    <div class=""container"">
        <script>
                function wcqib_refresh_quantity_increments() {
                    jQuery(""div.quantity:not(.buttons_added), td.quantity:not(.buttons_added)"").each(function (a, b) {
                        var c = jQuery(b);
                        c.addClass(""buttons_added""), c.children().first().before('<input type=""button"" value=""-"" class=""minus"" />'), c.children().last().after('<input type=""button"" value=""+"" class=""plus"" />')
                    })
                }
                String.prototype.getDecimals || (String.prototype.getDecimals = function () {
                    var a = this,
                        b = ("""" + a).match(/(?:\.(\d+))?(?:[eE]([+-]?\d+))?$/);
                    return b ? Math.max(0, (b[1] ? b[1].length : 0) - (b[2] ? +b[2] : 0)) : 0
                }), jQuery(document).ready(function () {
                    wcqib_refresh_quantity_incremen");
            WriteLiteral(@"ts()
                }), jQuery(document).on(""updated_wc_div"", function () {
                    wcqib_refresh_quantity_increments()
                }), jQuery(document).on(""click"", "".plus, .minus"", function () {
                    var a = jQuery(this).closest("".quantity"").find("".qty""),
                        b = parseFloat(a.val()),
                        c = parseFloat(a.attr(""max"")),
                        d = parseFloat(a.attr(""min"")),
                        e = a.attr(""step"");
                    b && """" !== b && ""NaN"" !== b || (b = 0), """" !== c && ""NaN"" !== c || (c = """"), """" !== d && ""NaN"" !== d || (d = 0), ""any"" !== e && """" !== e && void 0 !== e && ""NaN"" !== parseFloat(e) || (e = 1), jQuery(this).is("".plus"") ? c && b >= c ? a.val(c) : a.val((b + parseFloat(e)).toFixed(e.getDecimals())) : d && b <= d ? a.val(d) : b > 0 && a.val((b - parseFloat(e)).toFixed(e.getDecimals())), a.trigger(""change"")
                });
        </script>
");
#nullable restore
#line 28 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
         if (Model != null)
        {
            int count = 0;
            int sum = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""modal-body"">
                <div class=""login_wrap"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12"">
                            <div class=""form-group"">
                                <h2><span>Your shopping cart contains: </span></h2>
                            </div>

                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th style=""font-size:14px"">Id</th>
                                        <th style=""font-size:14px"">Name</th>
                                        <th style=""font-size:14px"">Price color</th>
                                        <th style=""font-size:14px"">Quantity</th>
                                        <th style=""font-size:14px"">Remove</th>
                                    </tr>
                                </thead>
                                <t");
            WriteLiteral("body>\r\n");
#nullable restore
#line 52 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                     foreach (var item in Model)
                                    {

                                        sum = Convert.ToInt32(@item.Price) + sum;
                                        count = count + 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 59 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 60 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td> ");
#nullable restore
#line 61 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>&nbsp;</td>\r\n                                            <td>&nbsp;</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 65 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"4\" class=\"text-right\"><b>Total: $");
#nullable restore
#line 68 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                                                                 Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                        <td colspan=\"5\" class=\"text-left\">\r\n                                            <b>Total: ");
#nullable restore
#line 70 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                                 Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n");
            WriteLiteral(@"                                        </td>
                                    </tr>

                                </tbody>
                            </table>
                            <script>
                                function checkUserLogin() {
                                    alert('call checkuserlogin');
                                    $.ajax({
");
            WriteLiteral("                                         url: \"");
#nullable restore
#line 83 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
                                          Write(Url.Action("CheckOut", "Carts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                              , success: function (result) {\r\n");
            WriteLiteral(@"
                                           }
                                            , error: function (result) {
                                                alert(""err "" + result.responseText);
                                            }
                                        })

                                }
                            </script>
                        </div>

");
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 102 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"inner-sec-shop px-lg-4 px-3\">\r\n            <div class=\"pay_info\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263ed7656d7e065411bbacda71fb866976f5fdf413663", async() => {
                WriteLiteral(@"
                    <section class=""creditly-wrapper wthree, w3_agileits_wrapper"">
                        <div class=""credit-card-wrapper"">
                            <div class=""first-row form-group"">
                                <div class=""controls"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "263ed7656d7e065411bbacda71fb866976f5fdf414228", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <div class=""controls"">
                                    <br />
                                    <label class=""control-label"">Card Type</label>
                                    <select class=""form-control"" name=""CardType"" id=""CardType"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263ed7656d7e065411bbacda71fb866976f5fdf415685", async() => {
                    WriteLiteral("PayPal");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\";\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263ed7656d7e065411bbacda71fb866976f5fdf416952", async() => {
                    WriteLiteral("Visa Card");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\";\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263ed7656d7e065411bbacda71fb866976f5fdf418222", async() => {
                    WriteLiteral("Master Card");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\";\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263ed7656d7e065411bbacda71fb866976f5fdf419494", async() => {
                    WriteLiteral("American Express");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@""";
                                    </select>
                                </div>
                                <div class=""controls"">
                                    <label class=""control-label"">Name on Card</label>
                                    <input class=""billing-address-name form-control"" type=""text"" name=""CardName"" placeholder=""John Smith"">
                                </div>
                                <div class=""w3_agileits_card_number_grids"">
                                    <div class=""w3_agileits_card_number_grid_left"">
                                        <div class=""controls"">
                                            <label class=""control-label"">Card Number</label>
                                            <input class=""number credit-card-number form-control"" type=""text"" name=""CardNumber"" inputmode=""numeric"" autocomplete=""cc-number"" value=""6292400011276686""
                                                   autocompletetype=""cc-number"" x-autocompl");
                WriteLiteral(@"etetype=""cc-number"" placeholder=""&#149;&#149;&#149;&#149; &#149;&#149;&#149;&#149; &#149;&#149;&#149;&#149; &#149;&#149;&#149;&#149;"">
                                        </div>
                                    </div>
                                    <div class=""w3_agileits_card_number_grid_right"">
                                        <div class=""controls"">
                                            <label class=""control-label"">CVV</label>
                                            <input class=""security-code form-control"" ???? inputmode=""numeric"" type=""text"" name=""CardCvv2"" placeholder=""&#149;&#149;&#149;"">
                                        </div>
                                    </div>
                                    <div class=""clear""> </div>
                                </div>
                                <div class=""controls"">
                                    <label class=""control-label"">Expiration Date</label>
                                    <input cla");
                WriteLiteral(@"ss=""expiration-month-and-year form-control"" type=""text"" name=""CardExpiration"" placeholder=""MM / YY"">
                                </div>
                                <div>
                                    <input type=""submit"" value=""Submit"">
                                </div>
                            </div>
                        </div>
                    </section>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 106 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Index.cshtml"
AddHtmlAttributeValue("", 5615, Url.Action("CreateOrder", "Order"), 5615, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--//checkout-->");
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
