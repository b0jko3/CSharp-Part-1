using System;

class Sort3Numbers
{
    static void Main()
    {
        int nFirst = int.Parse(Console.ReadLine());
        int nSecond = int.Parse(Console.ReadLine());
        int nThird = int.Parse(Console.ReadLine());

        if (nFirst > nSecond && nFirst > nThird)
        {
            if (nSecond > nThird)
            {
                Console.WriteLine("{0} {1} {2}", nFirst, nSecond, nThird);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", nFirst, nThird, nSecond);
            }
        }
        else if (nSecond > nFirst && nSecond > nThird)
        {
            if (nFirst > nThird)
            {
                Console.WriteLine("{0} {1} {2}", nSecond, nFirst, nThird);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", nSecond, nThird, nFirst);
            }
        }
        else
        {
            if (nFirst > nSecond)
            {
                Console.WriteLine("{0} {1} {2}", nThird, nFirst, nSecond);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", nThird, nSecond, nFirst);
            }
        }
    }
}
