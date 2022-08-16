using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter your First num:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Third number:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
            Console.ReadLine();
        }
    }
}
