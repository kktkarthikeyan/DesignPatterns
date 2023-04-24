using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.karthik.observer.weatherforcast.observable;

namespace com.karthik.observer.weatherforcast.weatherstation
{
    public class WeatherStation : IWeatherForcastObservable
    {
        private List<IWeatherforcast> observers;
        private int temprature;
        private int humidity;
        
        public WeatherStation()
        {
            this.observers = new List<IWeatherforcast>();
        }
        private bool hasObserver(IWeatherforcast weatherforcast){
            int index = observers.IndexOf(weatherforcast);
            return index>=0;
        }

        public void notifyObservers()
        {
            observers.ForEach(obs=>obs.update(temprature,humidity));
        }

        public void registerObserver(IWeatherforcast weatherforcast)
        {
            if(!hasObserver(weatherforcast))
                observers.Add(weatherforcast);
        }

        public void removeObserver(IWeatherforcast weatherforcast)
        {
           if(hasObserver(weatherforcast))
                observers.Remove(weatherforcast);
        }
        public void paramChange(int temprature, int humidity){
            this.temprature = temprature;
            this.humidity = humidity;
            notifyObservers();
        }
    }
}