using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X : ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int min, max;
            
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x; 
            }
            
            Console.WriteLine(max + min);
            Console.WriteLine(max - min);
            Console.WriteLine(max * min);

            if (min == 0)
            {
                Console.WriteLine("Not Allowed To Divide By Zero");
            }
            else
            {
                Console.WriteLine(max / min);
            }
        }
    }
}