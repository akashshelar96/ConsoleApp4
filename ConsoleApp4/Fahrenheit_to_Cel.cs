using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Fahrenheit_to_Cel
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit = 97;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            Console.ReadLine();
        }
    }
}
