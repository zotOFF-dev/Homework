using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = InputIntValue("Введите возраст кошки");
            Cat myCat = new Cat()
            {
                Age = age
            };
            Console.WriteLine("Введите имя кошки: ");
            myCat.Name = Console.ReadLine();
            Console.WriteLine("Попробуйте ввести другое имя:");
            myCat.Name = Console.ReadLine();

            while (myCat.Health > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("I (info) - показать информацию о кошке");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("F (feed) - покормить кошку");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("P (punish) - наказать кошку");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Esc - выход");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("==============");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.I:
                        PrintCatInfo(myCat);
                        break;
                    case ConsoleKey.F:
                        myCat.Feed(InputIntValue("Введите количество единиц еды для кошки"));
                        Console.WriteLine("Кошка сыта. Нажмите любую клашиву для продолжения");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.P:
                        myCat.Punish(InputIntValue("Введите количество ударов для кошки"));
                        Console.WriteLine("Кошка наказана. Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        myCat.Punish(int.MaxValue);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нераспознанная команда. Нажмите любую клавишу чтобы продолжить");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Кошка мертва.Живите с этим");
            Console.ReadKey();
        }
        static int InputIntValue(string message)
        {
            int result = 0;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(message);

                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result < 0)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Необходимо ввести число больше 0. Нажмите клавишу для продолжения...");
                        Console.ReadKey();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Необходимо ввести целое число. Нажмите клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
            return result;
        }
        static void PrintCatInfo(Cat cat)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Имя кошки:" + cat.Name);
            Console.WriteLine("Возраст кошки:" + cat.Age);
            Console.WriteLine("Здоровье кошки:" + cat.Health);
            Console.ForegroundColor = cat.Health > 0 ? ConsoleColor.Green : ConsoleColor.White;
            Console.WriteLine("Цвет кошки:" + cat.Color);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }
    }
}