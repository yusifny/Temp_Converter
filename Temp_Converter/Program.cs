using System;
using Temp.Converter.Models;
namespace Kelvin_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius to Kelvin");
            Celsius celsius = new Celsius(c);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Degree);
        }
    }
}