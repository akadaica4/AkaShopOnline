#pragma checksum "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d159a784d780cd877976c22f6d500741f43f7c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\_ViewImports.cshtml"
using AkaShop.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\_ViewImports.cshtml"
using AkaShop.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d159a784d780cd877976c22f6d500741f43f7c0", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0670dba3280903dd17180a24f8b537941fac79", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
  
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"breadcrumb\">\r\n    <li><a href=\"/\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c04990", async() => {
                WriteLiteral("Home");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a> <span class=\"divider\">/</span></li>\r\n    <li class=\"active\">");
#nullable restore
#line 13 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
                  Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<div class=\"row\">\r\n    <div id=\"gallery\" class=\"span3\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 552, "\"", 620, 1);
#nullable restore
#line 18 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 559, Configuration["BaseAddress"] + Model.Product.ThumbnailImge, 559, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 621, "\"", 648, 1);
#nullable restore
#line 18 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 629, Model.Product.Name, 629, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 668, "\"", 735, 1);
#nullable restore
#line 19 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 674, Configuration["BaseAddress"] + Model.Product.ThumbnailImge, 674, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%"" alt=""Fujifilm FinePix S2950 Digital Camera"" />
        </a>
        <div id=""differentview"" class=""moreOptopm carousel slide"">
            <div class=""carousel-inner"">
                <div class=""item active"">
                    <a href=""themes/images/products/large/f1.jpg""> <img style=""width:29%"" src=""themes/images/products/large/f1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1102, "\"", 1108, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1249, "\"", 1255, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1396, "\"", 1402, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </div>\r\n                <div class=\"item\">\r\n                    <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1603, "\"", 1609, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f1.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1750, "\"", 1756, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1897, "\"", 1903, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                </div>
            </div>
            <!--
            <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">‹</a>
            <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">›</a>
            -->
        </div>

        <div class=""btn-toolbar"">
            <div class=""btn-group"">
                <span class=""btn""><i class=""icon-envelope""></i></span>
                <span class=""btn""><i class=""icon-print""></i></span>
                <span class=""btn""><i class=""icon-zoom-in""></i></span>
                <span class=""btn""><i class=""icon-star""></i></span>
                <span class=""btn""><i class="" icon-thumbs-up""></i></span>
                <span class=""btn""><i class=""icon-thumbs-down""></i></span>
            </div>
        </div>
    </div>
    <div class=""span6"">
        <h3>");
#nullable restore
#line 52 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <small>");
#nullable restore
#line 53 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
          Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        <hr class=\"soft\" />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c011051", async() => {
                WriteLiteral(@"
            <div class=""control-group"">
                <label class=""control-label""><span>$222.00</span></label>
                <div class=""controls"">
                    <input type=""number"" class=""span1"" placeholder=""Qty."" />
                    <button type=""submit"" class=""btn btn-large btn-primary pull-right""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c011647", async() => {
                    WriteLiteral("Add to");
                }
                );
                __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
                __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <i class=\" icon-shopping-cart\"></i></button>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <hr class=\"soft\" />\r\n        <h4>100 items in stock</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c013922", async() => {
                WriteLiteral("\r\n            <div class=\"control-group\">\r\n                <label class=\"control-label\"><span>Color</span></label>\r\n                <div class=\"controls\">\r\n                    <select class=\"span2\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c014419", async() => {
                    WriteLiteral("Black");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c015457", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c016493", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c017530", async() => {
                    WriteLiteral("Brown");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr class=\"soft clr\" />\r\n        <p>\r\n            ");
#nullable restore
#line 82 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
       Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <a class=\"btn btn-small pull-right\" href=\"#detail\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c020083", async() => {
                WriteLiteral("More Details");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
        <br class=""clr"" />
        <a href=""#"" name=""detail""></a>
        <hr class=""soft"" />
    </div>

    <div class=""span9"">
        <ul id=""productDetail"" class=""nav nav-tabs"">
            <li class=""active""><a href=""#home"" data-toggle=""tab"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c021343", async() => {
                WriteLiteral("Product Details");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n            <li><a href=\"#profile\" data-toggle=\"tab\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c022394", async() => {
                WriteLiteral("Related Products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n        </ul>\r\n        <div id=\"myTabContent\" class=\"tab-content\">\r\n            <div class=\"tab-pane fade active in\" id=\"home\">\r\n                <h4>Product Information</h4>\r\n                ");
#nullable restore
#line 98 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Product\Detail.cshtml"
           Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""tab-pane fade"" id=""profile"">
                <div id=""myTab"" class=""pull-right"">
                    <a href=""#listView"" data-toggle=""tab""><span class=""btn btn-large""><i class=""icon-list""></i></span></a>
                    <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
                </div>
                <br class=""clr"" />
                <hr class=""soft"" />
                <div class=""tab-content"">
                    <div class=""tab-pane"" id=""listView"">
                        <div class=""row"">
                            <div class=""span2"">
                                <img src=""themes/images/products/4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5575, "\"", 5581, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            </div>
                            <div class=""span4"">
                                <h3>New | Available</h3>
                                <hr class=""soft"" />
                                <h5>Product Name </h5>
                                <p>
                                    Nowadays the lingerie industry is one of the most successful business spheres.We always stay in touch with the latest fashion tendencies -
                                    that is why our goods are so popular..
                                </p>
                                <a class=""btn btn-small pull-right"" href=""product_details.html"">View Details</a>
                                <br class=""clr"" />
                            </div>
                            <div class=""span3 alignR"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d159a784d780cd877976c22f6d500741f43f7c025668", async() => {
                WriteLiteral(@"
                                    <h3> $222.00</h3>
                                    <label class=""checkbox"">
                                        <input type=""checkbox"">  Adds product to compair
                                    </label><br />
                                    <div class=""btn-group"">
                                        <a href=""product_details.html"" class=""btn btn-large btn-primary""> Add to <i class="" icon-shopping-cart""></i></a>
                                        <a href=""product_details.html"" class=""btn btn-large""><i class=""icon-zoom-in""></i></a>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                        </div>
                        <hr class=""soft"" />
                    </div>
                    <div class=""tab-pane active"" id=""blockView"">
                        <ul class=""thumbnails"">
                            <li class=""span3"">
                                <div class=""thumbnail"">
                                    <a href=""product_details.html""><img src=""themes/images/products/10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7649, "\"", 7655, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                    <div class=""caption"">
                                        <h5>Manicure &amp; Pedicure</h5>
                                        <p>
                                            Lorem Ipsum is simply dummy text.
                                        </p>
                                        <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">&euro;222.00</a></h4>
                                    </div>
                                </div>
                            </li>
                        </ul>
                        <hr class=""soft"" />
                    </div>
                </div>
                <br class=""clr"">
            </div>
        </div>
    </div>

</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
