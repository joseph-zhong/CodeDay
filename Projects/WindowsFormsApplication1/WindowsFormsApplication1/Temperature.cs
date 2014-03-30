//Temperature.cs
//Joseph Zhong
// 19 Feb. 2013


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Temperature
    {
        //Instance Variables
        private double Celsius;

        //Constructors
        public Temperature()
        {
            Celsius = 0.0;

        }

        //Accessors
        public double getCelsius()
        {
            return Celsius;
        }

        public double getFahrenheit()
        {
            return Celsius * 9.0 / 5.0 + 32;
        }

        //Mutators
        public void setCelsius(double c)
        {
            Celsius = c;
        }

        public void setFahrenheit(double f)
        {
            Celsius = (f - 32) * 5.0 / 9;
        }

    }
}
