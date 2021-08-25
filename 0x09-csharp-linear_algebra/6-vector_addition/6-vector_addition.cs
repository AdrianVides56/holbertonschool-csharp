using System;


///<summary>Intialize class.</summary>
class VectorMath
{
	///<summary>Adds two vectors.</summary>
	///<param name="vector1">First vector.</param>
	///<param name="vector2">Second vector.</param>
	///<returns>A new vector with the adition.</returns>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		if (vector1.Length != vector2.Length || vector1.Length < 2 ||
			vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
			return new double[] { -1 };

		double[] result = new double[vector1.Length];
		for (int i = 0; i < vector1.Length; i++)
			result[i] = vector1[i] + vector2[i];

		return result;
	}
}
