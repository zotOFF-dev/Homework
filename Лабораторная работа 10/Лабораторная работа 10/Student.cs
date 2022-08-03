using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public enum Position
    {
        Senior = 0,
        Junior = 1,
        Preschool = 2,
    }
    public struct Student: IComparable<Student>
    {
        public int Number { get; set; }
        public int CountPhone {  get; set; }
        public int CountLunch { get; set; }
        public Position position { get; set; }
        public int CompareTo(Student student)
        {
            if (this.CountPhone > student.CountPhone)
            {
                return 1;
            }
            else if (this.CountPhone < student.CountPhone)
                return -1;
            else if (this.position > student.position)
                return 1;
            else if (this.position < student.position)
                return -1;
            else
                return 0;
        }

    }
}
