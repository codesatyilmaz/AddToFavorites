#pragma checksum "D:\Asp.netCoreMVC\AddToFavorites\AddToFavorites.MVC.UI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79bc8dcba9e4be6ea48c8ba54ce2a2ddb1730a55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79bc8dcba9e4be6ea48c8ba54ce2a2ddb1730a55", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8c9ea4dfd2e823d396bb9aefa0fce110fe655b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddToFavorites.MVC.UI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 5 "D:\Asp.netCoreMVC\AddToFavorites\AddToFavorites.MVC.UI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var categories in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 184, "\"", 243, 2);
            WriteAttributeValue("", 191, "/Product/index?categorySelect=", 191, 30, true);
#nullable restore
#line 7 "D:\Asp.netCoreMVC\AddToFavorites\AddToFavorites.MVC.UI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 221, categories.CategoryId, 221, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark\">");
#nullable restore
#line 7 "D:\Asp.netCoreMVC\AddToFavorites\AddToFavorites.MVC.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                                                                Write(categories.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 8 "D:\Asp.netCoreMVC\AddToFavorites\AddToFavorites.MVC.UI\Views\Shared\Components\CategoryList\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddToFavorites.MVC.UI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
