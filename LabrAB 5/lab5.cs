using System;

namespace Points
{
    public class TPoint2D
    {
        static void Main(string[] args)
        {
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            Console.WriteLine("\n" + "Координати першої точки: {0};{1}", p1.ReturnX(), p1.ReturnY());
            Console.WriteLine("Координати другої точки: {0};{1}", p2.ReturnX(), p2.ReturnY());

            Console.WriteLine("\n" + "Відстань між двума точками: {0}", Point.Size(p1, p2))
            Console.WriteLine("Расстояние от первой точки до начала координат {0}", p1.DistanceToStart());
            Console.WriteLine("Расстояние от второй точки до начала координат {0}", p2.DistanceToStart());
        }
    }

    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public double ReturnX()
        {
            return this.x;
        }

        public double ReturnY()
        {
            return this.y;
        }
    
        public Point(double xP, double yP)
        {
            x = xP;
            y = yP;
        }

        public double DistanceToStart()
        {
            double size;

            size = Math.Sqrt(this.x * this.x + this.y * this.y);
            return size;
        }
    }
}


    public class TCRectangle : TPoint2D
        {
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());
            Console.Write("x4: ");
            double x4 = double.Parse(Console.ReadLine());
            Console.Write("y4: ");
            double y4 = double.Parse(Console.ReadLine());
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);
}