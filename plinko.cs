namespace ...
{
    class Program
    {

        static void Main(string[] args)
        
            /** Ask user for # of balls
             * Ask user for # of slots (how many levels)
             * Display the path of each ball as a sequence of L and R
             * After balls have been played, display histogram of contents of each slot.
             **/

            Console.WriteLine("!!!!!!!!!!");
            Console.WriteLine("  THIS");
            Console.WriteLine("   IS");
            Console.WriteLine("  PLINKO!");
            Console.WriteLine("!!!!!!!!!!");

            Random r = new Random();
            int numRightBounce = 0;

            Console.WriteLine("enter num of slots: ");
            int numSlots = int.Parse(Console.ReadLine());

            int[] slots = new int[numSlots];

            Console.WriteLine("enter number of balls: ");
            int numBalls = int.Parse(Console.ReadLine());

            //insert loop that repeats for each ball
            for (int b = 0; b < numBalls; b++)
            {

                int count = 1;
                numRightBounce = 0;

                while (count <= numSlots - 1)
                {
                    int randVal = r.Next(2);

                    if (randVal == 0)
                        Console.Write("L");

                    else
                    {
                        numRightBounce++;
                        Console.Write("R");
                    }

                    count++;

                }
                Console.WriteLine();
                slots[numRightBounce]++;
            }

            //print histogram
            //print the index on each line
            for (int i = 0; i < numSlots; i++)
            {
                Console.Write(i + ": ");
                //print stars for this slot
                for (int stars = 0; stars < slots[i]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        
    }
}
