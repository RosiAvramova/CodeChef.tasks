using System;
using System.Collections.Generic;

namespace CarChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int testCases = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double x1 = double.Parse(input[0]);
                double x2 = double.Parse(input[1]);   
                double y1 = double.Parse(input[2]);   
                double y2 = double.Parse(input[3]);
                if ((y1/x1)<(y2/x2))
                {
                    result.Add(-1);
                }
                else if ((y1/x1)>(y2/x2))
                {
                    result.Add(1);
                }
                else if ((y1/x1) == (y2/x2))
                {
                    result.Add(0);

                }
                
                


            }
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
