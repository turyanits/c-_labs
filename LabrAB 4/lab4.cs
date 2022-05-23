using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

// 7. Клас “круг” – TCircle
namespace lab4
{
    public static class TCircle
    {
        private static void Main()
        {
            Circle circle = new Circle(1, new Point(0, 0));
            Console.WriteLine(circle);
            Console.WriteLine("Перевірка на належність точки кругу:");
            Console.WriteLine(circle.IsInside(new Point(0.1, 0.1)));
            Console.WriteLine("Площа:");
            Console.WriteLine(circle.Square);
            Console.WriteLine("Довжина кола:");
            Console.WriteLine(circle.Circuit);
            Console.ReadKey();
        }
    }

    public class Circle
    {

        public double Radius { get; set; }
        public Point Center { get; set; }

        public Circle(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }


        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public bool IsInside(Point point)
        {
            Point vector = new Point(point.X - Center.X, point.Y - Center.Y);
            double distance = vector.X * vector.X + vector.Y * vector.Y;
            return distance <= Radius * Radius;
        }

        public override string ToString()
        {
            return String.Format("Радіус: {0}; Центр кругу: {1};", Radius, Center);
        }
    }
}