using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using Core.Entities;
using Application.Interfaces;
using EZCom.Application.Interfaces;
using Application.Common.DTO;

namespace Infrastructure.Services
{
    public class ChatService : IChatService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChatService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<UserDepartment>> GetUserDepartmentsAsync(int userId)
        {
            var result = await _unitOfWork.Repository<UserDepartment>()
                .GetAsync(ud => ud.UserID == userId);

            return result.ToList();
        }
        public async Task<UserDTO> GetCompanionInPrivateChatAsync(int chatId, int currentUserId)
        {
            var userChats = await _unitOfWork.Repository<UserChat>()
            .GetAsync(uc => uc.ChatID == chatId, includeProperties: "User1,User2");

            var userChat = userChats.FirstOrDefault();


            if (userChat == null) return null;

            if (userChat.UserID1 != currentUserId && userChat.User1 != null)
            {
                return new UserDTO
                {
                    Id = userChat.UserID1,
                    First_name = userChat.User1.First_name,
                    Last_name = userChat.User1.Last_name,
                    E_mail = userChat.User1.E_mail,
                    CompanyID = userChat.User1.CompanyID
                };
            }

            if (userChat.UserID2 != currentUserId && userChat.User2 != null)
            {
                return new UserDTO
                {
                    Id = userChat.UserID2,
                    First_name = userChat.User2.First_name,
                    Last_name = userChat.User2.Last_name,
                    E_mail = userChat.User2.E_mail,
                    CompanyID = userChat.User2.CompanyID
                };
            }

            return null;
        }
        public async Task<Chat> GetDepartmentChatAsync(int departmentId)
        {
            var departmentChat = await _unitOfWork.Repository<DepartmentChat>()
                .GetFirstOrDefaultAsync(dc => dc.DepartmentID == departmentId);

            if (departmentChat == null) return null;

            return await _unitOfWork.Repository<Chat>().GetByIDAsync(departmentChat.ChatID);
        }
        public async Task<List<UserDTO>> GetUsersByCompanyIdAsync(int companyId)
        {
            var users = await _unitOfWork.Repository<User>()
                .GetAsync(u => u.CompanyID == companyId);

            return users.Select(u => new UserDTO
            {
                Id = u.Id,
                First_name = u.First_name,
                Last_name = u.Last_name,
                E_mail = u.E_mail,
                CompanyID = u.CompanyID
            }).ToList();
        }

        public async Task CreateChatAsync(ChatDTO newChat, UserChat userChat1, UserChat userChat2)
        {
       
            var chatEntity = new Chat
            {
                Chat_name = newChat.Chat_name,
                Create_DateTime = newChat.Create_DateTime
            };


            await _unitOfWork.Repository<Chat>().InsertAsync(chatEntity);


            await _unitOfWork.SaveAsync();


            var savedChat = await _unitOfWork.Repository<Chat>()
                .GetFirstOrDefaultAsync(c => c.Chat_name == newChat.Chat_name);


            if (savedChat == null)
            {
                throw new Exception("Чат не був знайдений після збереження.");
            }


            int chatId = savedChat.Id;


            userChat1.ChatID = chatId;
            userChat2.ChatID = chatId;


            await _unitOfWork.Repository<UserChat>().InsertAsync(userChat1);
            await _unitOfWork.Repository<UserChat>().InsertAsync(userChat2);


            await _unitOfWork.SaveAsync();
        }

        public async Task<List<UserChatDTO>> GetUserChatsAsync(int userId)
        {
            var userChats = await _unitOfWork.Repository<UserChat>()
                .GetAsync(uc => uc.UserID1 == userId);

            if (userChats == null)
            {
                return new List<UserChatDTO>();
            }

            var chatIds = userChats.Select(uc => uc.ChatID).ToList();
            var chats = await _unitOfWork.Repository<Chat>()
                .GetAsync(c => chatIds.Contains(c.Id));

            var userChatDTOs = userChats.Select(uc =>
            {
                var chat = chats.FirstOrDefault(c => c.Id == uc.ChatID);
                if (chat == null)
                {
                    return null;
                }

                return new UserChatDTO
                {
                    ChatID = chat.Id
                    // Використовуйте тільки ChatID, без Chat_name
                };
            }).Where(dto => dto != null).ToList();

            return userChatDTOs;
        }

        public async Task SendMessageAsync(MessageDTO messageDto)
        {
            var message = new Message
            {
                ChatID = messageDto.ChatID,
                UserID = messageDto.UserID,
                Content = messageDto.Content,
                DateTime = DateTime.Now
            };

            await _unitOfWork.Repository<Message>().InsertAsync(message);
            await _unitOfWork.SaveAsync();
        }
        public async Task<DepartmentChat> GetDepartmentChatByChatIdAsync(int chatId)
        {
            var result = await _unitOfWork.Repository<DepartmentChat>()
     .GetAsync(dc => dc.ChatID == chatId, includeProperties: "Department");

            return result.FirstOrDefault();

        }

        public async Task<List<UserDTO>> GetUsersByDepartmentIdAsync(int departmentId)
        {
            var userDepartments = await _unitOfWork.Repository<UserDepartment>()
                .GetAsync(ud => ud.DepartmentID == departmentId, includeProperties: "User");

            return userDepartments
                .Where(ud => ud.User != null)
                .Select(ud => new UserDTO
                {
                    Id = ud.User.Id,
                    First_name = ud.User.First_name,
                    Last_name = ud.User.Last_name,
                    E_mail = ud.User.E_mail,
                    CompanyID = ud.User.CompanyID
                })
                .ToList();
        }
        public async Task<DepartmentChatDTO> GetDepartmentChatDTOByChatIdAsync(int chatId)
        {
            var departmentChat = await _unitOfWork.Repository<DepartmentChat>()
                .GetAsync(dc => dc.ChatID == chatId, includeProperties: "Department");

            var dc = departmentChat.FirstOrDefault();
            if (dc == null || dc.Department == null) return null;

            return new DepartmentChatDTO
            {
                DepartmentID = dc.DepartmentID,
                ChatID = dc.ChatID,

            };
        }

        public async Task<ChatDTO> GetChatByIdAsync(int chatId)
        {

            var chat = await _unitOfWork.Repository<Chat>().GetByIDAsync(chatId);

            if (chat == null)
            {
                return null;
            }

       
            var chatDTO = new ChatDTO
            {
                Id = chat.Id, 
                Chat_name = chat.Chat_name, 
                Create_DateTime = chat.Create_DateTime 
            };

            return chatDTO;
        }
        public async Task<List<Message>> GetMessagesByChatIdAsync(int chatId)
        {
            var messages = await _unitOfWork.Repository<Message>()
                .GetAsync(m => m.ChatID == chatId);

            return messages.OrderBy(m => m.DateTime).ToList();
        }


    }
}
