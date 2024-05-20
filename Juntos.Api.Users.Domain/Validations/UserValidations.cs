using FluentValidation;
using Juntos.Api.Users.Domain.DTOs;

namespace Juntos.Api.Users.Domain.Validations
{
    public class UserValidations : AbstractValidator<UserDTO>
    {
        public UserValidations() {
            RuleFor(p => p.Login).NotNull().NotEmpty()
                .WithMessage("Nome não informado!");

            RuleFor(p => p.Email).NotNull().NotEmpty()
                .WithMessage("Email não informado!");

            RuleFor(p => p.Password).NotNull().NotEmpty()
                .WithMessage("Password não informado!");
        }
    }
}
