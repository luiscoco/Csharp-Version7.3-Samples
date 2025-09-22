// C# 7.3: 'unmanaged' generic constraint
using System;
struct Pair<T1,T2> where T1 : unmanaged where T2 : unmanaged
{
    public T1 A; public T2 B;
    public Pair(T1 a, T2 b){ A=a; B=b; }
    public unsafe void PrintBytes()
    {
        Console.WriteLine($"sizeof(T1)={sizeof(T1)}, sizeof(T2)={sizeof(T2)}");
    }
}
class Program
{
    static void Main()
    {
        var p = new Pair<int, double>(1, 2.0);
        p.PrintBytes();
        // var bad = new Pair<string,int>(); // won't compile: string not unmanaged
        Console.WriteLine("OK");
    }
}
