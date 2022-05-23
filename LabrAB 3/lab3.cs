using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Monitor();
            Console.WriteLine();
        }
    }
    class Monitor
    {
        public string firma_vyrobnyk;
        public DateTime data_vyrobnyctva;
        public DateTime data_kupivly;
        public DateTime data_teper;
        public int cina_monitora;
        public string typ_monitora;
        public double[] rozmiry_monitora;
        public int vik_monitora;
        public double[] rozmir_zobrazhennya;
        public double koefficient;
        public Monitor()
        {
            firma_vyrobnyk = "HP";
            Console.Write("Дата виробництва : ");
            data_vyrobnyctva = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Дата купiвлi : ");
            data_kupivly = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Цiна монiтора : ");
            cina_monitora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тип Монiтора : ");
            typ_monitora = Convert.ToString(Console.ReadLine());
            Console.Write("Розмiр монiтора : ");
            rozmiry_monitora = new double[2];
            for (int i = 0; i < 2; i++)
            {
                rozmiry_monitora[i] = Convert.ToDouble(Console.ReadLine());
            }
            data_teper = DateTime.Now;
            vik_monitora = data_teper.Year - data_vyrobnyctva.Year;
            Console.Write("Розмiр картинки : ");
            rozmir_zobrazhennya = new double[2];
            for (int i = 0; i < 2; i++)
            {
                rozmir_zobrazhennya[i] = Convert.ToDouble(Console.ReadLine());
            }
            var riznycya = new double[2];
            for (int i = 0; i < 2; i++)
            {
                riznycya[i] = rozmiry_monitora[i] - rozmir_zobrazhennya[i];
            }

            koefficient = riznycya[0] / riznycya[1];
            data_teper = DateTime.Now;
     
            Print();
        }
        public void Print()
        {
            Console.WriteLine($"Дата виробництва: {data_vyrobnyctva}");
            Console.WriteLine($"Дата купiвлi: {data_kupivly}");
            Console.WriteLine($"Цiна: {cina_monitora}$");
            Console.WriteLine($"Тип монітора: {typ_monitora}");
            Console.WriteLine($"Вiк монiтора: {vik_monitora}");
            Console.WriteLine($"Розмiр монiтора: {rozmiry_monitora[0]},{rozmiry_monitora[1]}");
            Console.WriteLine($"Розмiр зображення: {rozmir_zobrazhennya[0]},{rozmir_zobrazhennya[1]}");
            Console.WriteLine($"Коеф. маштабування: {koefficient}");
            if (koefficient == 0)
            {
                Console.WriteLine("Можна вивести без масштабування");
            }
            else
            {
                Console.WriteLine("Не можна вивести без масштабування");
            }
        }
    }
}