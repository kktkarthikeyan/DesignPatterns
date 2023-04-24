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

            Thread.Sleep(50000);

            weatherStation.paramChange(30,40);
        }
    }
}