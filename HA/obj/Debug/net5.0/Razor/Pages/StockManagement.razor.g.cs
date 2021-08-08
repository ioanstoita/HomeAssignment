#pragma checksum "D:\0_Projects\HA\HA\Pages\StockManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d62fc7e5d306f7dccf3936495ceb98a37a896d"
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
#line 5 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
using HA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
using HA.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
           [Authorize(Roles = "admin, retailer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stock")]
    public partial class StockManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Stock Management</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Here you can manage your products. </p>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                      product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                                          AddProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<label>Product Name</label>\r\n        ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "placeholder", "e.g., Chair");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                      product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Name = __value, product.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label>Product Price</label>\r\n        ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "placeholder", "0");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                      product.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Price = __value, product.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.AddMarkupContent(19, "<label>Standard Price ($)</label>\r\n        ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "checkbox");
                __builder2.AddAttribute(22, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                                      product.StandardPrice

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.StandardPrice = __value, product.StandardPrice));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        <input type=\"submit\" value=\"Add product\" class=\"btn btn-primary\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p><em>Loading...</em></p>");
#nullable restore
#line 33 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table");
            __builder.AddMarkupContent(28, "<thead><tr><th>Name</th>\r\n                <th>Price</th>\r\n                <th>Standard Price</th></tr></thead>\r\n        ");
            __builder.OpenElement(29, "tbody");
#nullable restore
#line 46 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 50 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                     product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 51 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 52 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                     product.StandardPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
                                      (() => DeleteProduct(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\0_Projects\HA\HA\Pages\StockManagement.razor"
       
    private List<Product> products;
    private Product product = new();

    private string username = default!;


    protected override async Task OnInitializedAsync()
    {
        // get retailer's username
        var authstate = await authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authstate.User;
        username = user.Identity.Name;

        products = await productService.GetAllRetailerProductsAsync(username);
    }

    public async Task AddProduct()
    {
        if(!string.IsNullOrEmpty(product.Name) && product.Price > 0)
        {
            product.RetailerName = username;
            product = await productService.AddProduct(product);
            product = new();
            products = await productService.GetAllRetailerProductsAsync(username);
        }
    }

    public async Task DeleteProduct(Product product)
    {
        await productService.DeleteProduct(product);
        products = await productService.GetAllRetailerProductsAsync(username);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
