int friends = 0;
int burgerPrice = 0;
int money = 0;
int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string input = Console.ReadLine();
    string[] inputArr = input.Split(' ');
    friends = int.Parse(inputArr[0]);
    burgerPrice = int.Parse(inputArr[1]);
    money = int.Parse(inputArr[2]);

    if (friends * burgerPrice > money)
    {
        Console.WriteLine("NO");

    }
    else
    {
        Console.WriteLine("YES");
    }
}
