using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class PostOficce
    {
        public static List<Employee> Employees = new List<Employee>(8)
        {
            new Operator{name = "Александр", DateOfEmployment = new DateTime(1990, 7, 13)},
            new Cashier{name = "Дмитрий", DateOfEmployment = new DateTime(2011, 2, 28)},
            new Postman{name = "Николай", DateOfEmployment = new DateTime(2014, 12, 23)},
            new Cashier{name = "Мария", DateOfEmployment = new DateTime(2007, 4, 9)},
            new Cashier{name = "Никита", DateOfEmployment = new DateTime(2004, 6, 13)},
            new Postman{name = "Ольга", DateOfEmployment = new DateTime(2001, 9, 11)},
            new Operator{name = "Кристина", DateOfEmployment = new DateTime(1995, 8, 11)},
            new Postman{name = "Кирилл", DateOfEmployment = new DateTime(1998, 1, 24)}
        };

        public static void info ()
        {
            foreach (Employee person in Employees)
            {
                Console.WriteLine("Информация о следующем сотруднике:");
                Console.WriteLine($"Имя: {person.Say()};");
                Console.WriteLine($"Что делаю: {person.WhatYouDo()};");
                Console.WriteLine($"Сколько работаю: {person.WorkTime()} {person.Timetype()};");
                Console.WriteLine("Информация о сотруднике закончена\n");
            }
        }
    }
}
