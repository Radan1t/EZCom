using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Application.Interfaces.Services;
using Application.Common.DTO;
using Core.Entities;
using Infrastructure.Persistence.Data;  
using Infrastructure.Services;
using Infrastructure.Persistence.Repositories;
using EZCom.Application.Interfaces;
using AutoMapper;
using Application.Common.Mapping;
using Application.Interfaces;

namespace EZCom.Tests
{
    public class IntegrationTests
    {
        private DbContextOptions<ApplicationDbContext> _dbContextOptions;

        public IntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
        }

        private ApplicationDbContext CreateContext()
        {
            return new ApplicationDbContext(_dbContextOptions);
        }

        private IUnitOfWork CreateUnitOfWork()
        {
            var context = CreateContext();
            return new UnitOfWork(context);
        }

        private IRegistrationService CreateRegistrationService()
        {
            var unitOfWork = CreateUnitOfWork();
            var userRepository = new GenericRepository<User>(CreateContext());
            return new RegistrationService(userRepository, unitOfWork);
        }

        private ICompanyService CreateCompanyService()
        {
            var unitOfWork = CreateUnitOfWork();
            var productRepository = new GenericRepository<ProductVersionType>(CreateContext());
            var userRepository = new GenericRepository<User>(CreateContext());
            var mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
            return new CompanyService(productRepository, unitOfWork, userRepository, mapper);
        }

        [Fact]
        public async Task RegisterUserAsync_ShouldReturnTrue_WhenUserIsRegisteredSuccessfully()
        {
            var userDto = new UserDTO
            {
                First_name = "John",
                Last_name = "Doe",
                Login = "john_doe",
                E_mail = "john.doe@example.com",
                Phone_number = "+1234567890",
                Password = "SecurePassword!",
                Date_of_birthday = DateTime.UtcNow.AddYears(-25)
            };

            var registrationService = CreateRegistrationService();

            // Act
            var result = await registrationService.RegisterUserAsync(userDto);

            // Assert
            Assert.True(result);

            using (var context = CreateContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.Login == userDto.Login);
                Assert.NotNull(user);
                Assert.Equal(userDto.Login, user.Login);
                Assert.Equal(userDto.E_mail, user.E_mail);
            }
        }

        [Fact]
        public async Task IsLoginUnique_ShouldReturnFalse_WhenLoginExists()
        {
            var userDto = new UserDTO
            {
                First_name = "John",
                Last_name = "Doe",
                Login = "existingLogin",
                E_mail = "existing@example.com",
                Phone_number = "+1234567890",
                Password = "password123",
                Date_of_birthday = DateTime.UtcNow.AddYears(-25)
            };

            var registrationService = CreateRegistrationService();
            var isRegistered = await registrationService.RegisterUserAsync(userDto);
            Assert.True(isRegistered, "User should be successfully registered.");

            var isUnique = await registrationService.IsLoginUnique(userDto.Login);

            Assert.False(isUnique, "Login should not be unique because the user was just registered.");
        }

        [Fact]
        public async Task CreateCompanyAsync_ShouldCreateCompany_WhenValidDataIsProvided()
        {
            // Arrange
            var userDto = new UserDTO
            {
                First_name = "John",
                Last_name = "Doe",
                Login = "john_doe",
                E_mail = "john.doe@example.com",
                Phone_number = "+1234567890",
                Password = "SecurePassword!",
                Date_of_birthday = DateTime.UtcNow.AddYears(-25)
            };

            var registrationService = CreateRegistrationService();
            var isRegistered = await registrationService.RegisterUserAsync(userDto);

            Assert.True(isRegistered, "User is not registered");

            User user;
            using (var context = CreateContext())
            {
                user = await context.Users.FirstOrDefaultAsync(u => u.Login == userDto.Login);
            }

            Assert.NotNull(user);
            Assert.Equal(userDto.Login, user.Login);

            var companyDto = new CompanyDTO
            {
                Company_name = "Test Company",
                Contact_manager_name = "Manager Name",
                Contact_manager_phone = "+1234567890",
                Contact_manager_email = "manager@test.com",
                User_count = 10,
                ProductVersionTypeID = 1,
                Subscription_time = DateTime.UtcNow
            };

            var companyService = CreateCompanyService();

            // Act
            await companyService.CreateCompanyAsync(companyDto, user.Id); 

            // Assert
            using (var context = CreateContext())
            {
                var company = await context.Companies.FirstOrDefaultAsync(c => c.Company_name == companyDto.Company_name);
                Assert.NotNull(company);
                Assert.Equal(companyDto.Company_name, company.Company_name);
                Assert.Equal(companyDto.Contact_manager_name, company.Contact_manager_name);
                Assert.Equal(companyDto.Contact_manager_email, company.Contact_manager_email);

                var updatedUser = await context.Users.FirstOrDefaultAsync(u => u.Login == userDto.Login);
                Assert.NotNull(updatedUser);
                Assert.Equal(company.Id, updatedUser.CompanyID);
            }
        }

        [Fact]
        public async Task GetSubscriptionsAsync_ShouldReturnAllSubscriptions_WhenCalled()
        {
            // Arrange
            var companyService = CreateCompanyService();

            using (var context = CreateContext())
            {
                context.ProductVersionTypes.Add(new ProductVersionType
                {
                    Version_name = "Version 1",
                    Version_price = 99.99m,
                    User_count = 100
                });
                context.ProductVersionTypes.Add(new ProductVersionType
                {
                    Version_name = "Version 2",
                    Version_price = 149.99m,
                    User_count = 50
                });
                await context.SaveChangesAsync();
            }

            // Act
            var subscriptions = await companyService.GetSubscriptionsAsync();

            // Assert
            Assert.NotEmpty(subscriptions);
            Assert.Equal(2, subscriptions.Count()); 
        }

        [Fact]
        public async Task GetUserByIdAsync_ShouldReturnUser_WhenValidIdIsProvided()
        {
            // Arrange
            var userDto = new UserDTO
            {
                First_name = "John",
                Last_name = "Doe",
                Login = "john_doe",
                E_mail = "john.doe@example.com",
                Phone_number = "+1234567890",
                Password = "SecurePassword!",
                Date_of_birthday = DateTime.UtcNow.AddYears(-25)
            };

            var registrationService = CreateRegistrationService();
            var isRegistered = await registrationService.RegisterUserAsync(userDto);
            Assert.True(isRegistered, "User should be successfully registered.");

            using (var context = CreateContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.Login == userDto.Login);
                Assert.NotNull(user); 
                var userId = user.Id;  
                Assert.NotEqual(0, userId);  

                var userService = new CompanyService(
                    new GenericRepository<ProductVersionType>(context),
                    new UnitOfWork(context),
                    new GenericRepository<User>(context),
                    new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>())) 
                );


                var userById = await userService.GetUserByIdAsync(userId);

                Assert.NotNull(userById);
                Assert.Equal(user.First_name, userById.First_name);
                Assert.Equal(user.Last_name, userById.Last_name);
                Assert.Equal(user.Login, userById.Login);
                Assert.Equal(user.E_mail, userById.E_mail);
            }
        }
    }
}
