using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    abstract class Employee
    {
        public string firstName = "";
        public string lastName = "";
        public bool flagtomorrow;
        public virtual string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
