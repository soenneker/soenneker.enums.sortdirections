[![](https://img.shields.io/nuget/v/soenneker.enums.sortdirections.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.sortdirections/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.sortdirections/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.sortdirections/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.sortdirections.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.sortdirections/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.sortdirections/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.sortdirections/actions/workflows/codeql.yml)

# Soenneker.Enums.SortDirections

Identifies whether query results are ordered from lower to higher values or from higher to lower values.

## Install

```bash
dotnet add package Soenneker.Enums.SortDirections
```

## What you get

- `SortDirection` — Identifies whether query results are ordered from lower to higher values or from higher to lower values.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `SortDirection.Asc` | Ascending order, from lower to higher values. | Ascending order, from lower to higher values. |
| `SortDirection.Desc` | Descending order, from higher to lower values. | Descending order, from higher to lower values. |
