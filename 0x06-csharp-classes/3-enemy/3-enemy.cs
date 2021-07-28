using System;

namespace Enemies
{
	///<summary>Defines a Zombie.</summary>
	public class Zombie
	{
		///<summary>Zombie health.</summary>
		private int health;

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

		/// <summary>gets the health of the zombie.</summary>
		public int GetHealth()
		{
			return health;
		}
	}
}
