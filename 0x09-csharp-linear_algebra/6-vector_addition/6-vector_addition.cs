using System;


///<summary>Intialize class.</summary>
class VectorMath
{
	///<summary>Adds two vectors.</summary>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		if (vector1.Length != vector2.Length)
			return new double[] { -1 };

		double[] result = new double[vector1.Length];
		for (int i = 0; i < vector1.Length; i++)
		{
			result[i] = vector1[i] + vector2[i];
		}

		return result;
	}
}