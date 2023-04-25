using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.factorymethod.product
{
    public class ProductCar : IProduct
    {
        public void Vehicle()
        {
            Console.WriteLine("Car is created!");
        }
    }
}