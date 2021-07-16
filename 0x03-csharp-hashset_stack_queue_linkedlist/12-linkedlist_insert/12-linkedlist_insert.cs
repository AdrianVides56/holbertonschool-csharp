using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> node = new LinkedListNode<int>(n);

		if (myLList.First.Value > n)
		{
			node.Value = n;
			myLList.AddFirst(node);
			return node;
		}
		else if (myLList.Last.Value < n)
		{
			node.Value = n;
			myLList.AddLast(node);
			return node;
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
