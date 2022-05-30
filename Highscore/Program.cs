using System;
using System.Linq;

namespace Highscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int testCase = 0; testCase < testCases; testCase++)
            {
                int questions = int.Parse(Console.ReadLine());
                string answers = Console.ReadLine();
                string[] ans = new string[4]; 
                ans=answers.Split(' ');
                int[] arr = new int[ans.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(ans[i]);
                }

                int maxElement = int.MinValue;
                for (int arrIndex = 0; arrIndex < arr.Length; arrIndex++)
                {
                    int currentElement = arr[arrIndex];
                    if (currentElement >= maxElement)
                    {
                        maxElement = currentElement;
                    }
                }

                //int maxElement = arr.Max();
                //int maxElementIndex = Array.IndexOf(arr, maxElement);


                int indexOfMaxElement = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == maxElement)
                    {
                        indexOfMaxElement = i;
                    }
                }

                Console.WriteLine(maxElement);







            }
        }   
    }
}
