// C# 7.3: Tuple equality (== and !=) for System.ValueTuple
using System;
class Program
{
    static void Main()
    {
        var a = (x:1, y:2);
        var b = (x:1, y:2);
        var c = (x:2, y:3);
        Console.WriteLine(a == b); // True
        Console.WriteLine(a != c); // True
    }
}
