using System;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using Application.Common.DTO;
using Moq;
using Xunit;

namespace EZCom.Tests
{
    public class LoginServiceTests
    {
        [Fact]
        public async Task LoginAsync_ValidUsername_ReturnsUserDTO()
        {
            var mockLoginService = new Mock<ILoginService>();
            var expectedUser = new UserDTO
            {
                Id = 1,
                First_name = "John",
                Last_name = "Doe",
                Login = "johndoe",
                Password = "hashedpassword",
                E_mail = "johndoe@example.com",
                Phone_number = "+1234567890",
                Date_of_birthday = new DateTime(1990, 5, 20),
                UserTypeID = 2,
                CompanyID = 10
            };

            mockLoginService
                .Setup(service => service.LoginAsync("johndoe", "password123"))
                .ReturnsAsync(expectedUser);

            var loginService = mockLoginService.Object;

            var result = await loginService.LoginAsync("johndoe", "password123");

            Assert.NotNull(result);
            Assert.Equal(expectedUser.Id, result.Id);
            Assert.Equal(expectedUser.First_name, result.First_name);
            Assert.Equal(expectedUser.Last_name, result.Last_name);
            Assert.Equal(expectedUser.Login, result.Login);
            Assert.Equal(expectedUser.E_mail, result.E_mail);
            Assert.Equal(expectedUser.Phone_number, result.Phone_number);
            Assert.Equal(expectedUser.Date_of_birthday, result.Date_of_birthday);
            Assert.Equal(expectedUser.UserTypeID, result.UserTypeID);
            Assert.Equal(expectedUser.CompanyID, result.CompanyID);
        }

        [Fact]
        public async Task LoginAsync_ValidEmail_ReturnsUserDTO()
        {
            var mockLoginService = new Mock<ILoginService>();
            var expectedUser = new UserDTO
            {
                Id = 1,
                First_name = "John",
                Last_name = "Doe",
                Login = "johndoe",
                Password = "hashedpassword",
                E_mail = "johndoe@example.com",
                Phone_number = "+1234567890",
                Date_of_birthday = new DateTime(1990, 5, 20),
                UserTypeID = 2,
                CompanyID = 10
            };

            mockLoginService
                .Setup(service => service.LoginAsync("johndoe@example.com", "password123"))
                .ReturnsAsync(expectedUser);

            var loginService = mockLoginService.Object;

            var result = await loginService.LoginAsync("johndoe@example.com", "password123");

            Assert.NotNull(result);
            Assert.Equal(expectedUser.Id, result.Id);
            Assert.Equal(expectedUser.First_name, result.First_name);
            Assert.Equal(expectedUser.Last_name, result.Last_name);
            Assert.Equal(expectedUser.Login, result.Login);
            Assert.Equal(expectedUser.E_mail, result.E_mail);
            Assert.Equal(expectedUser.Phone_number, result.Phone_number);
            Assert.Equal(expectedUser.Date_of_birthday, result.Date_of_birthday);
            Assert.Equal(expectedUser.UserTypeID, result.UserTypeID);
            Assert.Equal(expectedUser.CompanyID, result.CompanyID);
        }

        [Fact]
        public async Task LoginAsync_InvalidUsername_ReturnsNull()
        {

            var mockLoginService = new Mock<ILoginService>();

   
            mockLoginService
                .Setup(service => service.LoginAsync("wrongusername", "wrongpassword"))
                .ReturnsAsync((UserDTO)null); 

            var loginService = mockLoginService.Object;

            var result = await loginService.LoginAsync("wrongusername", "wrongpassword");


            Assert.Null(result); 
        }
    }
}
