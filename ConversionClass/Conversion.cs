using System;

namespace ConversionClass
{
    public static class Conversion
    {
        private static double CONSTANT = 28.34952;

        public static double ConvertToOunces(double grams)
        {
            return grams / CONSTANT;
        }

        public static double ConvertToGrams(double ounces)
        {
            return ounces * CONSTANT;
        }
    }
}
