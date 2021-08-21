using System;


///<summary>Initialize class.</summary>
class VectorMath
{
	///<summary>Multiplies a vector by a number.</summary>
	public static double[] Multiply(double[] vector, double scalar)
	{
		if (vector.Length < 2 || vector.Length > 3)
			return new double[] { -1 };

		double[] result = new double[vector.Length];
		for (int i = 0; i < vector.Length; i++)
			result[i] = vector[i] * scalar;

		return result;
	}
}