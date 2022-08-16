using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Addition2no
    {
        static void Main(string []args)
        {
            int a;
            int b;
            int total;

            Console.Write("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            
            total = a + b;
            Console.WriteLine("Total is: " + total);
        }
    }
}
