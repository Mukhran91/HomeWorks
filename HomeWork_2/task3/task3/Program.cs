using System;

namespace Task3
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int TMP = x;
            x = y;
            y = TMP;
            
            Console.WriteLine($"x = {x} y = {y}");
        }
    }
}