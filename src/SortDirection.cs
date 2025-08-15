using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.SortDirections;

/// <summary>
/// An enumerator for sort direction during querying
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public sealed partial class SortDirection
{
    public static readonly SortDirection Asc = new("asc");
    public static readonly SortDirection Desc = new("desc");
}
