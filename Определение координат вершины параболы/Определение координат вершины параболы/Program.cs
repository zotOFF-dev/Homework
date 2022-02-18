using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Определение_координат_вершины_параболы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение координат вершины пораболы");
            double a,b,c,x0,y0;
            Console.WriteLine("Введите поочередно значения a,b,c уравнения пораболы y=ax^2+bx+c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            x0 = -b / (2 * a);
            y0 = a * Math.Pow(x0, 2) + b * x0 + c;

            Console.WriteLine($"Координата х0= {x0} Координата у0= {y0}");
            Console.ReadKey();
        }
    }
}
