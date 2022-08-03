using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Commander
    {
        public List<Employee> employees = new List<Employee>();
        public void PrintTeam()
        {
            foreach (Employee employee in employees)
            {
                if(employee.flagtomorrow)
                Console.WriteLine(employee.GetFullName());
            }
        }
        public static void PrintBage(Cashier cashier)
        {
            Console.WriteLine(cashier.GetFullName());
        }
        public void PrintBageForAllCashier()
        {
            foreach(Employee employee in employees)
            {
                if(employee is Cashier cashier)
                {
                    PrintBage(cashier);
                }
            }
        }
    }
}
