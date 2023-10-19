using DecoratorPatternDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public class LuxuryCar : ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public double GetCost()
        {
            return 1000000.0;
        }
    }
}
