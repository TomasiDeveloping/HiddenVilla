// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelAmenity
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
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity")]
    public partial class HotelAmenityList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
       
    internal IEnumerable<HotelAmenityDTO> HotelAmenities { get; set; } = new List<HotelAmenityDTO>();

    internal int? DeleteAmenityId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;


    protected override async Task OnInitializedAsync()
    {

        HotelAmenities = await AmenityRepository.GetAllHotelAmenity();
    }

    public async Task HandleDelete(int amenityId)
    {
        DeleteAmenityId = amenityId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }

    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteAmenityId != null)
        {
            try
            {
                var result = await AmenityRepository.DeleteHotelAmenity(DeleteAmenityId.Value, "");
                await JsRuntime.ToastrSucces("Amenity Deleted successfully");
            }
            catch (Exception e)
            {
                await JsRuntime.ToastrError(e.Message);
            }
            HotelAmenities = await AmenityRepository.GetAllHotelAmenity();

        }

        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAmenityRepository AmenityRepository { get; set; }
    }
}
#pragma warning restore 1591
