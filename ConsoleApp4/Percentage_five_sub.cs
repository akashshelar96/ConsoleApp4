using System;

namespace ConsoleApp4
{
    class Percentage_five_sub
    {
        static void Main(string[] args)
        {
            double r1, phy, che, ca, java, php, total;
            double per;
            string nm, div ;

            Console.Write("\n\n");
            Console.Write("Calculate the total, percentage and division to take arks of five subject:\n");
            Console.Write("-----------------------");
            Console.Write("\n\n");

            Console.Write("Input the Roll no of the student:");
            r1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the student :");
            nm = Console.ReadLine();

            Console.Write("Input the marks of physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks of Chemistry:");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks of Computer application:");
            ca = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks of java:");
            java = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks of php:");
            php = Convert.ToInt32(Console.ReadLine());



            total = phy + che + ca + java + php;
            per = total / 5.0;
            if (per >= 60)
                div = "First";
            else
                if (per < 60 && per >= 48)
                div = "Second";
            else
                if (per < 48 && per >= 36)
                div = "Pass";
            else
                div = "Fail";
            Console.Write("\nRoll No:{0}\nName of Student:{1}\n", r1, nm);
            Console.Write("Marks in Physics:{0}\nMarks in Chemistry:{1}\nMarks in Computer Applocation:{2}\n", phy, che, ca, java, php);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
        }
    } 
}
