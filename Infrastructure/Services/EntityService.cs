using Application.Common.DTO;
using Application.Interfaces.Services;
using AutoMapper;
using Core.Entities;
using EZCom.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{

    internal class EntityService: IEntityService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<User> _userRepository;
        public EntityService (IGenericRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserDTO> GetUserByIdAsync(int id) => _mapper.Map<UserDTO>(await _userRepository.GetByIDAsync(id));

    }
}
