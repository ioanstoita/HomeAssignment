#pragma checksum "D:\0_Projects\HA\HA\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a2c4d9c65cfaf1d1c8f6b58eb88bac8501ded8"
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
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\0_Projects\HA\HA\Pages\Products.razor"
                      product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\0_Projects\HA\HA\Pages\Products.razor"
                                          AddProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\0_Projects\HA\HA\Pages\Products.razor"
                      product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Name = __value, product.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\0_Projects\HA\HA\Pages\Products.razor"
                      product.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Price = __value, product.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 21 "D:\0_Projects\HA\HA\Pages\Products.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<p><em>Loading...</em></p>");
#nullable restore
#line 24 "D:\0_Projects\HA\HA\Pages\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddMarkupContent(18, "<thead><tr><th>Id</th>\r\n                <th>Name.</th>\r\n                <th>Price. ($)</th></tr></thead>\r\n        ");
            __builder.OpenElement(19, "tbody");
#nullable restore
#line 36 "D:\0_Projects\HA\HA\Pages\Products.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 39 "D:\0_Projects\HA\HA\Pages\Products.razor"
                         product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 40 "D:\0_Projects\HA\HA\Pages\Products.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 41 "D:\0_Projects\HA\HA\Pages\Products.razor"
                         product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\0_Projects\HA\HA\Pages\Products.razor"
                                          (() => DeleteProduct(product))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\0_Projects\HA\HA\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\0_Projects\HA\HA\Pages\Products.razor"
}

#line default
#line hidden
#nullable disable
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
