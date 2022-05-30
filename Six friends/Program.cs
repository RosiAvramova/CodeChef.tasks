using System;

namespace Six_friends
{
    internal class Program
    {
        static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            int doubleRoomPrice = 0;
            int tripleRoomPrice = 0;
            for (int i = 0; i < testCases; i++)
            {
                string prices = Console.ReadLine();
                string[] pricesArr = prices.Split(' ');
                int[] roomPrices = new int[pricesArr.Length];
                for (int j = 0; j < roomPrices.Length; j++)
                {
                    roomPrices[j] = int.Parse(pricesArr[j]);
                }
                doubleRoomPrice = roomPrices[0];
                tripleRoomPrice = roomPrices[1];

                int result = 0;
                if (3*doubleRoomPrice >= 2*tripleRoomPrice)
                {
                    result = 2 * tripleRoomPrice;
                }
                else
                {
                    result = 3 * doubleRoomPrice;
                }

                Console.WriteLine(result);
            }
            
        }
    }
}
