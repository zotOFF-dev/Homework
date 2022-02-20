using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время_решений_задач
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько времени ушло на решение задач");
            int h1, min1, h2, min2, min,h, m;
            Console.WriteLine("Введите поочередно часы и минуты, которые показывали часы перед началом работы");
            h1 =Convert.ToInt32(Console.ReadLine());
            min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите поочередно часы и минуты, которые показывали часы после окончания работы");
            h2 = Convert.ToInt32(Console.ReadLine());
            min2 = Convert.ToInt32(Console.ReadLine());
            if (h2 == 0)
            {
                m = (24 * 60 + min2) - (h1 * 60 + min1);
            }
            else m = (h2 * 60 + min2) - (h1 * 60 + min1);
            h = Math.Abs(m / 60);
            min = Math.Abs(m % 60);
            if ((h2<h1) && (min2 == min1) && h2 == 0)
            {
                h = Math.Abs(h-24);
            }
            if (h2 < h1)
            {
                h = 24 - h;
                min =Math.Abs(min2 - min1);
            }
            if ((h2<h1) && (min2>min1))
            {
                h = h-1;
                min =Math.Abs(min2 - min1);
            }
            if (h2 > h1)
            {
                h = Math.Abs(m / 60);
                min = Math.Abs(m % 60);
            }
            if ((h2 == h1) && (min1 == min2))
            {
                h = 24;
            }
                if (min2<min1)
            {
                min =60- Math.Abs(min2-min1);
            }
            if ((h2 == h1) && (min2>min1))
            {
                h =0;
                min = Math.Abs(m % 60);
            }
            if ((h2 == h1) && (min1 > min2))
            {
                h = 24 - h - 1; 
                min =60- Math.Abs(m % 60);
            }
            Console.WriteLine($"Время затраченное на работу часы= {h} минуты= {min}");
            Console.ReadKey();
        }
    }
}
