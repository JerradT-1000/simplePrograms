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
            int ft;
            int inch;
            double meter;
            double centimeter;

            Console.WriteLine("Enter your height in feet, don't include inches: ");
            ft = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}ft. How many inches?: ", ft);
            inch = int.Parse(Console.ReadLine());

            meter = ((ft / 12 + inch) / 40);
            centimeter = ((ft / 12 + inch) * 2.54);

            Console.WriteLine("You are {0} meters tall.", meter);
            Console.WriteLine("And {0} centimeters tall.", centimeter);



        }
    }
}
