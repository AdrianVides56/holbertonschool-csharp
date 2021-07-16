using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> node = new LinkedListNode<int>(n);

		if (myLList.First.Value > n)
		{
			myLList.AddFirst(node);
			return myLList.First;
		}
		else if (myLList.Last.Value < n)
		{
			myLList.AddLast(node);
			return myLList.Last;
		}

		node = myLList.First;
		while (true)
		{
			if (node.Next.Value > n && node.Previous.Value < n)
				break;
			node = node.Next;
		}
		myLList.AddAfter(node, n);
		return node;
	}
}
