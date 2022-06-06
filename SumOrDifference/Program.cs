using System;

namespace SumOrDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int result = 0;
            if (n1 > n2)
            {
                result = (n1 - n2);
            }
            else
            {
               result = ( n1 + n2);
            }
            Console.WriteLine(result);
        }
    }
}
