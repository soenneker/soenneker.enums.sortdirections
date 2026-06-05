using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.SortDirections;

/// <summary>
/// An enumerator for sort direction during querying
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class SortDirection
{
    /// <summary>
    /// The asc.
    /// </summary>
    public static readonly SortDirection Asc = new("asc");
    /// <summary>
    /// The desc.
    /// </summary>
    public static readonly SortDirection Desc = new("desc");
}