// C# 7.3: Attributes on auto-property backing fields using 'field:' target
using System;

[AttributeUsage(AttributeTargets.Field)]
sealed class MarkerAttribute : Attribute {}

class Sample
{
    [field: Marker] // applies to the compiler-generated backing field
    public int Value { get; set; }
}

class Program
{
    static void Main()
    {
        var attrs = typeof(Sample).GetField("<Value>k__BackingField", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetCustomAttributes(false);
        Console.WriteLine("Backing field attributes: " + attrs.Length);
    }
}
