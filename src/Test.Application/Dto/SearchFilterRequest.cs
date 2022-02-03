namespace Test.Application.Dto;

public class SearchFilterRequest
{
    public bool? Active { get; set; }

    public string? Name { get; set; }

    public int? PageSize { get; set; }
}
