using System;
using StaticExercise;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double numToConv)
        {

            var fConversion = (numToConv - 32) / 1.8;
            Console.WriteLine(fConversion);
            return fConversion;

        }


        public static double CelsiusToFahrenheit(double numToConv)
        {
            var cConversion = (numToConv * 1.8) + 32;
            Console.WriteLine(cConversion);
            return cConversion;
        }
    }
}





