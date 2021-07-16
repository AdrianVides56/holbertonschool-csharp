using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> node = myLList.First;

		if (myLList.First.Value >= n)
		{
			myLList.AddFirst(n);
			return myLList.First;
		}

		for (; node.Value < n; node = node.Next)
		{
			if (node.Next == null)
			{
				myLList.AddLast(n);
				return myLList.Last;
			}
		}
		myLList.AddBefore(node, n);
		return node.Previous;
	}
}
