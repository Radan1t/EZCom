using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IGoogleAuthService
    {
        Task<UserCredential> GetGoogleUserCredentialAsync();
        Task<string> GetNewIdTokenAsync(UserCredential credential);
        void DeleteToken();

    }
}
