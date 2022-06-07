using System;
using System.Collections.Generic;

namespace TheBlockGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                string number = Console.ReadLine();
                char[] numberArr = number.ToCharArray();
                Array.Reverse(numberArr);
                string reversed = new string(numberArr);
                if (number == reversed)
                {
                    result.Add("wins");
                }
                else
                {
                    result.Add("loses");
                }
            }
            Console.WriteLine(string.Join("\n",result));

        }
    }
}
