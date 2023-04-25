using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.decoratorpattern
{
    public abstract class Burger
    {
        public string? Name {get; set;}
        public string? Description { get; set;}
        public int Cost {get;set;}
        
        public abstract string Getescription();
        public abstract int GetCost();
    }
}