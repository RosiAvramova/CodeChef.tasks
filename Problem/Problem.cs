using System;

namespace Problem
{
    internal class Problem
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            string[] result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                string category = string.Empty;
                int x = int.Parse(Console.ReadLine());
                if (1 <= x && x < 100)
                {
                    category = "Easy";
                }
                else if (100 <= x && x < 200)
                {
                    category = "Medium";
                }
                else if (200 <= x && x <= 300)
                {
                    category = "Hard";
                }
                result[i] = category;
            } 
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
