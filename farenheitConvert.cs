using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheit;
            double celcius;
            double kelvins;

            Console.WriteLine("Enter the temperature in Farenheit to convert: ");
            farenheit = double.Parse(Console.ReadLine());

            celcius = ((farenheit - 32) * 5 / 9);
            kelvins = (((farenheit - 32) * 5 / 9) + 273.15);

            Console.WriteLine("{0}F = {1:0.##}C", farenheit, celcius);
            Console.WriteLine("{0}F = {1:0.##}k", farenheit, kelvins);
            Console.ReadLine();

        }
    }
}
