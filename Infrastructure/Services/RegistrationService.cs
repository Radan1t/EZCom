using System;
using Application.Interfaces;
using EZCom.Application.Interfaces;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using BCrypt.Net;
using Application.Common.DTO;
using Infrastructure.Persistence.Repositories;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    internal class RegistrationService : IRegistrationService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IUnitOfWork _unitOfWork;


        public RegistrationService(IGenericRepository<User> userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }


        public async Task<bool> IsLoginUnique(string login)
        {
            var existingUser = await _userRepository.GetFirstOrDefaultAsync(u => u.Login == login);
            return existingUser == null;
        }

        public async Task<bool> IsEmailUnique(string email)
        {
            var existingUser = await _userRepository.GetFirstOrDefaultAsync(u => u.E_mail == email);
            return existingUser == null;
        }

        public async Task<bool> IsPhoneNumberUnique(string phoneNumber)
        {
            var existingUser = await _userRepository.GetFirstOrDefaultAsync(u => u.Phone_number == phoneNumber);
            return existingUser == null;
        }
        public async Task<bool> RegisterUserAsync(UserDTO userDto)
        {
            try
            {
                var newUser = new User
                {
                    First_name = userDto.FirstName,
                    Last_name = userDto.LastName,
                    Login = userDto.Login,
                    E_mail = userDto.Email,
                    Phone_number = userDto.PhoneNumber,
                    Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password),
                    Date_of_birthday = userDto.DateOfBirth,
                    UserTypeID = 1
                };

                var userRepo = _unitOfWork.Repository<User>();
                await userRepo.InsertAsync(newUser);
                await _unitOfWork.SaveAsync();

                return true;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"[DB ERROR] {dbEx.InnerException?.Message ?? dbEx.Message}");
                throw; // Дозволяє побачити стек викликів
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex}");
                throw;
            }
        }



    }
}
