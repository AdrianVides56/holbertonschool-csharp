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
