using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length < 1)
            Console.WriteLine();
        else
        {
            for (int i = length; i > 0; i--)
            {
                Console.WriteLine(new String(' ', length - i) + "\\");
            }
            Console.WriteLine();
        }
    }
}