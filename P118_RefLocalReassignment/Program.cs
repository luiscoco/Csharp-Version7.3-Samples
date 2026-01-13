// C# 7.3: Reassign ref locals
using System;
class Program
{
    static void Main()
    {
        int x = 10, y = 20;
        ref int r = ref x;
        r = 11; // modifies x
        Console.WriteLine($"x={x}, y={y}");

        r = ref y; // reassign ref local to refer to y
        r = 21; // modifies y
        Console.WriteLine($"x={x}, y={y}");
    }
}
