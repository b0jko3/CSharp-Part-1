using System;

class ThirdDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int digit = (n / 100) % 10;

        if (digit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + digit);
        }
    }
}