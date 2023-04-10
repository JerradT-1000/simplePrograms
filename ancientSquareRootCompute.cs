namespace ...
{
    class Program
    {

        static void Main(string[] args)
       
            /** The ancient Babylonians used a divide and average method for computing the square root of a 
             * positive number x. First estimate the square root by some value r; any positive estimate will do. 
             * Then compute the quotient, x/r. Averaging r and x/r gives a better estimate, so continue the 
             * process, dividing and averaging until the estimates agree to the desired number of places. 
             * Write a C# program to compute the square root of a number input by the user. Use the divide 
             * and average method and stop after 10 repetitions of the divide and average steps.
             * Compare your result with the value produced by the Sqrt method of the Math class.**/


            Console.WriteLine("Oh No! It's the Babylonians! What do you think they want?");
            Console.WriteLine("**Witch doctor appears out of thin air**");
            Console.WriteLine("");

            double estimate;
            double sqrt;
            Random rnd = new Random();
            double q;

            int number = rnd.Next(1, 1000);
            sqrt = Math.Sqrt(number);

            Console.WriteLine("'The ancient Babylonians have spoken. The number is {0}'", number);
            Console.WriteLine("'Now please the Babylonians with your intelect by estimating the square root! '");
            estimate = double.Parse(Console.ReadLine());

            if (estimate != sqrt)
                Console.WriteLine("The Babylonians are displeased, they must now use thier ancient methods.");

            else if (estimate == sqrt)
                Console.WriteLine("Wow! The Babylonians have admitted defeat and left you a sack of jewels!");

            
            for (int i = 0; i <= 9; i++)
            {
                q = number / estimate;
                estimate = (estimate + q) / 2;
                 
            
                Console.WriteLine("The closer square root is {0}", estimate);
               
            }

            Console.WriteLine("                                   ");
            Console.WriteLine("The square root of {0} is {1}", number, estimate);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("                                 ");

    }
}
