using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Simple_interestPTR
    {
        static void Main(string []args)
        {
            int p;
            double R, T, SI;
            p = 12000;
            R = 5;
            T = .5;
            SI = (p * R * T) / 100;
            Console.WriteLine("Simple Interest is:" + SI);
            
        }
    }
}
