// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelRoomOrder
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
#line 14 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderManagement.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderManagement.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderManagement.razor"
using Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room-order/details/{Id:int}")]
    public partial class HotelRoomOrderManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 185 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderManagement.razor"
       
    [Parameter]
    public int Id { get; set; }

    private bool IsLoading { get; set; } = false;
    private RoomOrderDetailsDTO HotelBooking { get; set; } = new RoomOrderDetailsDTO() {HotelRoomDTO = new HotelRoomDTO()};

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        if (Id != 0)
        {
            HotelBooking = await RoomOrderDetailsRepository.GetRoomOrderDetails(Id);
        }
        else
        {
            // error
        }
        IsLoading = false;
    }

    private async Task ConfirmCheckIn()
    {
        await RoomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_CheckedIn);
        HotelBooking = await RoomOrderDetailsRepository.GetRoomOrderDetails(Id);
    }
    
    private async Task ConfirmCheckOut()
    {
        await RoomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_CheckedOut_Completed);
        HotelBooking = await RoomOrderDetailsRepository.GetRoomOrderDetails(Id);
    }
    
    private async Task CancelBooking()
    {
        await RoomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_Cancelled);
        HotelBooking = await RoomOrderDetailsRepository.GetRoomOrderDetails(Id);
    }
    
    private async Task NoShowBooking()
    {
        await RoomOrderDetailsRepository.UpdateOrderStatus(HotelBooking.Id, SD.Status_NoShow);
        HotelBooking = await RoomOrderDetailsRepository.GetRoomOrderDetails(Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsRepository RoomOrderDetailsRepository { get; set; }
    }
}
#pragma warning restore 1591
