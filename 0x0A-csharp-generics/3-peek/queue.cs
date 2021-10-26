using System;


///<summary>Initialize class.</summary>
class Queue<T>
{
	public Node head, tail;
	public int count;

	///<summary>Returns Queue's type.</summary>
	public Type CheckType() => typeof(T);

	///<summary>creates a new <see cref="Node"/> and adds it to the queue.</summary>
	public void Enqueue(T value)
	{
		count++;
		if (head == null)
		{
			head = new Node(value);
			tail = head;
		}
		else
		{
			tail.next = new Node(value);
			tail = tail.next;
		}
	}

	///<summary>Removes the first node in the queue.</summary>
	///<returns>value of removed node.</returns>
	public T Dequeue()
	{
		if (count == 0)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		T value = head.value;
		count--;
		head = head.next;
		return value;
	}

	///<summary>Returns the first node in the queue.</summary>
	///<returns>value of first node.</returns>
	public T Peek()
	{
		if (count == 0)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		return head.value;
	}

	public int Count() => count;

	///<summary>Initialize new Node.</summary>
	public class Node
	{
		public T value;
		public Node next = null;

		///<summary>Constructor for new Node.</summary>
		public Node(T value) => this.value = value;
	}
}
