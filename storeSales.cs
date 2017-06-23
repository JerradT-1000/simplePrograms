namespace ...
{
    class Program
    {
        static void Main(string[] args)
        
        //
       
            double[] store; 

            store = new double[5];
           
       
            Console.WriteLine("Input sales for store 1: ");
            store[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sales for store 2: ");
            store[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sales for store 3: ");
            store[2] = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sales for store 4: ");
            store[3] = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sales for store 5: ");
            store[4] = double.Parse(Console.ReadLine());


            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sales for store #{0}: ${1}", i + 1, store[i]);
            }


        
            int max = 0;
            int min = 0;
            double sum = store.Sum();
            double avg = store.Average();

            for (int i = 0; i < store.Length; i++)
            {
                if (i != 0)
                {
                    if(store[i] > store[max])
                    {
                        max = i;
                    }
                    if(store[i] < store[min])
                    {
                        min = i;
                    }
                }
                
            }

            Console.WriteLine("Store {0} has the maximum sales for the week.", max + 1);
            Console.WriteLine("Store {0} has the minimum sales for the week.", min + 1);
            Console.WriteLine("The total sales from all five stores is: {0}", sum);
            Console.WriteLine("The average sales from all 5 stores is: {0}", avg);
         
    }
}
