#pragma checksum "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1e50fe53b743240cd5c0aecebb51112f2897566"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
 if (IsProcessing)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div style=\"position:fixed;top:50%;left:50%;margin-top:-50px;margin-left:-100px;\"><img src=\"images/ajax-loader.gif\"></div>");
#nullable restore
#line 12 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<div class=""row p-0 m-0""><div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel""><ol class=""carousel-indicators""><li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li></ol>
            <div class=""carousel-inner""><div class=""carousel-item active""><img class=""d-block w-100"" src=""images/slide1.jpg"" alt=""First slide""></div>
                <div class=""carousel-item""><img class=""d-block w-100"" src=""images/slide2.jpg"" alt=""Second slide""></div></div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span></a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span></a></div></div>
    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                     HomeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                               SaveInitialData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row p-0 mx-0 mt-4");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-12 col-md-5  offset-md-1 pl-2  pr-2 pr-md-0");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label>Check In Date</label>\r\n                    ");
                __Blazor.HiddenVilla_Client.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 13, 14, 
#nullable restore
#line 45 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                     DateTime.Now.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
                , 15, "text", 16, "form-control", 17, 
#nullable restore
#line 45 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                                                                       HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 19, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-8 col-md-3 pl-2 pr-2");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label>No. of nights</label>\r\n                    ");
                __builder2.OpenElement(26, "select");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                                        HomeModel.NoOfNights

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.NoOfNights = __value, HomeModel.NoOfNights));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 53 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                         for (var i = 1; i <= 10; i++)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "option");
                __builder2.AddAttribute(31, "value", 
#nullable restore
#line 55 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                            i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(32, 
#nullable restore
#line 55 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                                i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 56 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n            ");
                __builder2.AddMarkupContent(34, "<div class=\"col-4 col-md-2 p-0 pr-2\"><div class=\"form-group\"><label>&nbsp;</label>\r\n\r\n                    <input type=\"submit\" value=\"Go\" class=\"btn btn-success btn-block\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "container pt-4");
            __builder.AddMarkupContent(38, @"<div class=""row""><div class=""col-md-8 offset-md-2 text-center""><h2 class=""text-warning"">Explore our Amenities</h2>
                <p class=""lead"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p></div></div>
        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
#nullable restore
#line 81 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
             foreach (var amenity in HotelAmenities)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-md-4 col-6 p-4");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "border:1px solid #d5d5d5; border-radius:20px;");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row col-4 offset-4 p-4");
            __builder.OpenElement(47, "i");
            __builder.AddAttribute(48, "class", (
#nullable restore
#line 86 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                       amenity.IconStyle

#line default
#line hidden
#nullable disable
            ) + " fa-4x");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "text-center justify-content-center");
            __builder.OpenElement(52, "h5");
            __builder.AddAttribute(53, "class", "text-warning");
            __builder.AddContent(54, 
#nullable restore
#line 89 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                                      amenity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.OpenElement(56, "p");
            __builder.AddContent(57, 
#nullable restore
#line 90 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
                                amenity.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "D:\Webseiten\HiddenVilla\HiddenVilla\HiddenVilla_Client\Pages\Index.razor"
 
    public HomeVM HomeModel { get; set; } = new HomeVM();
    public IEnumerable<HotelAmenityDTO> HotelAmenities { get; set; } = new List<HotelAmenityDTO>();
    public bool IsProcessing { get; set; } = false;
    
    protected override async Task OnInitializedAsync()
    {
        IsProcessing = true;
        HotelAmenities = await hotelAmenityService.GetHotelAmenities();
        IsProcessing = false;
    }

    private async Task SaveInitialData()
    {
        try
        {
            HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.NoOfNights);

            await LocalStorage.SetItemAsync(SD.Local_InitialBooking , HomeModel);
            NavigationManager.NavigateTo("hotel/rooms", true);
        }
        catch (Exception e)
        {
            await JsRuntime.ToastrError(e.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelAmenityService hotelAmenityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
