#pragma checksum "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2acc194a8018622a2627a58e226c5fe169dbd0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_register), @"mvc.1.0.view", @"/Views/Shared/register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2acc194a8018622a2627a58e226c5fe169dbd0b", @"/Views/Shared/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d36d08325e7678d47650d926c9fe921cb3dbe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"banner-top\">\r\n    <div class=\"container\">\r\n        <h3>Register</h3>\r\n        <h4><a");
            BeginWriteAttribute("href", " href=\"", 242, "\"", 276, 1);
#nullable restore
#line 11 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\register.cshtml"
WriteAttributeValue("", 249, Url.Action("Index","Home"), 249, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a><label>/ Register</label></h4>
        <div class=""clearfix""> </div>
    </div>
</div>
<div class=""contact"">
    <div class=""container"">
        <div class=""spec "">
            <h3>Register</h3>
            <div class=""ser-t"">
                <b></b>
                <span><i></i></span>
                <b class=""line""></b>
            </div>
        </div>
        <div class="" contact-w3"">
            <div class=""col-md-2 contact-left align-content-center"">

            </div>
            <div class=""col-md-8 contact-left align-content-center"">

                <div id=""container"">
                    <!--Horizontal Tab-->
                    <div id=""parentHorizontalTab"">
                        <div class=""resp-tabs-container hor_1"">
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2acc194a8018622a2627a58e226c5fe169dbd0b4927", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""FirstName"" placeholder=""First Name""");
                BeginWriteAttribute("required", " required=\"", 1523, "\"", 1534, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""LastName"" placeholder=""Last Name""");
                BeginWriteAttribute("required", " required=\"", 1917, "\"", 1928, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""email"" name=""Email"" id=""Email"" placeholder=""Email""");
                BeginWriteAttribute("required", " required=\"", 2316, "\"", 2327, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""city"" id=""city"" placeholder=""City""");
                BeginWriteAttribute("required", " required=\"", 2711, "\"", 2722, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""password"" id=""password"" name=""password"" placeholder=""Password""");
                BeginWriteAttribute("required", " required=\"", 3122, "\"", 3133, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""password"" name=""password1"" id=""password1"" placeholder=""Confirm Password""");
                BeginWriteAttribute("required", " required=\"", 3543, "\"", 3554, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""StreetAddress1"" id=""StreetAddress1"" placeholder=""Street Address 1""");
                BeginWriteAttribute("required", " required=\"", 3970, "\"", 3981, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""Street Address2"" id=""StreetAddress2"" placeholder=""Street Address2""");
                BeginWriteAttribute("required", " required=\"", 4397, "\"", 4408, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""phoneno"" id=""phoneno"" placeholder=""Phone No""");
                BeginWriteAttribute("required", " required=\"", 4802, "\"", 4813, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left col-xs-4"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" name=""ZipCode"" id=""ZipCode"" placeholder=""Zip Code""");
                BeginWriteAttribute("required", " required=\"", 5207, "\"", 5218, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                        <div class=""col-md-6 con-left"">
                                            <input type=""submit"" value=""Submit"">
                                        </div>
                                            
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\register.cshtml"
AddHtmlAttributeValue("", 1137, Url.Action("Create", "Account"), 1137, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>

                <!--Plug-in Initialisation-->
                <script type=""text/javascript"">
                    $(document).ready(function () {
                        //Horizontal Tab
                        $('#parentHorizontalTab').easyResponsiveTabs({
                            type: 'default', //Types: default, vertical, accordion
                            width: 'auto', //auto or any width like 600px
                            fit: true, // 100% fit in a container
                            tabidentify: 'hor_1', // The tab groups identifier
                            activate: function (event) { // Callback function if tab is switched
                                var $tab = $(this);
                                var $info = $('#nested-tabInfo');
                                var $name = $('span', $info);
                                $name.text($tab.te");
            WriteLiteral(@"xt());
                                $info.show();
                            }
                        });

                        // Child Tab
                        $('#ChildVerticalTab_1').easyResponsiveTabs({
                            type: 'vertical',
                            width: 'auto',
                            fit: true,
                            tabidentify: 'ver_1', // The tab groups identifier
                            activetab_bg: '#fff', // background color for active tabs in this group
                            inactive_bg: '#F5F5F5', // background color for inactive tabs in this group
                            active_border_color: '#c1c1c1', // border color for active tabs heads in this group
                            active_content_border_color: '#5AB1D0' // border color for active tabs contect in this group so that it matches the tab head border
                        });

                        //Vertical Tab
                        $('#parentVe");
            WriteLiteral(@"rticalTab').easyResponsiveTabs({
                            type: 'vertical', //Types: default, vertical, accordion
                            width: 'auto', //auto or any width like 600px
                            fit: true, // 100% fit in a container
                            closed: 'accordion', // Start closed if in accordion view
                            tabidentify: 'hor_1', // The tab groups identifier
                            activate: function (event) { // Callback function if tab is switched
                                var $tab = $(this);
                                var $info = $('#nested-tabInfo2');
                                var $name = $('span', $info);
                                $name.text($tab.text());
                                $info.show();
                            }
                        });
                    });
                </script>

            </div>
            <div class=""col-md-2 contact-left align-content-center"">

   ");
            WriteLiteral("         </div>\r\n            <div class=\"clearfix\"></div>\r\n        </div>\r\n    </div>\r\n</div>");
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