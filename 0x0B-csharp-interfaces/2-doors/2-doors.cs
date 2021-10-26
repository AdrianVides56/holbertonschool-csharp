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
interface IInteractive
{
	/// <summary>Interact.</summary>
	void Interact();
}

/// <summary>Breakable interface.</summary>
interface IBreakable
{
	/// <summary>Durability.</summary>
	int durability { get; set; }
	/// <summary>Break.</summary>
	void Break();
}

/// <summary>Collectable interface.</summary>
interface ICollectable
{
	/// <summary>Is it collectable?</summary>
	bool isCollected { get; set; }
	/// <summary>Collect.</summary>
	void Collect();
}

/// <summary>Represents a door.</summary>
class Door : Base, IInteractive
{
	/// <summary>Constructor.</summary>
	public Door(string name = "Door") => this.name = name;

	/// <summary>Interact.</summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}
