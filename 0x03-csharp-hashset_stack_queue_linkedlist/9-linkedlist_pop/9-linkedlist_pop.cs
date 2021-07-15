using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		try
		{
			int data = myLList.First.Value;
			myLList.RemoveFirst();
			return data;
		}
		catch (Exception)
		{
			return 0;
		}
	}
}