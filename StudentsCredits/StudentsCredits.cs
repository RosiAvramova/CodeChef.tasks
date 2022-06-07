using System;

namespace StudentsCredits
{
    internal class StudentsCredits
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
                string[] result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                int numberOfCredits = int.Parse(Console.ReadLine());
                string resultCredits = string.Empty;
                if (numberOfCredits > 65)
                {
                    resultCredits="Overload";
                }
                else if (numberOfCredits<35)
                {
                    resultCredits = "Underload";
                }
                else
                {
                   resultCredits =  "Normal";
                }
                result[i] = resultCredits;


            }
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
