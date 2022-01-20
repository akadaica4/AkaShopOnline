#pragma checksum "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f03152aea75410d17e6de3b361443f06159dfbdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03152aea75410d17e6de3b361443f06159dfbdf", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0670dba3280903dd17180a24f8b537941fac79", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AkaShop.ViewModel.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 31 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 936, "\"", 975, 1);
#nullable restore
#line 34 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 943, urlTemplate.Replace("{0}", "1"), 943, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1077, "\"", 1143, 1);
#nullable restore
#line 37 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1084, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1084, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 39 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 45 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 47 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1582, "\"", 1609, 2);
            WriteAttributeValue("", 1590, "Trang", 1590, 5, true);
#nullable restore
#line 50 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1595, i.ToString(), 1596, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1658, 1);
#nullable restore
#line 50 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1617, urlTemplate.Replace("{0}", i.ToString()), 1617, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1828, "\"", 1863, 1);
#nullable restore
#line 56 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1836, Model.PageCount.ToString(), 1836, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1864, "\"", 1930, 1);
#nullable restore
#line 56 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1871, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1871, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2032, "\"", 2094, 1);
#nullable restore
#line 59 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2039, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2039, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 61 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 63 "D:\ProjectSolo\AkaShopOnline\AkaShop.WebApp\AkaShop.WebApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AkaShop.ViewModel.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
