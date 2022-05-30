using System;

namespace ATM
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] inputArr = input.Split(' ');

            int withDrawMoney = int.Parse(inputArr[0]);

            float balanceMoney = float.Parse(inputArr[1]);

            float tax = 0.50f;

            float remainingBalance = 0.0f;

            float neededMoney = withDrawMoney + tax;

            if ((neededMoney > balanceMoney) || withDrawMoney % 5 != 0)
            {
                remainingBalance = balanceMoney;
            }
            else
            {
                remainingBalance = balanceMoney - neededMoney;
            }
            Console.WriteLine(remainingBalance.ToString("0.00"));

        }
    }
}
