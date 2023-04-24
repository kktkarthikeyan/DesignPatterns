using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.weatherforcast.observable
{
    public interface IWeatherForcastObservable
    {
        void  registerObserver(IWeatherforcast weatherforcast);
        void  removeObserver ( IWeatherforcast weatherforcast);
        void notifyObservers();
    }
}