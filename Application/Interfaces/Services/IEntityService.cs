using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;

namespace Application.Interfaces.Services
{
    public interface IEntityService
    {
        Task<UserDTO> GetUserByIdAsync(int id);
    }
}
