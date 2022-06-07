using System;
using System.Collections.Generic;

namespace AvoidContact
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            int tastCases = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            for (int i = 0; i < tastCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int familyTrip = int.Parse(input[0]);
                int friendsTrip = int.Parse(input[1]);
                int holiday = int.Parse(input[2]);
                if (familyTrip + friendsTrip <= holiday)
                {
                    result.Add("YES");
                }
                else if (friendsTrip + familyTrip > holiday)
                {
                    result.Add("NO");
                }
            }
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
