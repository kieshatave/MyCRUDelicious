#pragma checksum "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8fc37835de46c72835323eb765dec130e681a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\_ViewImports.cshtml"
using MyCrudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
using MyCRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fc37835de46c72835323eb765dec130e681a93", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2999a8c7dc962dfa58f8021b109c550137bd2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to CRUDelicious</h1>
    <a href=""newDish"">Add a Dish</a>
    <h2>Check out some recent dishes!</h2>
    <table>
        <tr>
            <th>Dish</th>
            <th>Chef</th>
        </tr>
");
#nullable restore
#line 17 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
         foreach(Dish food in ViewBag.AllDishes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 498, "\"", 523, 2);
            WriteAttributeValue("", 505, "/dish/", 505, 6, true);
#nullable restore
#line 20 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 511, food.DishId, 511, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
                                            Write(food.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
               Write(food.ChefName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\kiesh\Google Drive\WOS\Coding-Dojo\ASP\MyCRUDelicious\MyCRUDelicious\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
