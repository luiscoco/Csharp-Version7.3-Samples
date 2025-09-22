// C# 7.3: Overload resolution prefers 'in' arguments when appropriate
using System;
struct Big { public int A,B,C,D; }
class Program
{
    static void F(in Big b) { Console.WriteLine("in Big"); }
    static void F(Big b) { Console.WriteLine("by value Big"); }

    static void Main()
    {
        var big = new Big();
        // Passing a variable chooses the 'in' overload to avoid a defensive copy
        F(big);
    }
}
