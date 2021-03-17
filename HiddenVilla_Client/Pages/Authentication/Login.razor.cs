using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using HiddenVilla_Client.Service.IService;
using Microsoft.AspNetCore.Components;
using Models;

namespace HiddenVilla_Client.Pages.Authentication
{
    public partial class Login
    {
        private AuthenticationDTO UserForAuthentication = new AuthenticationDTO();
        public bool IsProcessing { get; set; } = false;
        public bool ShowAuthenticationErrors { get; set; }
        public string Errors { get; set; }
        public string ReturnUrl { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private async Task LoginUser()
        {
            ShowAuthenticationErrors = false;
            IsProcessing = true;
            var result = await AuthenticationService.Login(UserForAuthentication);
            if (result.IsAuthSuccessful)
            {
                IsProcessing = false;
                var absolutUri = new Uri(NavigationManager.Uri);
                var queryParam = HttpUtility.ParseQueryString(absolutUri.Query);
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    NavigationManager.NavigateTo("/");
                }
                else
                {
                    NavigationManager.NavigateTo("/" + ReturnUrl);
                }
            }
            else
            {
                IsProcessing = false;
                Errors = result.ErrorMessage;
                ShowAuthenticationErrors = true;
            }
        
        }
    }
}