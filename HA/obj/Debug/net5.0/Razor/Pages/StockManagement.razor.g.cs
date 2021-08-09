#pragma checksum "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40c1c63536b2db88c8044506dbe523f6ad040c9"
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
#line 1 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using HA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\0\Projects\HomeAssignment\HA\_Imports.razor"
using HA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
using HA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
using HA.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
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
#line 20 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
                      product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
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
#line 22 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
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
#line 24 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
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
#line 26 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
                                      product.IsStandardPrice

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.IsStandardPrice = __value, product.IsStandardPrice));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        <input type=\"submit\" value=\"Add product\" class=\"btn btn-primary\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p><em>Loading...</em></p>");
#nullable restore
#line 35 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
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
#line 48 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 52 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 53 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
                         product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 54 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
                         product.IsStandardPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
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
#line 57 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\0\Projects\HomeAssignment\HA\Pages\StockManagement.razor"
       
    private List<Product> products;
    private Product product = new();

    //private string username = default!;
    private ApplicationUser user;


    protected override async Task OnInitializedAsync()
    {
        // get retailer user object
        var authstate = await authenticationStateProvider.GetAuthenticationStateAsync();
        user = await userManager.GetUserAsync(authstate.User);
        //user = authstate.User;
        //username = user.Identity.Name;

        products = await productService.GetAllRetailerProductsAsync(user.UserName);
    }

    public async Task AddProduct()
    {
        if (!string.IsNullOrEmpty(product.Name) && product.Price > 0)
        {
            product.Retailer = user;
            product = await productService.AddProduct(product);
            product = new();
            products = await productService.GetAllRetailerProductsAsync(user.UserName);
        }
    }

    public async Task DeleteProduct(Product product)
    {
        await productService.DeleteProduct(product);
        products = await productService.GetAllRetailerProductsAsync(user.UserName);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
