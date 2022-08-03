using System;
using static System.Console;

namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Приветствуем вас в информационной системе \"ЯДелатьТвойАйВон\"");
            WriteLine("Список обущающихся в данной школе:");
            School school = new School();
            foreach(Student student in school.students){
                WriteLine($"ID ученика - {student.Number}, статус ученика - {student.position}, количество собранных телефонов - {student.CountPhone}, количество обедов - {student.CountLunch}");
            }
            WriteLine("------------------------------------------------------------------------");
            WriteLine("Осортированный список студентов:");
            (Student, Student) result1 = school.FindMaxMinEmployee();
            foreach (Student student in school.students)
            {
                WriteLine($"ID ученика - {student.Number}, статус ученика - {student.position}, количество собранных телефонов - {student.CountPhone}, количество обедов - {student.CountLunch}");
            }
            WriteLine("------------------------------------------------------------------------");
            WriteLine("Самый производительный ученик:");
            WriteLine($"ID - {result1.Item1.Number}, Статус - {result1.Item1.position}, количество собранных телефонов - {result1.Item1.CountPhone}, количество обедов - {result1.Item1.CountLunch}");
            WriteLine("Самый медлительный ученик:");
            WriteLine($"ID - {result1.Item2.Number}, Статус - {result1.Item2.position}, количество собранных телефонов - {result1.Item2.CountPhone}, количество обедов - {result1.Item2.CountLunch}");
            Write("Спасибо за использование информационной системы!");
        }
    }
}