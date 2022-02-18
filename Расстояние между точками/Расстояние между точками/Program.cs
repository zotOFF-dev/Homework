using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расстояние_между_точками
{
    class Programm
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Расстояние между точками");
            double x1, y1, x2, y2, d;
            Console.WriteLine("Введите x1 координату точки М1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1 координату точки М1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2 координату точки М2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2 координату точки М2");
            y2 = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            Console.WriteLine("Расстояние между точками М1 и М2 " + d);
            Console.ReadKey();
        }
    }
}

