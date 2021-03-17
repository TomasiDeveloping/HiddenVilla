using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Models;

namespace HiddenVilla_Client.Service.IService
{
    public interface IAuthenticationService
    {
        Task <RegistrationResponseDTO> RegisterUser(UserRequestDTO userForRegistration);
        Task <AuthenticationResponseDTO> Login(AuthenticationDTO userFromAuthentication);
        Task Logout();
    }
}