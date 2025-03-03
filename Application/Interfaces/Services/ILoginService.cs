using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;
using Core.Entities;

namespace Application.Interfaces.Services
{
    public interface ILoginService
    {
        Task<UserDTO> LoginAsync(string login, string password);
    }
}
