using System;

namespace Enemies
{
	///<summary>Defines a Zombie.</summary>
	public class Zombie
	{
		///<summary>Zombie health.</summary>
		private int health;
		///<summary>Zombie name.</summary>
		private string name = "(No name)";

		///<summary>Initialize a new instance of <see cref="Zombie"/>.</summary>
		public Zombie() => health = 0;
		
		///<summary>Initialize a new instance of <see cref="Zombie"/>.</summary>
		public Zombie(int value)
		{
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			else
				health = value;
		}

		/// <summary>Gets or sets the name of the zombie.</summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>Gets the health of the zombie.</summary>
		public int GetHealth()
		{
			return health;
		}

		///<summary>Prints the zombie's name and health'.</summary>
		public override string ToString()
		{
			return $"Zombie Name: {name} / Total Health: {health}";
		}
	}
}
