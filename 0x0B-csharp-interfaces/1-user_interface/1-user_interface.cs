using System;


/// <summary>Base class.</summary>
abstract class Base
{
	/// <summary>Name of the object.</summary>
	public string name { get; set; }

	/// <summary>Representation of the object.</summary>
	public override string ToString()
	{
		return $"{name} is a {this.GetType()}";
	}
}

/// <summary>Interact interface.</summary>
interface Iinterface
{
	/// <summary>Interact.</summary>
	void Interact();
}

/// <summary>Breakable interface.</summary>
interface Ibreakable
{
	/// <summary>Durability.</summary>
	int durability { get; set; }
	/// <summary>Break.</summary>
	void Break();
}

/// <summary>Collectable interface.</summary>
interface Icollectable
{
	/// <summary>Is it collectable?</summary>
	bool isCollectable { get; set; }
	/// <summary>Collect.</summary>
	void Collect();
}

/// <summary>Test class.</summary>
class TestObject : Base, Iinterface, Ibreakable, Icollectable
{
	/// <summary>Interact.</summary>
	public void Interact()
	{}
	/// <summary>Durability.</summary>
	public int durability { get; set; }
	/// <summary>Break.</summary>
	public void Break()
	{}
	/// <summary>Is it collectable?</summary>
	public bool isCollectable { get; set; }
	/// <summary>Collect.</summary>
	public void Collect()
	{}
}