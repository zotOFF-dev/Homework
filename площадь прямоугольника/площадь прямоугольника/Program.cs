using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace площадь_прямоугольника
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Площадь и периметр прямоугольника");
            double a, b, S, P,c,d,S1,P1;
            Console.WriteLine("Введите длину");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            b = Convert.ToDouble(Console.ReadLine());
            S = a * b;
            P = 2 * (a + b);
            Console.WriteLine("Площадь прямоугольника= "+S);
            Console.WriteLine("Периметр прямоугольника= " +P);
            Console.WriteLine("Площадь и периметр прямоугольного треугольника");
            Console.WriteLine("Введите первый катет");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            d = Convert.ToDouble(Console.ReadLine());
            S1 = (c * d) / 2;
            P1 = c + d + Math.Sqrt(c * c + d * d);
            Console.WriteLine("Площадь треугольника= " + S1);
            Console.WriteLine("Периметр треугольника= " + P1);
            Console.ReadKey();
        }
    }
}
