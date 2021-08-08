#pragma checksum "D:\0_Projects\HA\HA\Pages\RebateManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512e8ec72bde3f1db77bcbf5cfadbcffe92f01c1"
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
#line 5 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
using HA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
using HA.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
           [Authorize(Roles = "admin, retailer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rebate")]
    public partial class RebateManager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Rebate Management</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Here you can manage your customers\' rebates.</p>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                          newRebate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                                                AddRebate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<label>Customer Name</label>\r\n            ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "placeholder", "MyCustomer@gmail.com");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                          newRebate.Customer.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newRebate.Customer.UserName = __value, newRebate.Customer.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<label>Rebate Type</label>\r\n            \r\n            ");
                __builder2.AddMarkupContent(14, "<label>Rebate Percent (%)</label>\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "placeholder", "0");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                          newRebate.RebatePercent

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newRebate.RebatePercent = __value, newRebate.RebatePercent));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n            <input type=\"submit\" value=\"Add rebate\" class=\"btn btn-primary\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
 if (rebates == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p><em>Loading...</em></p>");
#nullable restore
#line 39 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddMarkupContent(23, "<thead><tr><th>Customer Name</th>\r\n                <th>Rebate Value</th></tr></thead>\r\n        ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 51 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
             foreach (var rebate in rebates)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 55 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                         rebate.Customer.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 56 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                         rebate.RebatePercent

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    \r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
                                          (() => DeleteRebate(rebate))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\0_Projects\HA\HA\Pages\RebateManager.razor"
       
    private List<Rebate> rebates;
    private Rebate newRebate = new Rebate { Customer = new ApplicationUser() };

    private ApplicationUser user;


    protected override async Task OnInitializedAsync()
    {
        // get retailer's username
        var authstate = await authenticationStateProvider.GetAuthenticationStateAsync();
        user = await userManager.GetUserAsync(authstate.User);

        rebates = await rebateService.GetAllRetailerRebatesAsync(user.UserName);
    }

    public async Task AddRebate()
    {
        if (!string.IsNullOrEmpty(newRebate.Customer.UserName) && newRebate.RebatePercent > 0 && newRebate.RebatePercent <= 100)
        {
            newRebate.Retailer = user;
            newRebate = await rebateService.AddRebate(newRebate);
            newRebate = new Rebate { Customer = new ApplicationUser() };
            rebates = await rebateService.GetAllRetailerRebatesAsync(user.UserName);
        }
    }

    public async Task DeleteRebate(Rebate rebate)
    {
        await rebateService.DeleteRebate(rebate);
        rebates = await rebateService.GetAllRetailerRebatesAsync(user.UserName);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRebateService rebateService { get; set; }
    }
}
#pragma warning restore 1591
