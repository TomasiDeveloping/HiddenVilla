#pragma checksum "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8520b028a52a8591427846e0fcfa0acd399d1a89"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Client.Pages.HotelRooms
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel/rooms")]
    public partial class HotelRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
 if (Rooms != null && Rooms.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                     HomeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                               SaveBookingInfo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "bg-light");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "pt-3 pb-2 px-5 mx-1 mx-md-0 bg-secondary");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row px-3 mx-3");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-6 col-md-4");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label class=\"text-warning\">Check in Date</label>\r\n                        ");
                __Blazor.HiddenVilla_Client.Pages.HotelRooms.HotelRoom.TypeInference.CreateInputDate_0(__builder2, 16, 17, "form-control", 18, 
#nullable restore
#line 16 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 20, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-6 col-md-4");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label class=\"text-warning\">Check Out Date</label>\r\n                        ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "disabled", "disabled");
                __builder2.AddAttribute(29, "readonly", "readonly");
                __builder2.AddAttribute(30, "type", "date");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                      HomeModel.EndDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.EndDate = __value, HomeModel.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", " col-4 col-md-2");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label class=\"text-warning\">No. of nights</label>\r\n                        ");
                __builder2.OpenElement(40, "select");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                            HomeModel.NoOfNights

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.NoOfNights = __value, HomeModel.NoOfNights));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(44, "option");
                __builder2.AddAttribute(45, "value", "Select");
                __builder2.AddAttribute(46, "selected");
                __builder2.AddAttribute(47, "disabled", "disabled");
                __builder2.AddContent(48, "(Select No. Of Nights)");
                __builder2.CloseElement();
#nullable restore
#line 30 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                             for (var i = 1; i <= 10; i++)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 32 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(51, 
#nullable restore
#line 32 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                    i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 33 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-8 col-md-2");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddAttribute(57, "style", "margin-top: 1.9rem !important;");
#nullable restore
#line 40 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                         if (IsProcessing)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<button class=\"btn btn-success btn-block form-control\"><i class=\"fa fa-spin fa-spinner\"></i>Processing...</button>");
#nullable restore
#line 43 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<input type=\"submit\" value=\"Update\" class=\"btn btn-success btn-block form-control\">");
#nullable restore
#line 47 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "mt-4 mx-4 px-0 px-md-5 mx-md-5");
#nullable restore
#line 55 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
         foreach (var room in Rooms)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row p-2 my-3 ");
            __builder.AddAttribute(65, "style", "border-radius:20px; border: 1px solid #ffffff");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-12 col-lg-3 col-md-4");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "id", "carouselExampleIndicators_" + (
#nullable restore
#line 60 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                        room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "class", "carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0");
            __builder.AddAttribute(71, "data-ride", "carousel");
            __builder.OpenElement(72, "ol");
            __builder.AddAttribute(73, "class", "carousel-indicators");
#nullable restore
#line 62 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                              
                                int imageIndex = 0;
                                int innerImageIndex = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                             foreach (var image in room.HotelRoomImages)
                            {
                                if (imageIndex == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "li");
            __builder.AddAttribute(75, "data-target", "#carouselExampleIndicators_" + (
#nullable restore
#line 70 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                 room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "data-slide-to", 
#nullable restore
#line 70 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                                          imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "class", "active");
            __builder.CloseElement();
#nullable restore
#line 71 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "li");
            __builder.AddAttribute(79, "data-target", "#carouselExampleIndicators_" + (
#nullable restore
#line 75 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                 room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "data-slide-to", 
#nullable restore
#line 75 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                                          imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 76 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                }
                                imageIndex++;
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "carousel-inner");
#nullable restore
#line 83 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                             foreach (var image in room.HotelRoomImages)
                            {
                                if (innerImageIndex == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "carousel-item active");
            __builder.OpenElement(86, "img");
            __builder.AddAttribute(87, "class", "d-block w-100");
            __builder.AddAttribute(88, "style", "border-radius:20px;");
            __builder.AddAttribute(89, "src", 
#nullable restore
#line 88 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                                     image.RoomImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "carousel-item");
            __builder.OpenElement(93, "img");
            __builder.AddAttribute(94, "class", "d-block w-100");
            __builder.AddAttribute(95, "style", "border-radius:20px;");
            __builder.AddAttribute(96, "src", 
#nullable restore
#line 94 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                                     image.RoomImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                }

                                innerImageIndex++;
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "a");
            __builder.AddAttribute(100, "class", "carousel-control-prev");
            __builder.AddAttribute(101, "href", "#carouselExampleIndicators_" + (
#nullable restore
#line 101 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                           room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "role", "button");
            __builder.AddAttribute(103, "data-slide", "prev");
            __builder.AddMarkupContent(104, "<span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n                            ");
            __builder.AddMarkupContent(105, "<span class=\"sr-only\">Previous</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                        ");
            __builder.OpenElement(107, "a");
            __builder.AddAttribute(108, "class", "carousel-control-next");
            __builder.AddAttribute(109, "href", "#carouselExampleIndicators_" + (
#nullable restore
#line 105 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                           room.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "role", "button");
            __builder.AddAttribute(111, "data-slide", "next");
            __builder.AddMarkupContent(112, "<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n                            ");
            __builder.AddMarkupContent(113, "<span class=\"sr-only\">Next</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-12 col-lg-9 col-md-8");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "row pt-3");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col-12 col-lg-8");
            __builder.OpenElement(121, "p");
            __builder.AddAttribute(122, "class", "card-title text-warning");
            __builder.AddAttribute(123, "style", "font-size:xx-large");
            __builder.AddContent(124, 
#nullable restore
#line 114 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                           room.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                            ");
            __builder.OpenElement(126, "p");
            __builder.AddAttribute(127, "class", "card-text");
            __builder.AddContent(128, 
#nullable restore
#line 116 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                  (MarkupString)room.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-12 col-lg-4");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "row pb-3 pt-2");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "col-12 col-lg-11 offset-lg-1");
#nullable restore
#line 122 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                     if (room.IsBooked)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(136, "<button disabled class=\"btn btn-secondary btn-block\">Sold Out</button>");
#nullable restore
#line 125 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "a");
            __builder.AddAttribute(138, "href", 
#nullable restore
#line 129 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                   $"hotel/room-details/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(139, "class", "btn btn-success btn-block");
            __builder.AddContent(140, "Book");
            __builder.CloseElement();
#nullable restore
#line 130 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "row ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "col-12 pb-5");
            __builder.OpenElement(146, "span");
            __builder.AddAttribute(147, "class", "float-right");
            __builder.OpenElement(148, "span");
            __builder.AddAttribute(149, "class", "float-right");
            __builder.AddContent(150, "Max Occupancy : ");
            __builder.AddContent(151, 
#nullable restore
#line 136 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                   room.Occupancy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(152, " adults ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "<br>\r\n                                        ");
            __builder.OpenElement(154, "span");
            __builder.AddAttribute(155, "class", "float-right pt-1");
            __builder.AddContent(156, "Villa Size : ");
            __builder.AddContent(157, 
#nullable restore
#line 137 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                                     room.SqFt

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(158, " sqft");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "<br>\r\n                                        ");
            __builder.OpenElement(160, "h4");
            __builder.AddAttribute(161, "class", "text-warning font-weight-bold pt-4");
            __builder.AddMarkupContent(162, "\r\n                                            USD\r\n                                            ");
            __builder.OpenElement(163, "span");
            __builder.AddAttribute(164, "style", "border-bottom:1px solid #ff6a00");
            __builder.AddContent(165, 
#nullable restore
#line 141 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                 room.TotalAmount.ToString("#,#.00;(#,#.00#)")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                        ");
            __builder.OpenElement(167, "span");
            __builder.AddAttribute(168, "class", "float-right");
            __builder.AddContent(169, "Cost for  ");
            __builder.AddContent(170, 
#nullable restore
#line 144 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
                                                                             room.TotalDays

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(171, " nights");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 153 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 156 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(172, "<div style=\"position:fixed;top:50%;left:50%;margin-top:-50px;margin-left:-100px;\"><img src=\"images/ajax-loader.gif\"></div>");
#nullable restore
#line 162 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 165 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRoom.razor"
       
    private HomeVM HomeModel { get; set; } = new HomeVM();
    public IEnumerable<HotelRoomDTO> Rooms { get; set; } = new List<HotelRoomDTO>();
    private bool IsProcessing { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        try
        {

            if (await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking) != null)
            {
                HomeModel = await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking);
            }
            else
            {
                HomeModel.NoOfNights = 1;
            }
            await LoadRooms();
        }
        catch (Exception e)
        {
            await jsRuntime.ToastrError(e.Message);
        }
    }

    private async Task LoadRooms()
    {
        Rooms = await hotelRoomService.GetHotelRooms(HomeModel.StartDate.ToString("MM/dd/yyyy"), HomeModel.EndDate.ToString("MM/dd/yyyy"));

        foreach (var room in Rooms)
        {
            room.TotalAmount = room.RegularRate * HomeModel.NoOfNights;
            room.TotalDays = HomeModel.NoOfNights;
        }

    }

    private async Task SaveBookingInfo()
    {
        IsProcessing = true;
        HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.NoOfNights);
        await localStorage.SetItemAsync(SD.Local_InitialBooking, HomeModel);
        await LoadRooms();
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService hotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Client.Pages.HotelRooms.HotelRoom
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
