using System;

namespace SecondLargesNumber
{
    internal class SecondLargestNumber
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            
            int[] result = new int[testCases];
            
            for (int i = 0; i < testCases; i++)
            {
                string[] numbersAsStrings = Console.ReadLine().Split(' ');
                int[] numbers = new int[numbersAsStrings.Length];
                for (int j = 0; j < numbersAsStrings.Length; j++)
                {
                    numbers[j] = int.Parse(numbersAsStrings[j]);    
                }
                Array.Sort(numbers);
                result[i] = numbers[numbers.Length-2];
            }
            Console.WriteLine(String.Join("\n",result));
        }
    }
}
    

