using System;

namespace TooManyItems
{
    internal class TooManyItems
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            int[] result = new int[testCases];
            for (int i = 0; i < testCases; i++)
            {
                int items = int.Parse(Console.ReadLine());
                int bags = 0;
                bags = items / 10;
                if (items%10!=0)
                {
                    bags++;
                }
                result[i] = bags;

            }
            Console.WriteLine(String.Join("\n",result));
        }
    }
}
