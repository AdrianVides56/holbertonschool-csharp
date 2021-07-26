using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		int idx = 0; 
		try
		{
			while (idx < n)
			{
				Console.WriteLine(myList[idx++]);
			}
			return idx;
		}
		catch (ArgumentOutOfRangeException)
		{
			return idx - 1;
		}
	}
}
