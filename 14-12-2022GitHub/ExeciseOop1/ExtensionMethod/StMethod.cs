using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop1.ExtensionMethod;
internal static class StMethod
{
    public static void ChangeColor<T>(this T items, params ConsoleColor[] cw) 
    {
        Console.BackgroundColor = cw[1];
        Console.ForegroundColor = cw[2];
    }

    public static bool In<T>(this T obj, params T[] items)
    {
        return items.Contains(obj);
    }
}
