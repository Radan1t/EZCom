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
            CreateMap<User, UserDTO>(); 
            CreateMap<Company, CompanyDTO>(); 
        }
    }
}
