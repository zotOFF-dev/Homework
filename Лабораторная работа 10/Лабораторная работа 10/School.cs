using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class School
    {
        public List<Student> students = new List<Student> 
        {
            new Student{Number = 1, CountPhone = 15, CountLunch = 5, position = Position.Senior},
            new Student{Number = 2, CountPhone = 17, CountLunch = 8, position = Position.Junior},
            new Student{Number = 3, CountPhone = 9, CountLunch = 4, position = Position.Preschool},
            new Student{Number = 4, CountPhone = 3, CountLunch = 15, position = Position.Junior},
            new Student{Number = 5, CountPhone = 35, CountLunch = 2, position = Position.Senior},
            new Student{Number = 6, CountPhone = 6, CountLunch = 3, position = Position.Preschool},
            new Student{Number = 7, CountPhone = 18, CountLunch = 6, position = Position.Junior},
            new Student{Number = 8, CountPhone = 11, CountLunch = 11, position = Position.Senior},
            new Student{Number = 9, CountPhone = 10, CountLunch = 7, position = Position.Senior},
            new Student{Number = 10, CountPhone = 31, CountLunch = 4, position = Position.Junior},
            new Student{Number = 11, CountPhone = 24, CountLunch = 2, position = Position.Junior},
            new Student{Number = 12, CountPhone = 17, CountLunch = 7, position = Position.Senior},
            new Student{Number = 13, CountPhone = 11, CountLunch = 9, position = Position.Preschool},
            new Student{Number = 14, CountPhone = 8, CountLunch = 3, position = Position.Senior},
            new Student{Number = 15, CountPhone = 16, CountLunch = 20, position = Position.Senior},
        };
        public (Student Faster, Student Slower) FindMaxMinEmployee()
        {
            students.Sort(); 
            (Student, Student) result = (students[students.Count - 1], students[0]);
            Reward(ref result);
            (students[students.Count - 1], students[0]) = (result.Item1, result.Item2);
            return (students[students.Count - 1], students[0]);
        }
        public void Reward(ref (Student, Student) result)
        {
            result.Item2.CountLunch--;
            result.Item1.CountLunch++;
        }
    }
}
