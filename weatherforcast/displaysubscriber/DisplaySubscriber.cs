using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.karthik.observer.weatherforcast.observable;

namespace com.karthik.observer.weatherforcast.displaysubscriber
{
    public class DisplaySubscriber : IWeatherforcast
    {
        public DisplaySubscriber(IWeatherForcastObservable weatherForcastObservable)
        {
            weatherForcastObservable.registerObserver(this);
        }
        private int temprature;
        private int humidity;
        public  void  update(int temprature, int humidity)
        {
           this.temprature = temprature;
           this.humidity = humidity;
           display();

        }
        private void display(){
            Console.WriteLine($"Current Temprature : {temprature} & Humidity is : {humidity}");
        }
    }
}