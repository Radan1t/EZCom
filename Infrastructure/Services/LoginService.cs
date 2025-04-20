using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.Application.Interfaces;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
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
            var user = await _userRepository.GetFirstOrDefaultAsync(u => u.Login == login || u.E_mail == login);
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return null;
            }

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
                CompanyID = user.CompanyID,
            };
        }

        public async Task<UserDTO> CheckUserExistsAsync(string idToken)
        {
            await Task.Delay(5000);
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);
            var email = payload.Email;
            var user = await _userRepository.GetFirstOrDefaultAsync(u => u.E_mail == email);

            return user == null ? null : new UserDTO
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

        
    }
}
