using System;

namespace PassOrFail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            string[] result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int numberOfQuestions = int.Parse(input[0]);
                int correctAnswers = int.Parse(input[1]);
                int minScore = int.Parse(input[2]);
                int testResult = 0;
                int wrongAnswers = numberOfQuestions - correctAnswers;
                testResult = correctAnswers * 3;
                testResult = testResult - wrongAnswers;
                if (testResult>=minScore)
                {
                    result[i] = "PASS";
                }
                else
                {
                    result[i] = "FAIL";
                }


            }
            Console.WriteLine(String.Join("\n",result));
        }
    }
}
