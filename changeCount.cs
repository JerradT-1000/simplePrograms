namespace ...
{
    class Program
    {
        static void Main(string[] args)
        {
            /**a C# program to make change. Enter the cost of an item that
             *  is less than one dollar. Output the coins given as change, 
             *  using quarters, dimes, nickels, and pennies. Usethe fewest
             *  coins possible. For example, if the item cost 17 cents,
             *  the change would bethree quarters, one nickel, and three pennies. **/
               
            Console.WriteLine("Enter the price of your item less than $1: "); //prompts user to enter price
            int price = int.Parse(Console.ReadLine()); //pareses out readline to work as an int
            int change = 100 - price;
            int numQ = change / 25;     //identifies what numQ does
            change = change - numQ * 25;
            int numD = change / 10;
            change = change - numD * 10;
            int numN = change / 5;
            change = change - numN * 5;
            int numP = change;
            Console.WriteLine(" The change is {0} quarters {1} dimes {2} nickles and {3} pennies", numQ, numD, numN, numP);
            Console.ReadLine();

    }
}
