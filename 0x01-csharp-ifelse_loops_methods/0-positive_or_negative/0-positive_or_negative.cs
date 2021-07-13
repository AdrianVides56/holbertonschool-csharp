using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number > 0)
        {
            Console.Write(number + " is positive\n");
        }
        else if (number < 0)
        {
            Console.Write(number + " is negative\n");
        }
        else
            Console.Write(number + " is zero\n");
    }
}
