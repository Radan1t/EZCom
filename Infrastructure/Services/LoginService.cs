using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.Application.Interfaces;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services
{
    internal class LoginService : ILoginService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IConfiguration _configuration;

        public LoginService(IGenericRepository<User> userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<UserDTO> LoginAsync(string login, string password)
        {
            // Знаходимо користувача за логіном або електронною поштою
            var user = await _userRepository.GetFirstOrDefaultAsync(u => u.Login == login || u.E_mail == login);

            // Перевірка наявності користувача та правильності пароля
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return null; // Якщо користувача не знайдено або пароль невірний
            }

            // Повертаємо DTO користувача
            return new UserDTO
            {
                Id = user.Id,
                First_name = user.First_name,
                Last_name = user.Last_name,
                Login = user.Login,
                E_mail= user.E_mail,
                Phone_number = user.Phone_number,
                Date_of_birthday = user.Date_of_birthday,
                UserTypeID=user.UserTypeID,
                CompanyID=user.CompanyID,
            };
        }
        public async Task<UserDTO> CheckUserExistsAsync(string idToken)
        {
            // Логіка для отримання електронної пошти з токена
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);
            var email = payload.Email;

            // Знаходимо користувача за електронною поштою
            var user = await _userRepository.GetFirstOrDefaultAsync(u => u.E_mail == email);

            if (user == null)
            {
                return null; // Користувача не знайдено
            }

            // Повертаємо DTO користувача
            return new UserDTO
            {
                Id = user.Id,
                First_name = user.First_name,
                Last_name = user.Last_name,
                Login = user.Login,
                E_mail = user.E_mail,
                Phone_number = user.Phone_number,
                Date_of_birthday = user.Date_of_birthday,
                UserTypeID = user.UserTypeID,
                CompanyID = user.CompanyID
            };
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
