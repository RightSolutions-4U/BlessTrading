#pragma checksum "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385863a7ac5900e1a32bb6c46e72413662c6a158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Admin_Admin), @"mvc.1.0.view", @"/Views/Shared/Admin/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"385863a7ac5900e1a32bb6c46e72413662c6a158", @"/Views/Shared/Admin/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d36d08325e7678d47650d926c9fe921cb3dbe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385863a7ac5900e1a32bb6c46e72413662c6a1583516", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 9 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385863a7ac5900e1a32bb6c46e72413662c6a1584861", async() => {
                WriteLiteral("\r\n    <header>\r\n        <div class=\"header\">\r\n\r\n            <div class=\"container\">\r\n\r\n                <div class=\"logo\">\r\n                    <h1><a");
                BeginWriteAttribute("href", " href=\"", 395, "\"", 429, 1);
#nullable restore
#line 18 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 402, Url.Action("Index","Home"), 402, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><img src=""images/logo.jpeg""><span>We Deal In Health Care, Well Being & House Hold Products</span></a></h1>
                </div>
                <div class=""head-t"">
                    <ul class=""card"">
                        <li><a href=""wishlist.html""><i class=""fa fa-heart"" aria-hidden=""true""></i>Wishlist</a></li>
                        <li><a href=""login.html""><i class=""fa fa-user"" aria-hidden=""true""></i>Login</a></li>
                        <li><a href=""register.html""><i class=""fa fa-arrow-right"" aria-hidden=""true""></i>Register</a></li>
                        <li><a href=""about.html""><i class=""fa fa-file-text-o"" aria-hidden=""true""></i>Order History</a></li>
                        <li><a href=""shipping.html""><i class=""fa fa-ship"" aria-hidden=""true""></i>Shipping</a></li>
                    </ul>
                </div>

                <div class=""header-ri"">
                    <ul class=""social-top"">
                        <li><a href=""https://www.facebook.com/Bless-Trading-10666984");
                WriteLiteral(@"5153286/"" class=""icon facebook""><i class=""fa fa-facebook"" aria-hidden=""true""></i><span></span></a></li>
                        <li><a href=""#"" class=""icon twitter""><i class=""fa fa-twitter"" aria-hidden=""true""></i><span></span></a></li>
                        <li><a href=""#"" class=""icon pinterest""><i class=""fa fa-pinterest-p"" aria-hidden=""true""></i><span></span></a></li>
                        <li><a href=""#"" class=""icon dribbble""><i class=""fa fa-dribbble"" aria-hidden=""true""></i><span></span></a></li>
                    </ul>
                </div>


                <div class=""nav-top"">
                    <nav class=""navbar navbar-default"">

                        <div class=""navbar-header nav_2"">
                            <button type=""button"" class=""navbar-toggle collapsed navbar-toggle1"" data-toggle=""collapse"" data-target=""#bs-megadropdown-tabs"">
                                <span class=""sr-only"">Toggle navigation</span>
                                <span class=""icon-bar""></span>");
                WriteLiteral(@"
                                <span class=""icon-bar""></span>
                                <span class=""icon-bar""></span>
                            </button>


                        </div>
                        <div class=""collapse navbar-collapse"" id=""bs-megadropdown-tabs"">
                            <ul class=""nav navbar-nav "">
                                <li class="" active""><a");
                BeginWriteAttribute("href", " href=\"", 2885, "\"", 2919, 1);
#nullable restore
#line 55 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 2892, Url.Action("Index","Home"), 2892, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""hyper ""><span>Home</span></a></li>

                                <li class=""dropdown "">
                                    <a href=""#"" class=""dropdown-toggle  hyper"" data-toggle=""dropdown""><span>Kitchen & Household<b class=""caret""></b></span></a>
                                    <ul class=""dropdown-menu multi"">
                                        <div class=""row"">
                                            <div class=""col-sm-3"">
                                                <ul class=""multi-column-dropdown"">

                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 3524, "\"", 3584, 1);
#nullable restore
#line 64 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 3531, Url.Action("ByCategory","Product",  new { id = 1 } ), 3531, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Water & Beverages</a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 3724, "\"", 3784, 1);
#nullable restore
#line 65 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 3731, Url.Action("ByCategory","Product",  new { id = 2 } ), 3731, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Fruits & Vegetables</a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 3926, "\"", 3986, 1);
#nullable restore
#line 66 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 3933, Url.Action("ByCategory","Product",  new { id = 3 } ), 3933, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Staples</a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 4117, "\"", 4177, 1);
#nullable restore
#line 67 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 4124, Url.Action("ByCategory","Product",  new { id = 4 } ), 4124, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-angle-right"" aria-hidden=""true""></i>Branded Food</a></li>

                                                </ul>

                                            </div>
                                            <div class=""col-sm-3"">

");
                WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"col-sm-3\">\r\n\r\n");
                WriteLiteral("                                            </div>\r\n                                            <div class=\"col-sm-3 w3l\">\r\n                                                <a href=\"#\"><img src=\"images/me.png\" class=\"img-responsive\"");
                BeginWriteAttribute("alt", " alt=\"", 6517, "\"", 6523, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </ul>
                                </li>
                                <li class=""dropdown"">

                                    <a href=""#"" class=""dropdown-toggle hyper"" data-toggle=""dropdown""><span> Healthcare <b class=""caret""></b></span></a>
                                    <ul class=""dropdown-menu multi multi1"">
                                        <div class=""row"">
                                            <div class=""col-sm-3"">
                                                <ul class=""multi-column-dropdown"">
                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 7343, "\"", 7402, 1);
#nullable restore
#line 108 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 7350, Url.Action("ByCategory","Product",  new { id = 5 }), 7350, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i> Blood Pressure</a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 7540, "\"", 7599, 1);
#nullable restore
#line 109 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 7547, Url.Action("ByCategory","Product",  new { id = 6 }), 7547, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i> Respiratory Care </a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 7740, "\"", 7799, 1);
#nullable restore
#line 110 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 7747, Url.Action("ByCategory","Product",  new { id = 7 }), 7747, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Baby Care</a></li>\r\n                                                </ul>\r\n\r\n                                            </div>\r\n                                            <div class=\"col-sm-3\">\r\n\r\n");
                WriteLiteral("                                            </div>\r\n                                            <div class=\"col-sm-3\">\r\n\r\n");
                WriteLiteral("                                            </div>\r\n                                            <div class=\"col-sm-3 w3l\">\r\n                                                <a href=\"#\"><img src=\"images/me1.png\" class=\"img-responsive\"");
                BeginWriteAttribute("alt", " alt=\"", 10150, "\"", 10156, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </ul>
                                </li>
                                <li class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle hyper"" data-toggle=""dropdown""><span>ATTIRE<b class=""caret""></b></span></a>
                                    <ul class=""dropdown-menu multi multi2"">
                                        <div class=""row"">
                                            <div class=""col-sm-3"">
                                                <ul class=""multi-column-dropdown"">
                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 10968, "\"", 11027, 1);
#nullable restore
#line 149 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 10975, Url.Action("ByCategory","Product",  new { id = 8 }), 10975, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Men</a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 11153, "\"", 11212, 1);
#nullable restore
#line 150 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 11160, Url.Action("ByCategory","Product",  new { id = 9 }), 11160, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Women</a></li>\r\n                                                </ul>\r\n                                            </div>\r\n                                            <div class=\"col-sm-3\">\r\n\r\n");
                WriteLiteral("                                            </div>\r\n                                            <div class=\"col-sm-3\">\r\n\r\n");
                WriteLiteral("                                            </div>\r\n                                            <div class=\"col-sm-3 w3l\">\r\n                                                <a href=\"#\"><img src=\"images/me2.png\" class=\"img-responsive\"");
                BeginWriteAttribute("alt", " alt=\"", 13504, "\"", 13510, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </ul>
                                </li>

                                <li class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle hyper"" data-toggle=""dropdown""><span>BAGS & SHOES<b class=""caret""></b></span></a>
                                    <ul class=""dropdown-menu multi multi2"">
                                        <div class=""row"">
                                            <div class=""col-sm-3"">
                                                <ul class=""multi-column-dropdown"">
                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 14330, "\"", 14390, 1);
#nullable restore
#line 188 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 14337, Url.Action("ByCategory","Product",  new { id = 10 }), 14337, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>Bags</a></li>\r\n                                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 14517, "\"", 14577, 1);
#nullable restore
#line 189 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Admin\Admin.cshtml"
WriteAttributeValue("", 14524, Url.Action("ByCategory","Product",  new { id = 11 }), 14524, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-angle-right"" aria-hidden=""true""></i>Shoes</a></li>
                                                </ul>
                                            </div>
                                            <div class=""col-sm-3"">
                                            </div>
                                            <div class=""col-sm-3 w3l"">
                                                <a href=""#""><img src=""images/me2.png"" class=""img-responsive""");
                BeginWriteAttribute("alt", " alt=\"", 15054, "\"", 15060, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </ul>
                                </li>
");
                WriteLiteral(@"                                <li><a href=""contact.html"" class=""hyper""><span>Contact Us</span></a></li>
                            </ul>
                        </div>
                    </nav>
                    <div class=""cart"">

                        <span class=""fa fa-shopping-cart my-cart-icon""><span class=""badge badge-notify my-cart-badge""></span></span>
                    </div>
                    <div class=""clearfix""></div>
                </div>

            </div>
        </div>
        <script>window.jQuery || document.write('<script src=""js/vendor/jquery-1.11.1.min.js""><\/script>')</script>
        <script src=""js/jquery.vide.min.js""></script>
    </header>
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            asdhjkasdkahjkhaskhdjk
        </main>
    </div>

    <!--footer-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
