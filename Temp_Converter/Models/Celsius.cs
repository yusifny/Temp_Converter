using System;
namespace Temp.Converter.Models
{
    class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Kelvin(Celsius n)
        {
            return new Kelvin(n.Degree + 273);
        }
    }
}