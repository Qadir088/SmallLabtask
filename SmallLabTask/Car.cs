using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLabTask
{
    internal class Car : Vehicle
    {
        public int FuelCapacity;

        public Car()
        {
        }

        public Car(string brand, string model, int millage, int currentFuel,int fuelCapacity) : base(brand, model, millage, currentFuel)
        {
            FuelCapacity = fuelCapacity;
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            Millage = millage;
        }
        public void AddFuel()
        {
            FuelCapacity = 0;
            CurrentFuel = 20;
            int max = 100;
            int sum = 0;
            Console.WriteLine("Welcome");
            Console.WriteLine("How much lt fuel");
            int add = Convert.ToInt32(Console.ReadLine());
            lt:
            if (add < max)
            {
                sum = CurrentFuel + add;
                FuelCapacity = sum;
                Console.WriteLine("Qabağki benzin" + CurrentFuel);
                Console.WriteLine("İndiki benzin" + sum);
            }
            else
            {
                Console.WriteLine("Your tank is full");
                goto lt;
            }
        }

    }
}
