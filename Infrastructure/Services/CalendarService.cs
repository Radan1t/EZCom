using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Services;

namespace Infrastructure.Services
{
    public class GoogleCalendarService : ICalendarService
    {
        private readonly IConfiguration _configuration;
        private static readonly string[] Scopes = { CalendarService.Scope.Calendar, "openid", "email", "profile" };
        private static string ApplicationName = "EZCom Calendar Access";

        public GoogleCalendarService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<UserCredential> GetLoginCredentialAsync()
        {
            return await GetGoogleUserCredentialAsync("installed:client_id", "installed:client_secret");
        }

        public async Task<UserCredential> GetCalendarCredentialAsync()
        {
            return await GetGoogleUserCredentialAsync("installed:client_id2", "installed:client_secret2");
        }

        private async Task<UserCredential> GetGoogleUserCredentialAsync(string clientIdKey, string clientSecretKey)
        {
            var clientSecrets = new ClientSecrets
            {
                ClientId = _configuration[clientIdKey],
                ClientSecret = _configuration[clientSecretKey]
            };

            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                clientSecrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore("GoogleOAuthStore", true)
            );

            if (credential.Token.IsExpired(credential.Flow.Clock))
            {
                bool result = await credential.RefreshTokenAsync(CancellationToken.None);
                if (!result)
                {
                    throw new InvalidOperationException("Unable to refresh token.");
                }
            }

            return credential;
        }

        public async Task<bool> RequestCalendarPermissionAsync()
        {
            try
            {
                UserCredential credential = await GetCalendarCredentialAsync();

                var service = new CalendarService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });

                var request = service.CalendarList.List();
                var calendars = await request.ExecuteAsync();

                return calendars.Items != null && calendars.Items.Count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while requesting calendar permission: {ex.Message}");
                return false;
            }
        }

        public async Task<string> GetIdTokenAsync(UserCredential credential)
        {
            try
            {
                if (credential.Token.IsExpired(credential.Flow.Clock))
                {
                    bool result = await credential.RefreshTokenAsync(CancellationToken.None);
                    if (!result)
                    {
                        throw new InvalidOperationException("Unable to refresh token.");
                    }
                    Console.WriteLine("Token refreshed.");
                }

                var idToken = credential.Token?.IdToken;
                if (string.IsNullOrEmpty(idToken))
                {
                    Console.WriteLine("ID token is null or empty.");
                    throw new InvalidOperationException("ID token is not available.");
                }

                return idToken;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while retrieving ID token: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> HasCalendarAccessAsync()
        {
            try
            {
                UserCredential credential = await GetLoginCredentialAsync();

                var service = new CalendarService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });

                var request = service.CalendarList.List();
                var calendars = await request.ExecuteAsync();

                if (calendars.Items != null && calendars.Items.Count > 0)
                {
                    var eventsRequest = service.Events.List(calendars.Items[0].Id);
                    var events = await eventsRequest.ExecuteAsync();
                    return events.Items != null && events.Items.Count > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while checking calendar access: {ex.Message}");
                return false;
            }
        }
    }
}
