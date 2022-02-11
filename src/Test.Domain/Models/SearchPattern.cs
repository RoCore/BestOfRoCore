using Test.Domain.Guards;

namespace Test.Domain.Models;

public class SearchPattern
{
    public bool? IsActive { get; private set; }

    public string? Name { get; private set; }

    public int? PageSize { get; private set; }

    private SearchPattern(bool? isActive, string? name, int? pageSize)
    {
        IsActive = isActive;
        Name = name;
        PageSize = pageSize;
    }

    // not the best practice, because the validation can be made on API level too and this will be much convenient.
    public static void Validate(string? name, int? pageSize)
    {
        //throw each time: validate only one parameter at time
        //throw after all params checked: find a good solution to handle this
        var exceptions = new List<InvalidInput>
            {
                pageSize.GreaterThenZero(nameof(pageSize))!,
                name.IsNullEmptyOrWhiteSpace(nameof(name))!
            };
        exceptions = exceptions.Where(a => a != null).ToList();

        if (exceptions.Count > 0)
        {
            throw new Exception() { }; // TODO custom exception with invalid input list
        }
    }

    public static SearchPattern Create(bool? isActive, string? name, int? pageSize)
    {
        return new SearchPattern(isActive, name, pageSize);
    }
}
