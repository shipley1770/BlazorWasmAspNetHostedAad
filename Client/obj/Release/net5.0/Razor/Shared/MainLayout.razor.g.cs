#pragma checksum "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff639898979ddfa6660df5db061f596134b5ca1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasmAspNetHostedAad.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using BlazorWasmAspNetHostedAad.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\_Imports.razor"
using BlazorWasmAspNetHostedAad.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-p6cyxj0cy9");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-p6cyxj0cy9");
            __builder.OpenComponent<BlazorWasmAspNetHostedAad.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-p6cyxj0cy9");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 auth");
            __builder.AddAttribute(13, "b-p6cyxj0cy9");
            __builder.OpenComponent<BlazorWasmAspNetHostedAad.Client.Shared.LoginDisplay>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-p6cyxj0cy9>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-p6cyxj0cy9");
            __builder.AddContent(21, 
#nullable restore
#line 15 "D:\Sandbox\Blazor\ProjectTypes\BlazorWasmAspNetHostedAad\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591