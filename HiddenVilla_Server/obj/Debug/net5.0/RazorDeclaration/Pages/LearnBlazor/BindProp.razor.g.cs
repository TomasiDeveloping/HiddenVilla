// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.LearnBlazor
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
#nullable restore
#line 13 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindprop")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
 
    string SelectedRoomProp = "";
    List<BlazorRoom> RoomList = new List<BlazorRoom>();
    Model.BlazorRoom Room = new BlazorRoom()
    {
        Id = 201,
        Price = 399,
        IsActive = true,
        RoomName = "Villa Suite One Bed Room",
        RoomProps = new List<BlazorRoomProp>()
        {
            new BlazorRoomProp(){Id = 1, Name = "Sq Ft", Value = "330"},
            new BlazorRoomProp(){Id = 2, Name = "Occupancy", Value = "4"}
        }
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        
        RoomList.Add(new BlazorRoom()
        {
            Id = 201,
            Price = 399,
            IsActive = true,
            RoomName = "Villa Suite One Bed Room",
            RoomProps = new List<BlazorRoomProp>()
            {
                new BlazorRoomProp(){Id = 1, Name = "Sq Ft", Value = "330"},
                new BlazorRoomProp(){Id = 2, Name = "Occupancy", Value = "4"}
            }
        });
        
        RoomList.Add(new BlazorRoom()
        {
            Id = 301,
            Price = 699,
            IsActive = true,
            RoomName = "Villa Suite Two Bed Room",
            RoomProps = new List<BlazorRoomProp>()
            {
                new BlazorRoomProp(){Id = 1, Name = "Sq Ft", Value = "150"},
                new BlazorRoomProp(){Id = 2, Name = "Occupancy", Value = "6"}
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
