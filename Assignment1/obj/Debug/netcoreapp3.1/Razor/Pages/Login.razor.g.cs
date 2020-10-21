#pragma checksum "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc909d775530a473b98b76a49e224777f2d3bfb"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
using Assignment1.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<label>User name:</label>\r\n            ");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "type", "text");
                __builder2.AddAttribute(9, "placeholder", "user name");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
                                                                    username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<label>Password</label>\r\n            ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "password");
                __builder2.AddAttribute(20, "placeholder", "password");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "style", "color:#ff0000");
                __builder2.AddContent(27, 
#nullable restore
#line 19 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n        ");
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "href", "");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
                             PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "\r\n            Login\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
            }
            ));
            __builder.AddAttribute(34, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "a");
                __builder2.AddAttribute(37, "href", "");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "\r\n            Log out\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        ;
        var user = authState.User;
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        ;
        var user = authState.User;
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
