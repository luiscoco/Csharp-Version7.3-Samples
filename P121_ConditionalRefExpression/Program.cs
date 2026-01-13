// C# 7.3: Conditional ref expression (?:) result is by ref
using System;
class Program
{
    static ref int Pick(ref int a, ref int b, bool chooseA)
        => ref (chooseA ? ref a : ref b);

    static void Main()
    {
        int x=1, y=2;
        ref int r = ref Pick(ref x, ref y, chooseA:false);
        r = 99; // modifies y
        Console.WriteLine($"x={x}, y={y}");
    }
}
