using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLabTask
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public int Millage;
        public int CurrentFuel;

        public Vehicle()
        {
        }

        public Vehicle(string brand,string model,int millage,int currentFuel )
        {
            Brand = brand;
            Model = model;
            Millage = millage;
            CurrentFuel = currentFuel;
        }
    }
}
