#pragma checksum "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d9240c71c21e8a03d1610ab97ac449ac3a55a6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProduct), @"mvc.1.0.view", @"/Views/Product/ShowProduct.cshtml")]
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
#line 1 "A:\Food Shop\Online food\Online food\Views\_ViewImports.cshtml"
using Online_food;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Food Shop\Online food\Online food\Views\_ViewImports.cshtml"
using Online_food.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d9240c71c21e8a03d1610ab97ac449ac3a55a6e", @"/Views/Product/ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4c078f0508331bd74aaae922a97278d90dc722", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductandCategory>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
  
    Layout = "_Pages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- food section -->\r\n\r\n<section class=\"food_section layout_padding-bottom\">\r\n    <div class=\"container\">\r\n        <div class=\"heading_container heading_center\">\r\n            <h2>\r\n                منوی ");
#nullable restore
#line 12 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                Write(ViewData["GroupName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n\r\n <div class=\"row align-content-center justify-content-center\">\r\n");
#nullable restore
#line 17 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"filters_menu\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 551, "\"", 584, 4);
            WriteAttributeValue("", 558, "/Group/", 558, 7, true);
#nullable restore
#line 21 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 565, item.Id, 565, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 573, "/", 573, 1, true);
#nullable restore
#line 21 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 574, item.Name, 574, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 24 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"filters-content\">\r\n            <div class=\"row grid\">\r\n                <div id=\"placeholder\"></div>\r\n");
#nullable restore
#line 30 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                 foreach (var item in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-6 col-lg-4 all burger\">\r\n                        <div class=\"box\">\r\n                            <div>\r\n                                <div class=\"img-box\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1117, "\"", 1149, 3);
            WriteAttributeValue("", 1123, "/images/", 1123, 8, true);
#nullable restore
#line 36 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 1131, item.ItemId, 1131, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1145, ".jpg", 1145, 4, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                </div>\r\n                                <div class=\"detail-box\">\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 40 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 43 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"options\">\r\n                                        <h6>\r\n                                            قیمت: ");
#nullable restore
#line 47 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                                             Write(item.Item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </h6>
                                        <div class=""btn-box"">
                                            <button class=""fa fa-shopping-basket""
                                                    data-toggle=""create"" data-url=""/Home/Details?id=");
#nullable restore
#line 51 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"
                                                                                               Write(item.Item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""modal"" data-target=""#exampleModal"">
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 59 "A:\Food Shop\Online food\Online food\Views\Product\ShowProduct.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div> \r\n        </div>\r\n        <div class=\"btn-box\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2448, "\"", 2455, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                View More\r\n            </a>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- end food section -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var placeholder = $('#placeholder'); 
        $('button[data-toggle=""create""]').click(function () { 
            var url = $(this).data('url');
            console.log(url);
            $.get(url,
                null,
                (data) => {
                    placeholder.html(data);
                    placeholder.find('.modal').modal('show');
                });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductandCategory> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
