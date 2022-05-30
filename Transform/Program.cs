using System;

namespace Transform
{
    internal class Program
    {
        static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());
            string small = "SMALL";
            string huge = "HUGE";
            string normal = "NORMAL";
            string marioSize = string.Empty; ;

            for (int i = 0; i < testCases; i++)
            {
                int givenMushrooms = int.Parse(Console.ReadLine());
                marioSize = normal;
                for (int mushroomsEaten = 1; mushroomsEaten <= givenMushrooms; mushroomsEaten++)
                {
                    if (marioSize == normal)
                    {
                        marioSize = huge;
                    }
                    else if (marioSize == huge)
                    {
                        marioSize = small;
                    }
                    else
                    {
                        marioSize = normal;
                    }
                }
                Console.WriteLine(marioSize);

                

            }

        }
    }
}
