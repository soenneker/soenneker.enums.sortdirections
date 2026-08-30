[![](https://img.shields.io/nuget/v/soenneker.enums.sortdirections.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.sortdirections/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.sortdirections/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.sortdirections/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.sortdirections.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.sortdirections/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.sortdirections/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.sortdirections/actions/workflows/codeql.yml)

# Soenneker.Enums.SortDirections

A string-backed enum-value type for carrying an ascending or descending sort direction in query contracts.

## Install

```bash
dotnet add package Soenneker.Enums.SortDirections
```

## Usage

```csharp
using Soenneker.Enums.SortDirections;

SortDirection direction = SortDirection.Asc;
string wireValue = direction.Value; // "asc"

if (SortDirection.TryFromValue(input, out SortDirection? parsed))
{
    direction = parsed;
}
```

Available wire values:

- `SortDirection.Asc` → `"asc"`
- `SortDirection.Desc` → `"desc"`

`System.Text.Json` serializes the type as its lowercase value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` for query parameters. `FromName` and `TryFromName` use the C# member names, `"Asc"` and `"Desc"`.

The type supplies direction only. The query implementation defines ordering for strings, nulls, dates, and locale-sensitive data. Validate sort fields against an explicit allowlist and build queries with the target API or database's parameterized expression mechanisms; a valid direction does not make an arbitrary field name safe.
