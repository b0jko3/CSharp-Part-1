using System;

class IntDoubleandString
{
    static void Main()
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "integer":
                {
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                }
            case "real":
                {
                    double number = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", number + 1);
                    break;
                }
            case "text":
                {
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
                }
        }
    }
}
