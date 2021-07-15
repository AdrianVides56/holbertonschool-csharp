using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        int[] myArray = new int[size];
        if (size == 0)
        {
            Console.WriteLine("");
        }
        else
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
                if (i != myArray.Length - 1)
                    Console.Write(myArray[i]+ " ");
                else
                    Console.Write(myArray[i]);
            }
            Console.WriteLine("");
        }
        
        return myArray;
    }
}
