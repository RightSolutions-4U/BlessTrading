#pragma checksum "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09677391e7dc1637c5e2ae564b272dc732137049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Single), @"mvc.1.0.view", @"/Views/Shared/Single.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09677391e7dc1637c5e2ae564b272dc732137049", @"/Views/Shared/Single.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d36d08325e7678d47650d926c9fe921cb3dbe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Single : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlessTrading.Common.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frmsingle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.1.1.slim.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
  
    ViewData["Title"] = "Detail Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function changeimage(imgfilename) {
        var image = document.getElementById(""productimage"");
        let src = imgfilename;
        image.src = src.replace(""~"", """");
        document.getElementById(""productimage"").focus();
    }
</script>
<br />
<div class=""banner-top"">
    <div class=""container align-self-center"" style=""width:98%"">
        <h3>Products</h3>
        <h4><a");
            BeginWriteAttribute("href", " href=\"", 507, "\"", 541, 1);
#nullable restore
#line 17 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 514, Url.Action("Index","Home"), 514, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a><label>/</label>Product Details</h4>\r\n        <div class=\"clearfix\"> </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 22 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"row\">\r\n        <div class=\" tab-content tab-content-t \">\r\n            <div class=\"tab-pane active text-style\" id=\"tab1\">\r\n                <div class=\" con-w3l\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09677391e7dc1637c5e2ae564b272dc7321370496039", async() => {
                WriteLiteral("\r\n                    <div class=\"col-md-5 span-2\">\r\n\r\n");
#nullable restore
#line 32 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                         foreach (var p in item.ProductPictureMappings)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1158, "\"", 1196, 1);
#nullable restore
#line 34 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 1164, Url.Content(p.Picture.FileName), 1164, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"productimage\" class=\"img-responsive\"");
                BeginWriteAttribute("alt", " alt=\"", 1238, "\"", 1244, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 35 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <br />\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-8 product-men women_two\">\r\n                                <br />\r\n");
#nullable restore
#line 41 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                 foreach (var item1 in Model)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                     foreach (var p in item1.ProductPictureMappings)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a href=\"#\"");
                BeginWriteAttribute("onmouseover", " onmouseover=\"", 1774, "\"", 1822, 3);
                WriteAttributeValue("", 1788, "changeimage(\'", 1788, 13, true);
#nullable restore
#line 45 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 1801, p.Picture.FileName, 1801, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1820, "\')", 1820, 2, true);
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\'", 1828, "\'", 1866, 1);
#nullable restore
#line 45 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 1834, Url.Content(p.Picture.FileName), 1834, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height:50px;width:50px;\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 1917, "\"", 1923, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n");
#nullable restore
#line 46 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-7 span-1 \">\r\n                        <h3><b>\r\n    ");
#nullable restore
#line 53 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2236, "\"", 2252, 1);
#nullable restore
#line 54 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 2244, item.Id, 2244, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 2294, "\"", 2313, 1);
#nullable restore
#line 55 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue(" ", 2302, item.Name, 2303, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 2356, "\"", 2376, 1);
#nullable restore
#line 56 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue(" ", 2364, item.Price, 2365, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n</b></h3>\r\n                        <p class=\"in-para\">");
#nullable restore
#line 58 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                      Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <div class=\"price_single\">\r\n                            \r\n                            <span class=\"reducedfrom \"><del>Rs.");
#nullable restore
#line 61 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                           Write((int)item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</del> Rs.<em id=\"discount\">");
#nullable restore
#line 61 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                                                                         Write((int)item.Price- item.Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</em></span>
                            <div class=""clearfix""></div>
                        </div>
                        <br />
                        <h4 class=""quick"">Quick Overview:</h4>
                        <br />
                        <p class=""quick_desc""> <label id=""fdescription"">");
#nullable restore
#line 67 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                                   Write(item.FullDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></p>\r\n                        <br />\r\n                        <p>\r\n");
#nullable restore
#line 70 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                              Int32 PrevAtt = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                              Int32 Att = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                              Int32 PrevAtt2 = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                              Int32 Att2 = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                             foreach (var p1 in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                 foreach (var attmap in p1.ProductProductAttributeMappings)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                     foreach (var attval in attmap.ProductAttributeValues)
                                    {
                                        Att = attval.ProductAttributeId;

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                         if (Att != PrevAtt)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <h4 class=\"quick\">");
#nullable restore
#line 84 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                         Write(attval.ProductAttributes.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                            <br />\r\n");
#nullable restore
#line 86 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                             foreach (var attval2 in attmap.ProductAttributeValues)
                                            {
                                                Att2 = attval2.ProductAttributeId;
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                 if (Att2 == Att)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4385, "\"", 4420, 1);
#nullable restore
#line 91 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 4390, attval.ProductAttributes.Name, 4390, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"123\"");
                BeginWriteAttribute("name", "\r\n                                                           name=\"", 4433, "\"", 4530, 1);
#nullable restore
#line 92 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 4500, attval.ProductAttributes.Name, 4500, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4531, "\"", 4552, 1);
#nullable restore
#line 92 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
WriteAttributeValue("", 4539, attval2.Name, 4539, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 93 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                               Write(attval2.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                                 
                                                }
                                                else
                                                {
                                                    break;
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                                 
                                                PrevAtt2 = Att2;
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                         
                                        PrevAtt = Att;

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </p>
                        <input type=""hidden"" name=""txtattributes"" id=""txtattributes"" />
                        <script type=""text/javascript"">
                            function getattributes() {
                                let htmlElements =
                                    document.getElementsByClassName(""123"");
                                for (let i = 0; i < htmlElements.length; i++) {
                                    if (htmlElements[i].checked) {
                                        document.getElementById(""txtattributes"").value = document.getElementById(""txtattributes"").value + htmlElements[i].getAttribute('id') + ': ' + htmlElements[i].getAttribute('value') + '<br />';
                                    }
                                }
                            }
                        </script>
                        <div class=""add-to"">
                            <br />
");
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-danger my-cart-btn my-cart-b \" onclick=\"getattributes();\">Add to Cart</button>\r\n");
                WriteLiteral("                            <button class=\"btn btn-danger my-cart-btn my-cart-b \" onclick=\"history.back()\">Back</button>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"clearfix\"> </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
AddHtmlAttributeValue("", 938, Url.Action("AddCart", "Carts"), 938, 31, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 135 "D:\WorkNew\BlessTrading\Code\BlessTrading\BlessTrading.UI\Views\Shared\Single.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09677391e7dc1637c5e2ae564b272dc73213704923957", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlessTrading.Common.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
