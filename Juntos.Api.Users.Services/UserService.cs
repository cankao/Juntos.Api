using AutoMapper;
using Juntos.Api.Users.Domain.DTOs;
using Juntos.Api.Users.Domain.Interfaces;
using Juntos.Api.Users.Domain.Requests;
using Juntos.Api.Users.Domain.Validations;
using Juntos.Api.Users.Infrastructure.Interfaces;

namespace Juntos.Api.Users.Services
{
    public class UserService : IUserService
    {
        IUserRepository _repository;
        IMapper _mapper;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserDTO> Delete(UserRequest user)
        {
            var userDto = _mapper.Map<UserDTO>(user);

            userDto.ValidationResult = new UserValidations().Validate(userDto);

            if (userDto.PossuiCritica())
                return userDto;

            var retorno = await _repository.Delete(userDto);

            if (retorno <= 0)
                userDto.ValidationResult.Errors.Add(new FluentValidation.Results.ValidationFailure("", "Nenhum registro alterado!"));

            return userDto;
        }

        public async Task<UserDTO> Insert(UserRequest user)
        {
            var userDto = _mapper.Map<UserDTO>(user);

            userDto.ValidationResult = new UserValidations().Validate(userDto);

            if (userDto.PossuiCritica())
                return userDto;

            var retorno = await _repository.Insert(userDto);

            if (retorno <= 0)
                userDto.ValidationResult.Errors.Add(new FluentValidation.Results.ValidationFailure("", "Nenhum registro alterado!"));

            return userDto;
        }

        public async Task<UserDTO> Update(UserRequest user)
        {
            var userDto = _mapper.Map<UserDTO>(user);

            userDto.ValidationResult = new UserValidations().Validate(userDto);

            if (userDto.PossuiCritica())
                return userDto;

            var retorno = await _repository.Update(userDto);

            if (retorno <= 0)
                userDto.ValidationResult.Errors.Add(new FluentValidation.Results.ValidationFailure("", "Nenhum registro alterado!"));
               

            return userDto;
        }
    }
}
