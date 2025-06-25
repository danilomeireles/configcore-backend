namespace ConfigCore.Domain.Models.Pagination;

public abstract class PaginationInfo
{
    public int CurrentPageNumber { get; set; }
    
    public int ItemsPerPage { get; set; }
    
    public int ItemsInTheCurrentPage { get; set; }
    
    public int TotalPages { get; set; }

    public int TotalItems { get; set; }
    
    public bool HasPreviousPage => (CurrentPageNumber > 1);

    public bool HasNextPage => (CurrentPageNumber < TotalPages);
}