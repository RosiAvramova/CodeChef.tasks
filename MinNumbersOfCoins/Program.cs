using System;

namespace MinNumbersOfCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            int[] result = new int[testcases];
            for (int i = 0; i < testcases; i++)
            {
                int priceX = int.Parse(Console.ReadLine());
                if (priceX % 5 == 0)
                {
                    int numberOfCoins = 0;
                    numberOfCoins = priceX / 10;
                    if (priceX % 10 != 0)
                    {
                        numberOfCoins++;

                    }
                    result[i] = numberOfCoins;
                }
                else
                {
                    result[i] = -1;
                }
            }
                Console.WriteLine(String.Join("\n", result));
        }
    }
}
