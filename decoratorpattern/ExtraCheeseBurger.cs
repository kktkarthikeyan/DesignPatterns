using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.karthik.observer.decoratorpattern
{
    public class ExtraCheeseBurger : BurgerDecorator
    {
        Burger _burger;
        public ExtraCheeseBurger(Burger burger)
        {
            _burger = burger;
        }
        public override int GetCost()
        {
           return _burger.Cost = 120;
        }

        public override string Getescription()
        {
            return _burger.Description = "Burger with extra Cheese";
        }
    }
}