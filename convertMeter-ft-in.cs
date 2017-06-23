namespace ...
{
    class Program
    {
        static void Main(string[] args)
        
            /**a C# program to convert meters to feet or inches. There are
             *  39.37 inches in one meter and 12 inches in a foot. If the 
             *  length is less than 1 foot, just report the number of inches.
             *  Show two digits after the decimal point. Thus 3.4 meters
             *  converts to 11.15 feet, and .2 meter converts to 7.87 inches. pg.172 **/
              
            double inches = 0;             //identifying variables
            double feet = 0;
            double feetPerMeter = 3.28;
            double inchesPerMeter = 39.37;  

            Console.WriteLine("Enter the number of meters to convert: "); //prompts user
            double meters = double.Parse(Console.ReadLine());

            if (meters <= 0.304)
                inches = meters * inchesPerMeter;     //equation to find inches per meter
            else if (meters > 0.3054)
                feet = meters * feetPerMeter;         //equation to find feet per meter

            Console.WriteLine("There are {0} feet", feet);
            Console.WriteLine("There are {0} inches", inches);
            Console.ReadLine();
   
    }
}
