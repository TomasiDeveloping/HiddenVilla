using System.Collections.Generic;
using System.Threading.Tasks;
using HiddenVilla_Client.Service;
using HiddenVilla_Client.Service.IService;
using Microsoft.AspNetCore.Components;
using Models;

namespace HiddenVilla_Client.Pages.Authentication
{
    public partial class Register
    {
        private UserRequestDTO UserForRegistration = new UserRequestDTO();
        public bool IsProcessing { get; set; } = false;
        public bool ShowRegistrationErrors { get; set; }
        public IEnumerable<string> Errors { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private async Task RegisterUser()
        {
            ShowRegistrationErrors = false;
            IsProcessing = true;
            var result = await AuthenticationService.RegisterUser(UserForRegistration);
            if (result.RegistrationSuccessful)
            {
                IsProcessing = false;
                NavigationManager.NavigateTo("/login");
            }
            else
            {
                IsProcessing = false;
                Errors = result.Errors;
                ShowRegistrationErrors = true;
            }
        
        }
    }
}