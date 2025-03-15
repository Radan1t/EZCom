using System;
using Application.Interfaces;
using EZCom.Application.Interfaces;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using BCrypt.Net;
using Application.Common.DTO;
using Infrastructure.Persistence.Repositories;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence.Data;
using AutoMapper;

namespace Infrastructure.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericRepository<ProductVersionType> _ProductRepository;
        private readonly IGenericRepository<Company> _CompanyRepository;
        private readonly IGenericRepository<User> _UserRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(IGenericRepository<ProductVersionType> ProductRepository, IUnitOfWork unitOfWork,IGenericRepository<User> UserRepository,IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _UserRepository = UserRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task CreateCompanyAsync(CompanyDTO company,int IDUser)
        {
            try
            {

                var userRepo = _unitOfWork.Repository<User>();
                var user = await userRepo.GetByIDAsync(IDUser);

                if (user != null)
                {
                    user.UserTypeID = 4;

                    await userRepo.UpdateAsync(user);
                }
                else
                {
                    Console.WriteLine($"[ERROR] Користувач з ID {IDUser} не знайдений.");
                    throw new Exception($"Користувач з ID {IDUser} не знайдений.");
                }
                var compan = new Company
                {
                    Company_name = company.Company_name,
                    Contact_manager_name = company.Contact_manager_name,
                    Contact_manager_phone = company.Contact_manager_phone,
                    Contact_manager_email = company.Contact_manager_email,
                    User_count = company.User_count,
                    ProductVersionTypeID = company.ProductVersionTypeID,
                    Subscription_time = company.Subscription_time
                };
                var companyRepo = _unitOfWork.Repository<Company>();
                await companyRepo.InsertAsync(compan);
                await _unitOfWork.SaveAsync();
                var savedCompany = await companyRepo.GetFirstOrDefaultAsync(c => c.Company_name == company.Company_name);
                if (savedCompany != null)
                {
                    int CompanyID = savedCompany.Id;
                    user.CompanyID = CompanyID;
                    await _unitOfWork.SaveAsync();
                }
                else
                {
                    Console.WriteLine("[ERROR] Компанію не знайдено за назвою.");
                    throw new Exception("Компанію не знайдено за назвою.");
                }

                
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"[DB ERROR] {dbEx.InnerException?.Message ?? dbEx.Message}");
                throw; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex}");
                throw;
            }
        }
        public async Task<IEnumerable<ProductVersionDTO>> GetSubscriptionsAsync()
        {
            var subscriptions = await _ProductRepository.GetAllAsync();
            return subscriptions.Select(s => new ProductVersionDTO
            {
                id = s.id,
                Version_name = s.Version_name,
                Version_price = s.Version_price,
                User_count = s.User_count
            }).ToList();
        }
        public async Task<UserDTO> GetUserByIdAsync(int id) => _mapper.Map<UserDTO>(await _UserRepository.GetByIDAsync(id));

    }
}