using Intellenum;

namespace Soenneker.Enums.SortDirections;

/// <summary>
/// An enumerator for sort direction during querying
/// </summary>
[Intellenum<string>]
public sealed partial class SortDirection
{
    public static readonly SortDirection Asc = new(nameof(Asc));
    public static readonly SortDirection Desc = new(nameof(Desc));
}
