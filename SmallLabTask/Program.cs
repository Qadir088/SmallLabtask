using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLabTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car()
            {
                Brand = "BMW",
                Model = "X5",
                Millage = 500,
                CurrentFuel = 100,
                FuelCapacity = 0,
            };
            car.AddFuel();

        }
    }
}
