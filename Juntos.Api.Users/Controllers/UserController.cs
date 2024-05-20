using Juntos.Api.Users.App.Controllers;
using Juntos.Api.Users.Domain.Interfaces;
using Juntos.Api.Users.Domain.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Juntos.Api.Users.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : BaseController
    {
        IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] UserRequest user)
        {
            var retorno = CustomResponse(await _service.Insert(user));

            return Ok(retorno);
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserRequest request)
        {
            var retorno = CustomResponse(await _service.Update(request));

            return Ok(retorno);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] UserRequest request)
        {
            var retorno = CustomResponse(await _service.Delete(request));

            return Ok(retorno);
        }
    }
}