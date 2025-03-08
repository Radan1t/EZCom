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

namespace Infrastructure.Services
{
    public class CompanyService : ICreateCompany
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateCompanyAsync(string companyName, string contactManagerName, string contactManagerPhone, string contactManagerEmail, int userCount, int productVersionTypeId, DateTime subscriptionTime)
        {
            var company = new Company
            {
                Company_name = companyName,
                Contact_manager_name = contactManagerName,
                Contact_manager_phone = contactManagerPhone,
                Contact_manager_email = contactManagerEmail,
                User_count = userCount,
                ProductVersionTypeID = productVersionTypeId,
                Subscription_time = subscriptionTime
            };

            // Додавання компанії до контексту і збереження змін
            await _dbContext.Companies.AddAsync(company);
            await _dbContext.SaveChangesAsync();
        }
    }
}