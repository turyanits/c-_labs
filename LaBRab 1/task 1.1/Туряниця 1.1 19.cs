using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MinMax19
{
    public static void Main()
    {
        int a, b, max1, max2, max3, res;
        Console.Write("(max(a,0) * max(b,0) / max(a,b)...............");
        Console.Write("Введіть значення а:");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введіть значення b:");
        b = int.Parse(Console.ReadLine());
        max1 = Math.Max(a, 0);
        max2 = Math.Max(b, 0);
        max3 = Math.Max(a, b);
        res = (max1 * max2) / max3;
        Console.WriteLine("Відповідь:" + res);
        Console.ReadKey();
    }
}