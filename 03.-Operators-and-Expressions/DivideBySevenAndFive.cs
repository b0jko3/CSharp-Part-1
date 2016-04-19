using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int nfive = number % 5;
        int nseven = number % 7;
        if((nfive == 0) && (nseven == 0))
        {
            Console.WriteLine("true " + number);
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}
