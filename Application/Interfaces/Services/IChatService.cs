using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Common.DTO;
using Core.Entities;

namespace Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<List<UserDepartment>> GetUserDepartmentsAsync(int userId);
        Task<Chat> GetDepartmentChatAsync(int departmentId);
        Task<List<UserDTO>> GetUsersByCompanyIdAsync(int companyId);
        Task CreateChatAsync(ChatDTO newChat, UserChat userChat1, UserChat userChat2);
        Task<List<UserChatDTO>> GetUserChatsAsync(int userId); 
        Task<ChatDTO> GetChatByIdAsync(int chatId); 
    }
}
