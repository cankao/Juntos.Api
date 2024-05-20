namespace Juntos.Api.Users.Domain.Responses
{
    public class UserResponse
    {
        public string? Login { get; set; }
        public string? Email { get; set; }
        public List<string> Messages { get; set; }
    }
}
