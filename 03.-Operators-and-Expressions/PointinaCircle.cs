using System;

class PointinaCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double d = (x * x) + (y * y);
        bool isInCircle = d <= 4;
        if (isInCircle == true)
        {
            Console.WriteLine("yes " + "{0:F2}", Math.Sqrt(d));
        }
        else
        {
            Console.WriteLine("no " + "{0:F2}", Math.Sqrt(d));
        }
    }
}
