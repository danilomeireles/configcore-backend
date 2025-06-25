namespace ConfigCore.Domain.Models.Dtos;

public sealed class UserRegistrationResponseDto
{
    public Ulid UserId { get; set; }
    public string Email { get; set; } = string.Empty;
}