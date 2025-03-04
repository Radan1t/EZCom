using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<ApplicationDbContextFactory>()
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Не знайдено строку підключення");
            }

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }

        public async Task<UserCredential> GetGoogleUserCredentialAsync()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<ApplicationDbContextFactory>()
                .Build();

            var clientSecrets = new ClientSecrets
            {
                ClientId = configuration["installed:client_id"],
                ClientSecret = configuration["installed:client_secret"]
            };

            return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                clientSecrets,
                new[] { "email", "profile" },
                "user",
                CancellationToken.None,
                new FileDataStore("GoogleOAuthStore", true)
            );
        }

        public async Task<string> GetNewIdTokenAsync(UserCredential credential)
        {
            if (credential.Token.IsExpired(credential.Flow.Clock))
            {
                bool result = await credential.RefreshTokenAsync(CancellationToken.None);
                if (!result)
                {
                    throw new InvalidOperationException("Unable to refresh token");
                }
            }
            return credential.Token.IdToken;
        }

        public void DeleteToken()
        {
            var dataStore = new FileDataStore("GoogleOAuthStore", true);
            dataStore.ClearAsync().Wait();
        }
    }
}
