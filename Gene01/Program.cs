using System;

namespace Gene01
{
    internal class Program
    {
        static void Main()
        {

            string parents = Console.ReadLine();
            char child = ' ';
            char firstParent = parents[0];
            char secondParent = parents[2];
            
            if (firstParent == 'R' || secondParent == 'R' )
            {
                child = 'R';
            }
            else if (firstParent == 'B' || secondParent == 'B')
            {
                child = 'B';
            }
            else if (firstParent == 'G' || secondParent == 'G')
            {
                child = 'G';
            }

            Console.WriteLine(child);
        }
           
        
    }
}
