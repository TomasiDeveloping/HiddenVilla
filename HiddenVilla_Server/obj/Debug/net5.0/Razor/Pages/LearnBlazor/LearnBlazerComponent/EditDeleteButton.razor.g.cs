#pragma checksum "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\EditDeleteButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79d5b9734df95117577f218cb1e0dfe3bff1189"
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
    public partial class EditDeleteButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\EditDeleteButton.razor"
 if (IsAdmin)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<input type=\"button\" class=\"btn btn-danger\" value=\"Delete\">\r\n    <input type=\"button\" class=\"btn btn-success\" value=\"Edit\">");
#nullable restore
#line 6 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\EditDeleteButton.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazerComponent\EditDeleteButton.razor"
       
    [Parameter]
    public bool IsAdmin { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
