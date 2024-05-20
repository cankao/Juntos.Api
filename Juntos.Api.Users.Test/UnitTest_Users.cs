using AutoFixture;
using Juntos.Api.Users.Domain.DTOs;
using Juntos.Api.Users.Domain.Interfaces;
using Juntos.Api.Users.Domain.Requests;
using Juntos.Api.Users.Infrastructure.Interfaces;
using Juntos.Api.Users.Services;
using Moq;

namespace Juntos.Api.Users.Test
{
    public class UnitTest_Users
    {
        [Fact]
        public async void ValidUsers_Inserir_RequestValido()
        {
            var usuarioRequest = new Fixture().Create<UserRequest>();
            var usuarioMock = new Mock<IUserRepository>();
            var usuarioServices = new UserService(usuarioMock.Object);

            var result = await usuarioServices.Insert(usuarioRequest);

            Assert.Equal(usuarioRequest.Login, result.Login);
            Assert.Equal(usuarioRequest.Email, result.Email);
        }

        [Fact]
        public async void ValidUsers_Inserir_RequestInValido()
        {
            var usuarioRequest = new Fixture().Create<UserRequest>();
            var usuarioMock = new Mock<IUserRepository>();
            var usuarioServices = new UserService(usuarioMock.Object);

            var result = await usuarioServices.Insert(usuarioRequest);

            usuarioRequest.Login = "";

            Assert.NotEqual(usuarioRequest.Login, result.Login);
        }


        [Fact]
        public async void ValidUsers_Delete_RequestValido()
        {
            var usuarioRequest = new Fixture().Create<UserRequest>();
            var usuarioMock = new Mock<IUserRepository>();
            var usuarioServices = new UserService(usuarioMock.Object);

            var result = await usuarioServices.Delete(usuarioRequest);

            Assert.NotEqual(usuarioRequest.Login, result.Login);
        }
    }
}