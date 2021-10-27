using System;


/// <summary>Defines a player.</summary>
public class Player
{
	string name { get; set; }
	float maxHp { get; set; }
	float hp { get; set; }

	/// <summary>Initializes a new instance of the <see cref="Player"/> class.</summary>
	/// <param name="name">The player's name.</param>
	/// <param name="maxHp">The player's maximum health.</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp <= 0)
		{
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
			this.maxHp = 100f;
		}
		else
			this.maxHp = maxHp;

		this.name = name;
		this.hp = this.maxHp;
	}

	/// <summary>Prints the player's health.</summary>
	public void PrintHealth() => Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
}
