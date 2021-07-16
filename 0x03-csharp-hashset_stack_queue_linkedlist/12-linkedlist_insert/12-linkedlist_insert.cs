using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> node = myLList.First;

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
