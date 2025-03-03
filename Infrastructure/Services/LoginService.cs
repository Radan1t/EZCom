using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    internal class LoginService : ILoginService
    {
        private readonly IGenericRepository<User> _userRepository;

        public LoginService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
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
                FirstName = user.First_name,
                LastName = user.Last_name,
                Login = user.Login,
                Email = user.E_mail,
                PhoneNumber = user.Phone_number,
                DateOfBirth = user.Date_of_birthday
            };
        }
    }
}
