using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander commander = new Commander();
            commander.employees = new List<Employee>()
            {
                new Cashier(){firstName = "Игорь", lastName = "Николаев", flagtomorrow = true, qualification = "Стажёр"},
                new Loader() {firstName = "Филип", lastName = "Кудашев", flagtomorrow = false},
                new Cashier(){firstName = "Ольга", lastName = "Бузова", flagtomorrow = true, qualification = "Кассир"},
                new Cashier(){firstName = "Дарья", lastName = "Камалова", flagtomorrow = true, qualification = "Кассир"},
                new Cashier(){firstName = "Михаил", lastName = "Мамедов", flagtomorrow = false, qualification = "Старший кассир" },
                new Loader() {firstName = "Артем", lastName = "Недорубов", flagtomorrow = false},
                new Cashier(){firstName = "Кирилл", lastName = "Бабин", flagtomorrow = true, qualification = "Стажёр" },
                new Loader() {firstName = "Александр", lastName = "Таракановский", flagtomorrow = false},
                new Loader() {firstName = "Андрей", lastName = "Малахов", flagtomorrow = true},
                new Cashier(){firstName = "Егор", lastName = "Петров", flagtomorrow = false, qualification = "Старший кассир" }
            };
            Console.WriteLine("Список работников на завтрашнюю смену:");
            commander.PrintTeam();
            Console.WriteLine("\nСписок на печать бейджиков:");
            commander.PrintBageForAllCashier();
        }
    }
}