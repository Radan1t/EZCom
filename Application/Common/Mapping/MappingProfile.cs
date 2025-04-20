using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Application.Common.DTO;
using Core.Entities;

namespace Application.Common.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<Chat,ChatDTO>();
            CreateMap<CompanyChat,CompanyChatDTO>();
            CreateMap<Company, CompanyDTO>();
            CreateMap<DepartmentChat, DepartmentChatDTO>();
            CreateMap<Department, DepartmentDTO>();
            CreateMap<Meet, MeetDTO>();
            CreateMap<MeetUser, MeetUserDTO>();
            CreateMap<Message, MessageDTO>();
            CreateMap<ProductVersionType, ProductVersionDTO>();
            CreateMap<UserChat, UserChatDTO>();
            CreateMap<UserDepartment, UserDepartmentDTO>();
            CreateMap<User, UserDTO>(); 
            CreateMap<UserType, UserTypeDTO>(); 

        }
    }
}
