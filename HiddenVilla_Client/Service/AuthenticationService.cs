using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Common;
using HiddenVilla_Client.Service.IService;
using Microsoft.AspNetCore.Components.Authorization;
using Models;
using Newtonsoft.Json;

namespace HiddenVilla_Client.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorageService;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(HttpClient httpClient, ILocalStorageService localStorageService, AuthenticationStateProvider authenticationStateProvider)
        {
            _client = httpClient;
            _localStorageService = localStorageService;
            _authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<RegistrationResponseDTO> RegisterUser(UserRequestDTO userForRegistration)
        {
            var content = JsonConvert.SerializeObject(userForRegistration);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/account/signup", bodyContent);
            
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RegistrationResponseDTO>(contentTemp);
            if (response.IsSuccessStatusCode)
            {
                return new RegistrationResponseDTO() {RegistrationSuccessful = true};
            }
            else
            {
                return result;
            }
        }

        public async Task<AuthenticationResponseDTO> Login(AuthenticationDTO userFromAuthentication)
        {
            var content = JsonConvert.SerializeObject(userFromAuthentication);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/account/signin", bodyContent);
            
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AuthenticationResponseDTO>(contentTemp);
            if (response.IsSuccessStatusCode)
            {
                await _localStorageService.SetItemAsync(SD.Local_Token, result.Token);
                await _localStorageService.SetItemAsync(SD.Local_UserDetails, result.UserDto);
                ((AuthStateProvider) _authenticationStateProvider).NotifyUserLoggedIn(result.Token);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);
                return new AuthenticationResponseDTO(){IsAuthSuccessful = true};
            }
            else
            {
                return result;
            }
        }

        public async Task Logout()
        {
            await _localStorageService.RemoveItemAsync(SD.Local_Token);
            await _localStorageService.RemoveItemAsync(SD.Local_UserDetails);
            ((AuthStateProvider) _authenticationStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }
    }
}