using System;


///<summary>Initialize class.</summary>
class Queue<T>
{
	public Node head, tail;
	public int count;

	///<summary>Returns Queue's type.</summary>
	public Type CheckType() => typeof(T);

	///<summary>Returns number of nodes in queue.</summary>
	public int Count() => count;

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

	///<summary>Prints the queue.</summary>
	public void Print()
	{
		Node current = head;
		if (count == 0)
		{
			Console.WriteLine("Queue is empty");
			return;
		}
		while (current != null)
		{
			Console.WriteLine(current.value);
			current = current.next;
		}
	}

	///<summary>Concatenates all values in the queue if que is of type String or Char.</summary>
	public string Concatenate()
	{
		if (count == 0)
		{
			Console.WriteLine("Queue is empty");
			return null;
		}
		if (CheckType() == typeof(String) || CheckType() == typeof(Char))
		{
			string result = "";
			Node current = head;
			while (current != null)
			{
				result += current.value;
				if (CheckType() == typeof(String) && current.next != null)
					result += " ";
				current = current.next;
			}
			return result;
		}
		else
		{
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
			return null;
		}
	}

	///<summary>Initialize new Node.</summary>
	public class Node
	{
		public T value;
		public Node next = null;

		///<summary>Constructor for new Node.</summary>
		public Node(T value) => this.value = value;
	}
}
