using System;

 public class Program
{
    public Program()
    {
        float ser_arif, median;
        int a, b, c, d, n;
        Console.Write("Введіть 4-х значне число n:");
        n = int.Parse(Console.ReadLine());
        a = n / 1000;
        b = n % 1000 / 100;
        c = n % 100 / 10;
        d = n % 10;
        ser_arif = (a + b + c + d) / 4;
        median = (b + c) / 2;
        Console.WriteLine("Середнэ арифметичне:" + ser_arif);
        Console.WriteLine("Медіана:" + median);
        Console.ReadKey();
        Console.ReadKey();
    }
}