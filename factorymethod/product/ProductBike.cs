using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.factorymethod.product
{
    public class ProductBike : IProduct
    {
        public void Vehicle()
        {
            Console.WriteLine("Bike Object is created!");
        }
    }
}