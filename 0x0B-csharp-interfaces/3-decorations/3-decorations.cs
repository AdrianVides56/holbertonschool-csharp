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

/// <summary>Represents a decorable door.</summary>
class Decoration : Base, IInteractive, IBreakable
{
	/// <summary>isQuestItem.</summary>
	public bool isQuestItem { get; set; }
	/// <summary>Durability.</summary>
	public int durability { get; set; }

	/// <summary>Constructor.</summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability <= 0)
			throw new Exception("Durability must be greater than 0");
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	/// <summary>Interacts with an object.</summary>
	public void Interact()
	{
		if (durability <= 0)
			Console.WriteLine($"The {name} has been broken.");
		else if (isQuestItem)
			Console.WriteLine($"You look at the {name}. There's a key inside.");
		else
			Console.WriteLine($"You look at the {name}. Not much to see here.");
	}

	/// <summary>Breaks an object.</summary>
	public void Break()
	{
		durability--;
		if (durability > 0)
			Console.WriteLine($"You hit the {name}. It cracks.");
		else if (durability == 0)
			Console.WriteLine($"You smash the {name}. What a mess.");
		else
			Console.WriteLine($"The {name} is already broken.");
	}
}
