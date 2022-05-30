using System;

namespace CABS
{
    internal class Program
    {
        static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            int firstPrice = 0;
            int secondPrice = 0;
            for (int i = 0; i < testCases; i++)
            {
                string prices = Console.ReadLine();
                string[] pricesArr = prices.Split(' ');
                string first = pricesArr[0];
                string second = pricesArr[1];

                string result = string.Empty;

                if (int.Parse(first) < int.Parse(second))
                {
                    result = "FIRST";
                }
                if (int.Parse(second) < int.Parse(first))
                {
                    result = "SECOND";
                }
                if (int.Parse(second) == int.Parse(first))
                {
                    result = "ANY";
                }
                Console.WriteLine(result);
            }
        }
    }
}
