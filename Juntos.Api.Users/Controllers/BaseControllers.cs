namespace Juntos.Api.Users.App.Controllers
{
    using Juntos.Api.Users.Domain.DTOs;
    using Juntos.Api.Users.Domain.Responses;
    using Microsoft.AspNetCore.Mvc;

    public class BaseController : ControllerBase
    {
        
        protected async Task<UserResponse> CustomResponse(UserDTO user)
        {
            var response = new UserResponse
            {
                Login = user.Login,
                Email = user.Email
            };
            
            if (user.PossuiCritica())
            {
                user.ValidationResult.Errors.ForEach(erro => { response.Messages.Add(erro.ErrorMessage); });
            }
            else
            {
                response.Messages.Add("Sucesso!");
            }

            return response;
        }

    }
}

