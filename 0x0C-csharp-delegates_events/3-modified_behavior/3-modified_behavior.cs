using System;


/// <summary>Modifies the player's behavior.</summary>
public enum Modifier
{
	/// <summary>half of base value.</summary>
	Weak,
	/// <summary>base value.</summary>
	Base,
	/// <summary>one and a half of base value.</summary>
	Strong
}

/// <summary>Calculates efects with the modifier.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
		ValidateHP(hp - damage);
		Console.WriteLine($"{this.name} takes {damage} damage!");
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
		ValidateHP(this.hp + heal);
		Console.WriteLine($"{this.name} heals {heal} HP!");
	}

	/// <summary>Sets the player's health.</summary>
	/// <param name="newHP">The player's new health.</param>
	public void ValidateHP(float newHP)
	{
		if (newHP < 0)
			this.hp = 0;
		if (newHP > this.maxHp)
			this.hp = this.maxHp;
		else
			this.hp = newHP;
	}

	/// <summary>Applies a modifier to the player.</summary>
	/// <param name="baseValue">The base value.</param>
	/// <param name="modifier">The modifier to apply.</param>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
			switch (modifier)
			{
				case Modifier.Weak:
					return baseValue * 0.5f;
				case Modifier.Base:
					return baseValue;
				case Modifier.Strong:
					return baseValue * 1.5f;
				default:
					return baseValue;
			}
	}
}
