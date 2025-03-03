using Application.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IRegistrationService
    {
        Task<bool> IsLoginUnique(string login);
        Task<bool> IsEmailUnique(string email);
        Task<bool> IsPhoneNumberUnique(string phoneNumber);
        Task<bool> RegisterUserAsync(UserDTO user);
    }
}
