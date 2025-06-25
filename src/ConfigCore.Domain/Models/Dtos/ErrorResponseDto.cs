namespace ConfigCore.Domain.Models.Dtos;

public class ErrorResponseDto
{
    public IEnumerable<string> Errors { get; set; } = [];
}
