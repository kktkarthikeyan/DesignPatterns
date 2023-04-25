using com.karthik.observer.factorymethod.FactoryCreator.VehicleFactory;
using com.karthik.observer.factorymethod.product;
using com.karthik.observer.weatherforcast.displaysubscriber;
using com.karthik.observer.weatherforcast.weatherstation;

namespace com.karthik.observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            DisplaySubscriber displaySubscriber = new DisplaySubscriber(weatherStation);
            Console.WriteLine("Hello, World!");
            
            weatherStation.paramChange(20,10);

            Thread.Sleep(10);

            weatherStation.paramChange(30,40);

            /*Factory Method */

            VehicleFactory vehicleFactory = new CreateVehicle();
            IProduct product = vehicleFactory.CreateFactoryVehicle("bike");
            product.Vehicle();
        }

    }
}