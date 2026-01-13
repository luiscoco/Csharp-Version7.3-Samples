# C# 7.3 Features – Sample Projects

This repository contains hands-on examples of the new features introduced in **C# version 7.3**.  
Each project (`P115`, `P116`, …) illustrates one feature with runnable code.

---

## New Features in C# 7.3

### P115_UnmanagedConstraint
- **What’s new**: Constrain generics to unmanaged (blittable) types.  
- **Example**:
  ```csharp
  void Fill<T>(Span<T> span, T value) where T : unmanaged
  {
      for (int i = 0; i < span.Length; i++) span[i] = value;
  }
  ```

---

### P116_EnumDelegateConstraints
- **What’s new**: Constrain generics to `Enum` or `Delegate`.  
- **Example**:
  ```csharp
  static string[] Names<T>() where T : Enum => Enum.GetNames(typeof(T));
  static void Invoke<T>(T d) where T : Delegate => d.DynamicInvoke();
  ```

---

### P117_TupleEquality
- **What’s new**: Compare tuples with `==` / `!=`.  
- **Example**:
  ```csharp
  var a = (1, 2);
  var b = (1, 2);
  Console.WriteLine(a == b); // True
  ```

---

### P118_RefLocalReassignment
- **What’s new**: Reassign ref locals/parameters.  
- **Example**:
  ```csharp
  ref int r = ref array[0];
  r = ref array[1];
  ```

---

### P119_InOverloadResolution
- **What’s new**: Overload resolution improved for `in` parameters.  
- **Example**:
  ```csharp
  void M(in int x) { }
  void M(object o) { }
  int n = 42;
  M(n); // prefers M(in int)
  ```

---

### P120_FieldTargetOnAutoProperty
- **What’s new**: Apply attributes to backing fields.  
- **Example**:
  ```csharp
  [field: NonSerialized]
  public string? Cache { get; private set; }
  ```

---

### P121_ConditionalRefExpression
- **What’s new**: Conditional operator `?:` supports ref returns.  
- **Example**:
  ```csharp
  ref int Pick(bool left, ref int a, ref int b)
      => ref (left ? ref a : ref b);
  ```

---

### P122_LeadingUnderscores
- **What’s new**: Allow leading underscores in numeric literals.  
- **Example**:
  ```csharp
  int hex = 0x_FF_FF;
  int bin = 0b_1010_0001;
  ```

---

## Repository Structure

- `P115_UnmanagedConstraint` → unmanaged generics  
- `P116_EnumDelegateConstraints` → Enum/Delegate constraints  
- `P117_TupleEquality` → tuple equality  
- `P118_RefLocalReassignment` → reassign ref locals  
- `P119_InOverloadResolution` → overload resolution with in  
- `P120_FieldTargetOnAutoProperty` → field-target attributes  
- `P121_ConditionalRefExpression` → conditional ref  
- `P122_LeadingUnderscores` → leading underscores in literals  

---

## Requirements

- .NET Framework / .NET Core projects with `<LangVersion>7.3</LangVersion>`  
- Default for .NET Framework 4.7.2+ and .NET Core 2.1+  

**Build & run:**
```bash
dotnet restore
dotnet build
dotnet run --project P111_UnmanagedConstraint
```

---

## References

- Microsoft Docs – *C# language version history*  
- .NET Blog – *What’s new in C# 7.3*  
