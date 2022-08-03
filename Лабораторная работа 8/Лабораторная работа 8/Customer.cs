using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Customer
    {
        public string FIO { get; set; }
        public Car car;
        public bool HasCar { get; set; } = false;
        public Customer(string fio)
        {
            FIO = fio;
        }
        public void SetCar(Car car)
        {
            this.car = car;
        }
    }
}
