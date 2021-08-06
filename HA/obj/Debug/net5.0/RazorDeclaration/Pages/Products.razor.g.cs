// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\0_Projects\HA\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 3 "D:\0_Projects\HA\HA\Pages\Products.razor"
using HA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\0_Projects\HA\HA\Pages\Products.razor"
using HA.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\0_Projects\HA\HA\Pages\Products.razor"
       
    private List<Product> products;
    private Product product = new();

    protected override async Task OnInitializedAsync()
    {
        products = await productService.GetSomeData();
        //product = new Product { Id = Guid.NewGuid(), Name = "test", Price = 1 };
    }

    public async Task AddProduct()
    {
        product = await productService.AddProduct(product);
        product = new();
        products = await productService.GetSomeData();
    }

    public async Task DeleteProduct(Product product)
    {
        await productService.DeleteProduct(product);
        products = await productService.GetSomeData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
