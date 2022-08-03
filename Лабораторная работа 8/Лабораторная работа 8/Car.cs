using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Car
    {
        public Engine engine; //композиция с Engine
        public int Number { get; set;} //номер машины


        public Car(int number, int PSize) //конструкция автомобиля
        {
            Number = number;
            engine = new Engine(PSize);
        }
    }
}
