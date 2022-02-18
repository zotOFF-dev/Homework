using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Депозитный_калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Депозитный калькулятор");
            double P=0, S=0, I=0, t=0;
            const int K = 365;
            Console.WriteLine("Введите сумму вклада");
            P= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процентную ставку");
            I = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество дней  на которое будет рассчитан вклад");
            t = Convert.ToDouble(Console.ReadLine());
            S = P + (P * I * t) / (K * 100);
            Console.WriteLine("Конечная сумма вклада= " + S);
            Console.ReadKey();

        }
    }
}
