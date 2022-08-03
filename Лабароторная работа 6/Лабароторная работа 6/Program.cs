using static System.Convert;
using static System.Console;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                PostOficce.info();
                WriteLine("Для выхода из программы нажмите любую клавишу...");
                ReadKey();
                flag = false;
            } while (flag);
        }
    }
}