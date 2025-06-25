namespace ConfigCore.Domain.Models.Pagination;

public class PaginatedResult<T>
{
    public PaginationInfo PaginationInfo { get; set; } = null!;

    public IEnumerable<T> Items { get; set; } = null!;
}