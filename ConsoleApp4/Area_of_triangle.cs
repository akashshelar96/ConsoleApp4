using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Area_of_triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of triangle:");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle:");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            double areaOfTrinagle = (triangleBase * triangleHeight) / 2;
            Console.WriteLine("Area of triangle is:" + areaOfTrinagle);
        }
    }
}
