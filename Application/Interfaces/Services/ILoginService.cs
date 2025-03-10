using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;
using Core.Entities;
using Google.Apis.Auth.OAuth2;

namespace Application.Interfaces.Services
{
    public interface ILoginService
    {
        Task<UserDTO> LoginAsync(string login, string password);
        Task<UserDTO> CheckUserExistsAsync(string idToken);
        Task<UserCredential> GetGoogleUserCredentialAsync(); 
        Task<string> GetNewIdTokenAsync(UserCredential credential);
        void DeleteToken();
    }

}
