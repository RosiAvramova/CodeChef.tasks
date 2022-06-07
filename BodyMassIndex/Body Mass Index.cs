using System;

namespace BodyMassIndex
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
                int mass = int.Parse(input[0]);
                int height = int.Parse(input[1]);
                int BMI = mass / (height * height);
                string bodyMass = string.Empty;
                if (BMI <= 18)
                {
                   bodyMass = "1";
                }
                else if (BMI >= 19 && BMI <= 24)
                {
                    bodyMass = "2";
                }
                else if (BMI >= 25 && BMI <= 29)
                {
                    bodyMass = "3";
                }
                else if (BMI >= 30)
                {
                    bodyMass = "4";
                }
                result[i] = bodyMass;
            }
            Console.WriteLine(string.Join("\n",result));
        }
    }
}

