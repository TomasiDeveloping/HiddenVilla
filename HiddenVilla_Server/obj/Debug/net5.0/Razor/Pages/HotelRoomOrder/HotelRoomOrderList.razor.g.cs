#pragma checksum "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9af74fff94e13868ca628089e0ac2a9ea3907ec"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room-order")]
    public partial class HotelRoomOrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
 if (!IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h4 class=\"card-title text-info\">Hotel Room Order\'s</h4>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<RoomOrderDetailsDTO>>(1);
            __builder.AddAttribute(2, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 12 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 13 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                            FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                                                                              4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RoomOrderDetailsDTO>>(
#nullable restore
#line 14 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                                           HotelRoomOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ColumnWidth", "200px");
            __builder.AddAttribute(10, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(11);
                __builder2.AddAttribute(12, "Property", "Name");
                __builder2.AddAttribute(13, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(15);
                __builder2.AddAttribute(16, "Property", "Phone");
                __builder2.AddAttribute(17, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(19);
                __builder2.AddAttribute(20, "Property", "Email");
                __builder2.AddAttribute(21, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(23);
                __builder2.AddAttribute(24, "Property", "HotelRoomDTO.Name");
                __builder2.AddAttribute(25, "Title", "Room");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(27);
                __builder2.AddAttribute(28, "Property", "Status");
                __builder2.AddAttribute(29, "Title", "Status");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(31);
                __builder2.AddAttribute(32, "Property", "CheckInDate");
                __builder2.AddAttribute(33, "Title", "Check in Date");
                __builder2.AddAttribute(34, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RoomOrderDetailsDTO>)((data) => (__builder3) => {
                    __builder3.AddContent(35, 
#nullable restore
#line 23 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                     String.Format("{0:d}", data.CheckInDate)

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoomOrderDetailsDTO>>(37);
                __builder2.AddAttribute(38, "Property", "Id");
                __builder2.AddAttribute(39, "Title", "");
                __builder2.AddAttribute(40, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RoomOrderDetailsDTO>)((data) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                    __builder3.AddAttribute(42, "class", "btn btn-primary");
                    __builder3.AddAttribute(43, "href", 
#nullable restore
#line 29 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
                                                             $"hotel-room-order/details/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(45, "Details");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 34 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<p>loading...</p>");
#nullable restore
#line 38 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoomOrder\HotelRoomOrderList.razor"
       
    private IEnumerable<RoomOrderDetailsDTO> HotelRoomOrders { get; set; } = new List<RoomOrderDetailsDTO>();
    private bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        HotelRoomOrders = await RoomOrderDetailsRepository.GetAllRoomOrderDetails();
        IsLoading = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsRepository RoomOrderDetailsRepository { get; set; }
    }
}
#pragma warning restore 1591
