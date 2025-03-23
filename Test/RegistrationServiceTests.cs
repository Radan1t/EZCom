using System;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.Application.Interfaces;
using Infrastructure.Services;
using Moq;
using Xunit;

namespace EZCom.Tests
{
    public class RegistrationServiceTests
    {
        private readonly Mock<IGenericRepository<User>> _userRepositoryMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly IRegistrationService _registrationService;

        public RegistrationServiceTests()
        {
            _userRepositoryMock = new Mock<IGenericRepository<User>>();
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _registrationService = new RegistrationService(_userRepositoryMock.Object, _unitOfWorkMock.Object);
        }

        [Fact]
        public async Task IsLoginUnique_ShouldReturnTrue_WhenLoginIsUnique()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetFirstOrDefaultAsync(u => u.Login == "uniqueLogin"))
                .ReturnsAsync((User)null);

            // Act
            var result = await _registrationService.IsLoginUnique("uniqueLogin");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task IsLoginUnique_ShouldReturnFalse_WhenLoginExists()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetFirstOrDefaultAsync(u => u.Login == "existingLogin"))
                .ReturnsAsync(new User { Login = "existingLogin" });

            // Act
            var result = await _registrationService.IsLoginUnique("existingLogin");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task RegisterUserAsync_ShouldReturnTrue_WhenUserIsRegisteredSuccessfully()
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

            var userRepoMock = new Mock<IGenericRepository<User>>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(userRepoMock.Object);

            // Act
            var result = await _registrationService.RegisterUserAsync(userDto);

            // Assert
            Assert.True(result);
            userRepoMock.Verify(repo => repo.InsertAsync(It.IsAny<User>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.SaveAsync(), Times.Once);
        }

        [Fact]
        public async Task RegisterUserAsync_ShouldThrowException_WhenDbUpdateFails()
        {
            // Arrange
            var userDto = new UserDTO
            {
                Login = "errorUser",
                E_mail = "error@example.com",
                Password = "password"
            };

            var userRepoMock = new Mock<IGenericRepository<User>>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(userRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveAsync()).ThrowsAsync(new Exception("DB update error"));

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => _registrationService.RegisterUserAsync(userDto));
        }

        [Fact]
        public async Task IsEmailUnique_ShouldReturnTrue_WhenEmailIsUnique()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetFirstOrDefaultAsync(u => u.E_mail == "unique@example.com"))
                .ReturnsAsync((User)null);

            // Act
            var result = await _registrationService.IsEmailUnique("unique@example.com");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task IsEmailUnique_ShouldReturnFalse_WhenEmailExists()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetFirstOrDefaultAsync(u => u.E_mail == "existing@example.com"))
                .ReturnsAsync(new User { E_mail = "existing@example.com" });

            // Act
            var result = await _registrationService.IsEmailUnique("existing@example.com");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task IsPhoneNumberUnique_ShouldReturnTrue_WhenPhoneNumberIsUnique()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetFirstOrDefaultAsync(u => u.Phone_number == "+1234567890"))
                .ReturnsAsync((User)null);

            // Act
            var result = await _registrationService.IsPhoneNumberUnique("+1234567890");

            // Assert
            Assert.True(result);
        }
    }
}
