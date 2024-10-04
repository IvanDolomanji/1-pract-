using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program//Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("x3=");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y1=");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("y3=");
            int y3 = int.Parse(Console.ReadLine());
            double ab = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            double bc = Math.Sqrt(Math.Pow((x3 - x2),2) + Math.Pow((y3 - y2),2));
            double ac = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
            double p = ab + bc + ac;
            double pp = (ab + bc + ac) /2;
            double s = Math.Sqrt(pp * (pp - ab) * (pp - bc) * (pp - ac));
            Console.WriteLine($"Периметр равен - {p:f2}\nПлощадь равна - {s:f2}");
            Console.Read();



        }
    }
}
