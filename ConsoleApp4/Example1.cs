using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Example1
    {
        static int Profit(int costPrice,int sellingPrice)

        {
            int profit = (sellingPrice - costPrice);
            return profit;
        }
        static int Loss(int costPrice,int sellingPrice)
        {
            int Loss = (costPrice - sellingPrice);
            return Loss;
        }
        public static void Main()
        {
            int costPrice = 15, sellingPrice = 20;
            if (sellingPrice == costPrice)
                Console.Write("No Profit nor Loss");

            else
                Console.Write(Loss(costPrice, sellingPrice) + "Loss");
        }
    }
}
