namespace ConfigCore.Domain.Models.Dtos;

public class ChangePasswordRequestDto
{
    public Ulid UserId { get; set; }
 
    public string CurrentPassword { get; set; } = string.Empty;

    public string NewPassword { get; set; } = string.Empty;
}