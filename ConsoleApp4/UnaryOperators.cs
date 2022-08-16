using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class UnaryOperators
    {
        static void Main(string[] args)
        {
            int x = 10;
            //x++;
            ++x;
            Console.WriteLine(x);
        }
        
    }
    class UnaryOperators1
    {
        static void Main(string [] args)
        {
            int a, b;
            a = 2;
            b = 2;

            int x = a++ + b++;
            Console.WriteLine(x + " " + a + " " + b);
            x = --a + ++b + a;
            Console.WriteLine(x + " " + a + " " + b);
            x = a++ + --b - a;
            Console.WriteLine(x + " " + a + " " + b);
            x = --a - b-- - b;
            Console.WriteLine(x + " " + a + " " + b);
            x = ++a - --b - b--;
            Console.WriteLine(x + " " + a + " " + b);

          
        }

    }
    class UnaryOperators2
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int x = a++ + b++ + c++;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = ++a - --b - c--;
            Console.WriteLine(x + " " + a + " " + b + " +c");

            x = a-- - b-- - ++c;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = ++a + ++b + c--;
            Console.WriteLine(x + " " + a + " " + b + " " + c);
            x = --c - --b - --a - a;
            Console.WriteLine(x + " " + a + " " + b + " " + c);




        }
    }
}
