using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.karthik.observer.factorymethod.product;

namespace com.karthik.observer.factorymethod.FactoryCreator.VehicleFactory
{
    public abstract class VehicleFactory
    {
        public abstract IProduct CreateFactoryVehicle(string type);
    }
}