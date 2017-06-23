namespace ...
{
    class Program
    {

        static void Main(string[] args)
     
            /** Write a C# program that converts currencies between British currency of pounds and pence, 
             * in which 1 pound contains 100 pence, and U.S. currency in dollars and cents.
             * Assume an exchange rate of 1.6595 U.S. dollars per British pound. Give the user a menu 
             * to choose the type of conversion. Allow the user to repeat as often as desired.**/

            double usdInput;
            double ukpInput;
            double usd;
            double ukp;
            int input;
            string y = null;
            string again = y;

            Console.WriteLine("Thank you for choosing Jerrad's conversion program!");
            Console.WriteLine("");


            do
            {

                Console.WriteLine("If you would like to convert from GBP to USD, type: (1)");
                Console.WriteLine("If you would like to convert from USD to GBP, type: (2)"); 
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter the GBP amount to convert: ");
                    ukpInput = double.Parse(Console.ReadLine());

                    usd = ukpInput * 1.6595;

                    Console.WriteLine("The exchange is ${0:0.00}", usd);
                }

                else if (input == 2)
                {
                    Console.WriteLine("Enter a Dollar amount to convert: ");
                    usdInput = double.Parse(Console.ReadLine());

                    ukp = usdInput * 0.82975;

                    Console.WriteLine("The exchange is \u00A3{0:0.00}", ukp);
                }

                else if (input != 1 && input != 2) 
                    Console.WriteLine("Please enter a valid number, (1) or (2)");

                Console.WriteLine("Would you like to convert again? (y) or (n)");
                again = (Console.ReadLine());
            }
            while (again.Equals("y"));
            Console.WriteLine("-----------------------------------------------------------------------");
               
    }
}
