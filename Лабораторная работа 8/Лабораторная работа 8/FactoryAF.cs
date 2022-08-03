using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class FactoryAF
    {
        public List<Car> Cars = new List<Car>()
        {
            new Car(6,12),
            new Car(8,10),
            new Car(14,5),
            new Car(18,8),
            new Car(19,11),
        };
        public List<Customer> Customers = new List<Customer>()
        {
            new Customer("Зотов Никита Артемович"),
            new Customer("Мамаев Николай Петрович"),
            new Customer("Кириллов Анаталой Павлович"),
            new Customer("Степаненко Олег Динисович"),
        };
        public void SaleCar() 
        { 
            foreach (var car in Customers)
            {
                if(Cars.Count == 0)
                {
                    break;
                }
                if (car.HasCar == false)
                {
                    car.SetCar(Cars[0]);
                    Cars.Remove(Cars[0]);
                    car.HasCar = true;
                }
            }
        }
    }
}
