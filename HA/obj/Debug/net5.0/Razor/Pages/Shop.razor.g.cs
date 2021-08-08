#pragma checksum "D:\0_Projects\HA\HA\Pages\Shop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a907e687cd0627d69073bf021140c8c64408c1"
// <auto-generated/>
#pragma warning disable 1591
namespace HA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\0_Projects\HA\HA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\0_Projects\HA\HA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\0_Projects\HA\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\0_Projects\HA\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\0_Projects\HA\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\0_Projects\HA\HA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\0_Projects\HA\HA\_Imports.razor"
using HA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\0_Projects\HA\HA\_Imports.razor"
using HA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\0_Projects\HA\HA\Pages\Shop.razor"
using HA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\0_Projects\HA\HA\Pages\Shop.razor"
using HA.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\0_Projects\HA\HA\Pages\Shop.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\0_Projects\HA\HA\Pages\Shop.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shop")]
    public partial class Shop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Shop</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Here you can buy products from all retailers.</p>\r\n");
            __builder.AddMarkupContent(2, "<p>PS: User cart not implemented...</p>");
#nullable restore
#line 16 "D:\0_Projects\HA\HA\Pages\Shop.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 19 "D:\0_Projects\HA\HA\Pages\Shop.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>Name</th>\r\n                <th>Price</th>\r\n                <th>Retailer</th></tr></thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 32 "D:\0_Projects\HA\HA\Pages\Shop.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 36 "D:\0_Projects\HA\HA\Pages\Shop.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 37 "D:\0_Projects\HA\HA\Pages\Shop.razor"
                          product.RebatePrice > 0 ? (product.RebatePrice + "$ from " + product.Price + "$") : (product.Price + "$")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    \r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 39 "D:\0_Projects\HA\HA\Pages\Shop.razor"
                         product.RetailerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddMarkupContent(18, "<td><button>Add to chart</button></td>");
            __builder.CloseElement();
#nullable restore
#line 42 "D:\0_Projects\HA\HA\Pages\Shop.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "D:\0_Projects\HA\HA\Pages\Shop.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\0_Projects\HA\HA\Pages\Shop.razor"
       
    private List<Product> products;
    private string username = default!;

    protected override async Task OnInitializedAsync()
    {
        // get retailer's username
        var authstate = await authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authstate.User;
        username = user.Identity.Name;

        products = await productService.GetAllProductsAsync(username);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
