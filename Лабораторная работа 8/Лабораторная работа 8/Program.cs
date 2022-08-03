using System;
using static System.Console;
using System.Collections.Generic;

namespace Lab_8
{
    internal class Program
    {
        static void Main()
        {
            FactoryAF factory = new FactoryAF();
            WriteLine("Вас приветствует комания FactoryAF");
            WriteLine("Список покупателей на покупку нашего автомобиля:");
            foreach (Customer car in factory.Customers)
            {
                WriteLine(car.FIO);
            }
            WriteLine("Список имеющихся автомобилей:");
            foreach (Car car in factory.Cars)
            {
                WriteLine($"Номер машины: {car.Number}; Размер педалей: {car.engine.Size}");
            }
            WriteLine("---------------------------------------------------------");
            factory.SaleCar();
            foreach (Customer car in factory.Customers)
            {
                if (car.HasCar == true)
                {
                    WriteLine($"{car.FIO} имеет автомобиль: номер: {car.car.Number}; размер педалей: {car.car.engine.Size}");
                }
            }
            WriteLine("---------------------------------------------------------");
            foreach (Customer car in factory.Customers)
            {
                if (car.HasCar == false)
                    WriteLine($"{car.FIO} не имеет автомобиль");
            }
            if (factory.Cars.Count <= 0)
            {
                WriteLine("Машин не осталось, приходите, когда они будут снова вналичии");
            }
            else
            WriteLine($"Осталось автомобилей: {factory.Cars.Count}, они будут утилизированы");
            factory.Cars.Clear();
        }
    }
}
