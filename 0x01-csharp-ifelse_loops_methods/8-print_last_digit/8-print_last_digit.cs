using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number % 10 < 0)
        {
            Console.Write((number % 10) * -1);
            return ((number % 10) * -1);
        }
        Console.Write(number % 10);
        return number % 10;
    }
}