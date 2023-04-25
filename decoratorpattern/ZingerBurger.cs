using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.decoratorpattern
{
    public class ZingerBurger : Burger
    {
       
        public override int GetCost()
        {
           return 100;
        }

        public override string Getescription()
        {
             return "Zinger Burger";
        }
    }
}