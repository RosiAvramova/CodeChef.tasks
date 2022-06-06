using System;

namespace LuckyFour
{
    internal class LuckyFour
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            int[] result = new int[testCases];
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                int counter = 0;
                foreach (var ch in input)
                {
                    if (ch =='4')
                    {
                        counter++;
                    }
                }
                result[i] = counter;
            }
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
