using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class User_Value
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            int radius = int.Parse(Console.ReadLine());
            double PI = 3.14;

            double area = PI * radius * radius;

            Console.WriteLine("Area of Circle=" + area);
        }
    }
}