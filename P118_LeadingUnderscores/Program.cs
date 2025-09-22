// C# 7.3: Allow leading underscores after base specifier in numeric literals
using System;
class Program
{
    static void Main()
    {
        int hex = 0x_FF_FF;
        int bin = 0b_0101_0001;
        Console.WriteLine($"hex={hex}, bin={bin}");
    }
}
