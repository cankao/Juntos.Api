using System.Text.Json.Serialization;

namespace Juntos.Api.Users.Domain.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }

        public bool PossuiCritica()
        {
            return ValidationResult.Errors.Count > 0;
        }
    }
}
