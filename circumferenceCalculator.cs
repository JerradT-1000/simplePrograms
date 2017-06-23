namespace ...
{
    class Program
    {

        static void Main(string[] args)
        
            /** Write a C# program that inputs the radius of a circle and outputs its circumference.
             * Allow the user to repeat the calculation as often as desired. Use Math.PI for the value of pi.
             * The circumference of a circle is pi times the diameter. The diameter of a circle is twice 
             * the radius. **/

            double rad;
            double circ;
            string y = null;
            string again = y;

            Console.WriteLine("");

            do
            {
                {

                    Console.WriteLine("Enter the radius of the circle: ");
                    rad = double.Parse(Console.ReadLine());
                    circ = Math.PI * rad * 2;

                    Console.WriteLine("The circumference of the circle with the radius of {0} is {1} \n", rad, circ);
                    Console.WriteLine("                                      ");
                }

                Console.WriteLine("Would you like to calculate again? (y) or (n)");
                again = (Console.ReadLine());
            }
            while (again.Equals("y"));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");

    }
}
