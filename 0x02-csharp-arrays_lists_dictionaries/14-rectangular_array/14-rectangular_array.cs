using System;

namespace Array
{
    class ReactangularArray
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];

            arr[2, 2] = 1;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4)
                        Console.Write($"{arr[i, j]} ");
                    else
                        Console.WriteLine(arr[i, j]);
                }
        }
    }
}