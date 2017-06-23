namespace ...
{
    class Program
    {
        static void Main(string[] args)
        
            /**The greatest common divisor (gcd) of two integers is the largest positive 
             * number that divides evenly into both numbers. 
             * Find the remainder resulting from dividing the smaller number into the larger. 
             * Repeat this process with the smaller number and the remainder until the remainder 
             * is zero. The last non-zero remainder is the greatest common divisor.
             * Write a C# program to compute the greatest common divisor of
             * two integers. **/

            int  num1;
            int  num2;
            int gcd = 1;

            Console.WriteLine("Enter the larger one of two integers to find the GCD: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            num2 = int.Parse(Console.ReadLine());


            while (gcd != 0)
            {
                gcd = num1 % num2;
                Console.WriteLine("{0} % {1} = {2}", num1, num2, gcd);
                num1 = num2;
                num2 = gcd;
                
            }
            
            
            Console.WriteLine("The GCD of the two integers is: {0}", num1);
            Console.ReadLine();    
            
    }
}
