using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Swapping_of_two_no
    {
       
            public static void Main(string[] args)
            {
                int a = 5, b = 10;
                Console.WriteLine("Before swap a= " + a + " b= " + b);
                a = a * b;      
                b = a / b;       
                a = a / b;     
                Console.Write("After swap a= " + a + " b= " + b);
            }
        
    }
}
