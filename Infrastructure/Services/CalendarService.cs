using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Services;

namespace Infrastructure.Services
{
    public class GoogleCalendarService : ICalendarService 
    {
        private readonly IConfiguration _configuration;
        private static readonly string[] Scopes = { CalendarService.Scope.CalendarReadonly }; 
        private static readonly string ApplicationName = "Google Calendar API Access";

        public GoogleCalendarService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<UserCredential> GetGoogleUserCredentialAsync()
        {
            var clientSecrets = new ClientSecrets
            {
                ClientId = _configuration["installed:client_id"],
                ClientSecret = _configuration["installed:client_secret"]
            };

            return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                clientSecrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore("GoogleOAuthStore", true)
            );
        }

        public async Task<bool> RequestCalendarPermissionAsync()
        {
            try
            {
                UserCredential credential = await GetGoogleUserCredentialAsync();

                var service = new CalendarService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> HasCalendarAccessAsync()
        {
            try
            {
                UserCredential credential = await GetGoogleUserCredentialAsync();
                var service = new CalendarService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });

                var request = service.CalendarList.List(); 
                var calendars = await request.ExecuteAsync();

                return calendars.Items != null && calendars.Items.Count > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
