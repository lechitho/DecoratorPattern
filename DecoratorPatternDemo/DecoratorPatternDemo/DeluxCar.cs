﻿using DecoratorPatternDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public class DeluxCar : ICar
    {
        public string GetDescription()
        {
            return "Delux Car";
        }

        public double GetCost()
        {
            return 750000.0;
        }
    }
}