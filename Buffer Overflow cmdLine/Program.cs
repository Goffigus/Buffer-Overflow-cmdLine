using System;
using static System.Console;

namespace Buffer_Overflow_cmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost = 11999;
            int quantity = 0;
            int total = 0;
            while (true)
            {
                Console.WriteLine("Cost of Item is $11,999");
                Console.WriteLine("Quantity being purchased:");
                quantity = Convert.ToInt32(ReadLine()); //357943
                total = cost * quantity;
                Console.WriteLine("Total is $" + total + '\n');

            }
            
        }
    }
}
