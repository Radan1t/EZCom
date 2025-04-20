using Application.Interfaces.Services;
using Google.Apis.Auth.OAuth2;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GoogleAuthService : IGoogleAuthService
    {
        private readonly ICalendarService _calendarService;
        public GoogleAuthService(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public async Task<UserCredential> GetGoogleUserCredentialAsync()
        {
            return await _calendarService.GetLoginCredentialAsync();
        }

        public async Task<string> GetNewIdTokenAsync(UserCredential credential)
        {
            // Перевіряємо чи токен не прострочений, і при необхідності оновлюємо його
            if (credential.Token.IsExpired(credential.Flow.Clock))
            {
                bool result = await credential.RefreshTokenAsync(CancellationToken.None);
                if (!result)
                {
                    throw new InvalidOperationException("Unable to refresh token.");
                }
                Console.WriteLine("Token refreshed.");
            }

            // Отримуємо ID токен
            var idToken = credential.Token?.IdToken;
            if (string.IsNullOrEmpty(idToken))
            {
                Console.WriteLine("ID token is null or empty after refresh.");
                throw new InvalidOperationException("ID token is empty or not retrieved.");
            }

            return idToken;
        }




        public void DeleteToken()
        {
            var dataStore = new Google.Apis.Util.Store.FileDataStore("GoogleOAuthStore", true);
            dataStore.ClearAsync().Wait();
        }

        public async Task<bool> RequestCalendarPermissionAsync()
        {
            return await _calendarService.RequestCalendarPermissionAsync();
        }
    }
}
