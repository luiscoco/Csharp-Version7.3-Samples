# C# 7.3 Features (VS 2017)

This solution demonstrates the **notable C# 7.3 language features**.

## Projects
- **P111_UnmanagedConstraint** — `where T : unmanaged` constraint.
- **P112_EnumDelegateConstraints** — `where T : Enum`, `where T : Delegate` constraints.
- **P113_TupleEquality** — `==` and `!=` for `System.ValueTuple`.
- **P114_RefLocalReassignment** — Reassign `ref` locals.
- **P115_InOverloadResolution** — Overload resolution prefers `in` when beneficial.
- **P116_FieldTargetOnAutoProperty** — `[field: ...]` attributes on auto-property backing fields.
- **P117_ConditionalRefExpression** — Conditional `ref` expression (`?:` returns by ref).
- **P118_LeadingUnderscores** — Allow leading underscores in numeric literals (e.g., `0x_FF`).

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P111_UnmanagedConstraint
```
Targets `.NET 10.0` with `<LangVersion>7.3</LangVersion>`.
