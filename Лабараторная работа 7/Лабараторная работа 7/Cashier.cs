using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Cashier: Employee
    {
        public string qualification = "";
        public override string GetFullName()
        {
            return firstName + " " + lastName + " " + qualification;
        }
    }
}
