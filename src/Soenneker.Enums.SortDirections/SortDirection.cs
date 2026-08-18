using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.SortDirections;

/// <summary>
/// Identifies whether query results are ordered from lower to higher values or from higher to lower values.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class SortDirection
{
    /// <summary>
    /// Ascending order, from lower to higher values.
    /// </summary>
    public static readonly SortDirection Asc = new("asc");
    /// <summary>
    /// Descending order, from higher to lower values.
    /// </summary>
    public static readonly SortDirection Desc = new("desc");
}
