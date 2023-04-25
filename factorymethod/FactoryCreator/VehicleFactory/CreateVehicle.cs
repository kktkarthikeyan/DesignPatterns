using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.karthik.observer.factorymethod.product;

namespace com.karthik.observer.factorymethod.FactoryCreator.VehicleFactory
{
    public class CreateVehicle : VehicleFactory
    {
        public override IProduct CreateFactoryVehicle(string type)
        {
            if(type =="bike"){
                return new ProductBike();
            }
            else{
                return new ProductCar();
            }
           
        }

    }
}