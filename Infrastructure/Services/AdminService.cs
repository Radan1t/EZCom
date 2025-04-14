using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Interfaces;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly ICodeSenderService _codeSenderService;

        public AdminService(IUnitOfWork unitOfWork, IConfiguration configuration, ICodeSenderService codeSenderService)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _codeSenderService = codeSenderService;
        }
        public async Task<UserDTO> GetUserByIdAsync(int userId)
        {
            var user = await _unitOfWork.Repository<User>().GetByIDAsync(userId);
            if (user == null)
            {
                return null;
            }

            // Перетворюємо на DTO перед поверненням
            return new UserDTO
            {
                Id = user.Id,
                First_name = user.First_name,
                Last_name = user.Last_name,

            };
        }
        public async Task<bool> AddUserToCompanyAsync(string email, int companyId)
        {
            var user = await _unitOfWork.Repository<User>().GetFirstOrDefaultAsync(u => u.E_mail == email);
            if (user == null)
            {
                return false;
            }

            var companyQuery = _unitOfWork.Repository<Company>().GetQueryable(c => c.Id == companyId, "ProductVersion");
            var company = await companyQuery.FirstOrDefaultAsync();

            if (company == null)
            {
                return false;
            }

            // Перевіряємо, чи компанія не перевищила ліміт користувачів
            if (company.User_count >= company.ProductVersion.User_count)
            {
                Console.WriteLine($"Неможливо додати користувача. Досягнуто ліміт: {company.ProductVersion.User_count}.");
                return false;
            }

            // Додаємо користувача до компанії
            user.CompanyID = companyId;
            await _unitOfWork.Repository<User>().UpdateAsync(user);

            // Збільшуємо User_count компанії
            company.User_count++;
            await _unitOfWork.Repository<Company>().UpdateAsync(company);

            await _unitOfWork.SaveAsync();

            // Відправка запрошення
            var result = await _codeSenderService.SendCompanyInviteAsync(email, company.Company_name);
            if (!result.success)
            {
                Console.WriteLine($"Помилка відправки email: {result.message}");
            }

            return true;
        }

        public async Task<List<UserDTO>> GetUsersByCompanyAsync(int companyId)
        {
            var users = await _unitOfWork.Repository<User>()
                .GetAsync(u => u.CompanyID == companyId);

   
            return users.Select(u => new UserDTO
            {
                Id = u.Id,
                First_name = u.First_name,
                Last_name = u.Last_name,
                E_mail = u.E_mail,
                UserTypeID = u.UserTypeID
            }).ToList();
        }


        public async Task<List<UserType>> GetUserTypesAsync()
        {
            return (await _unitOfWork.Repository<UserType>().GetAsync()).ToList();
        }

        public async Task<bool> ChangeUserTypeAsync(int userId, int userTypeId)
        {
            var user = await _unitOfWork.Repository<User>().GetFirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return false;
            }

            var userType = await _unitOfWork.Repository<UserType>().GetFirstOrDefaultAsync(ut => ut.Id == userTypeId);
            if (userType == null)
            {
                return false;
            }

            // Змінюємо тип користувача
            user.UserTypeID = userTypeId;
            user.Type = userType;

            // Оновлюємо користувача в базі даних
            await _unitOfWork.Repository<User>().UpdateAsync(user);
            await _unitOfWork.SaveAsync();

            return true;
        }

        public async Task<bool> AddDepartmentAsync(string departmentName, int companyId, int userId)
        {
            var company = await _unitOfWork.Repository<Company>().GetFirstOrDefaultAsync(c => c.Id == companyId);
            if (company == null)
            {
                return false; 
            }

            var department = new Department
            {
                Department_name = departmentName,
                Worker_count = 1, 
                CompanyID = companyId,
                Company = company
            };


            await _unitOfWork.Repository<Department>().InsertAsync(department);

            // Створення чату для підрозділу
            var chat = new Chat
            {
                Chat_name = $"{departmentName} Chat",
                Create_DateTime = DateTime.Now,
            };


            await _unitOfWork.Repository<Chat>().InsertAsync(chat);

            // Створюємо зв'язок між чатом і підрозділом
            var departmentChat = new DepartmentChat
            {
                DepartmentID = department.Id,
                Department = department,
                ChatID = chat.Id,
                Chat = chat
            };

            // Зберігаємо зв'язок між підрозділом і чатом
            await _unitOfWork.Repository<DepartmentChat>().InsertAsync(departmentChat);

            // Змінюємо UserTypeID користувача на 3 (припускається, що це роль для працівників)
            var user = await _unitOfWork.Repository<User>().GetFirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return false; // Користувач не знайдений
            }

            user.UserTypeID = 3;

            // Оновлюємо користувача в базі даних
            await _unitOfWork.Repository<User>().UpdateAsync(user);

            // Додаємо користувача до підрозділу
            var userDepartment = new UserDepartment
            {
                UserID = userId,
                DepartmentID = department.Id,
                Department = department
            };

            await _unitOfWork.Repository<UserDepartment>().InsertAsync(userDepartment);

            // Зберігаємо всі зміни
            await _unitOfWork.SaveAsync();

            return true;
        }




    }
}
