using Application.Common.DTO;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAdminService
    {
        Task<bool> AddUserToCompanyAsync(string email, int companyId);
        Task<List<UserDTO>> GetUsersByCompanyAsync(int companyId);
        Task<List<UserType>> GetUserTypesAsync();
        Task<bool> ChangeUserTypeAsync(int userId, int userTypeId);
        Task<bool> AddDepartmentAsync(string departmentName, int companyId, int userId);
    }
}
