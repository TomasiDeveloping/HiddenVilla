// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Client.Pages.Stripe
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Stripe\Success_Payment.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Stripe\Success_Payment.razor"
           [Authorize(Roles = SD.Role_Customer)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/success-payment")]
    public partial class Success_Payment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Stripe\Success_Payment.razor"
       
    private bool IsPaymentComplete { get; set; }
    private int OrderId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var orderDetails = await LocalStorageService.GetItemAsync<RoomOrderDetailsDTO>(SD.Local_RoomOrderDetails);
        OrderId = orderDetails.Id;

        var finalRoomOrderDetails = await RoomOrderDetailsService.MarkPaymentSuccessful(orderDetails);
        if (finalRoomOrderDetails.Status == SD.Status_Booked)
        {
            await LocalStorageService.RemoveItemAsync(SD.Local_RoomOrderDetails);
            await LocalStorageService.RemoveItemAsync(SD.Local_InitialBooking);

            IsPaymentComplete = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsService RoomOrderDetailsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorageService { get; set; }
    }
}
#pragma warning restore 1591
