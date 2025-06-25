namespace ConfigCore.Domain.Models.Dtos;

public sealed class LoginRequestDto
{
    public string Email { get; set; } = string.Empty;
    
    public string PlainPassword { get; set; } = string.Empty;
}