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
        Task<UserDTO> GetCompanionInPrivateChatAsync(int chatId, int currentUserId);
        Task<List<Message>> GetMessagesByChatIdAsync(int chatId);
        Task SendMessageAsync(MessageDTO message);
        Task<DepartmentChat> GetDepartmentChatByChatIdAsync(int chatId);
        Task<List<UserDTO>> GetUsersByDepartmentIdAsync(int departmentId);
        Task<DepartmentChatDTO> GetDepartmentChatDTOByChatIdAsync(int chatId);
        Task AddDepartment(int departmentId, int userId);
        Task RemoveFromDepartmentAsync(int departmentId, int userId);


    }
}
