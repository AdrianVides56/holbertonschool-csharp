using System;


/// <summary>calculates the player's health.</summary>
delegate void CalculateHealth(float damage);

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

	/// <summary>Damage the player.</summary>
	/// <param name="damage">The amount of damage.</param>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
		{
			Console.WriteLine($"{this.name} takes 0 damage!");
			return;
		}
		this.hp -= damage;
		Console.WriteLine($"{this.name} takes {damage} damage");
	}

	/// <summary>Heals the player.</summary>
	/// <param name="heal">The amount to heal.</param>
	public void HealDamage(float heal)
	{
		if (heal < 0)
		{
			Console.WriteLine($"{this.name} heals 0 HP!");
			return;
		}
		this.hp += heal;
		Console.WriteLine($"{this.name} heals {heal} HP!");
	}
}
