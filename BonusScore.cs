using System;

class BonusScore
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 3)
        {
            Console.WriteLine(n * 10);
        }
        else if (4 <= n && n <= 6)
        {
            Console.WriteLine(n * 100);
        }
        else if (7 <= n && n <= 9)
        {
            Console.WriteLine(n * 1000);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}