// C# 7.3: 'enum' and 'delegate' generic constraints
using System;

static class EnumHelpers
{
    public static bool IsDefined<TEnum>(TEnum value) where TEnum : struct, Enum
        => Enum.IsDefined(typeof(TEnum), value);
}

static class DelegateHelpers
{
    public static TResult InvokeSafe<TDel, TResult>(TDel del) where TDel : Delegate
        => (TResult)del.DynamicInvoke();
}

enum Color { Red=1, Green=2, Blue=3 }

class Program
{
    static void Main()
    {
        Console.WriteLine(EnumHelpers.IsDefined(Color.Green));
        Func<int> f = () => 42;
        Console.WriteLine(DelegateHelpers.InvokeSafe<Func<int>, int>(f));
    }
}
