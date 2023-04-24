using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.weatherforcast
{
    public interface IWeatherforcast
    {
        void update(int temprature, int humidity);
    }
}