#pragma checksum "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3fd1e78ad2bcc1d67538d766a5d9730c4151d3"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazerComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazerComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-info");
            __builder.AddContent(3, 
#nullable restore
#line 4 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
                                   Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "alert alert-success");
#nullable restore
#line 6 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
         if (DangerChildContent == null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
             if (ChildContent == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<span>Hello, from Empty Render Fragement</span>");
#nullable restore
#line 11 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "span");
            __builder.AddContent(9, 
#nullable restore
#line 14 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
                       ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 19 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
                   DangerChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-danger");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
                                              OnClickBtnMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Button to be clicked!");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    \r\n    ");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazerComponent.GrandChildComponent>(18);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\ChildComponent.razor"
       
    [Parameter]
    public string Title { get; set; }
    
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public RenderFragment DangerChildContent { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> OnClickBtnMethod { get; set; }

    public async Task ShowToastrSuccess()
    {
        await JsRuntime.ToastrSucces("Woohoo! Success is on its way!");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591