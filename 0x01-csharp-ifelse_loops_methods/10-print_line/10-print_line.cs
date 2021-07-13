using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length < 1)
            Console.WriteLine();
        else
        {
            string myLine = new String('_', length);
            Console.WriteLine(myLine);
        }
    }
}
