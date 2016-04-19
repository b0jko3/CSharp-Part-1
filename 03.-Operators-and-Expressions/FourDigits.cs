using System;

class FourDigits
{
    static void Main()
    {
        int fourDigitNumber = int.Parse(Console.ReadLine());
        int firstDigit = fourDigitNumber / 1000;
        int firstMinus = firstDigit * 1000;
        int secondDigit = (fourDigitNumber - firstMinus) / 100;
        int secondMinus = (fourDigitNumber / 100) * 100;
        int thirdDigit = (fourDigitNumber - secondMinus) / 10;
        int thirdMinus = (fourDigitNumber / 10) * 10;
        int fourthDigit = fourDigitNumber - thirdMinus;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}
