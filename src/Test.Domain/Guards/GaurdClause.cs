using Test.Domain.Models;

namespace Test.Domain.Guards;

// TODO
// 1. move description to Resource file
// 2. Throw exception or return validation set?
// 3. Use validation framework?

// 2. and 3. is to decide by team
public static class GaurdClause
{
    public static InvalidInput? GreaterThenZero(this int? value, string propertyName)
    {
        if (value is < 0)
        {
            return new InvalidInput { Name = propertyName, Description = $"{propertyName} cannot be smaller then 0." };
        }
        return null;
    }

    public static InvalidInput? IsNullEmptyOrWhiteSpace(this string? value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return new InvalidInput { Name = propertyName, Description = $"{propertyName} cannot be null or empty/whitespace only." };
        }
        return null;
    }
}
