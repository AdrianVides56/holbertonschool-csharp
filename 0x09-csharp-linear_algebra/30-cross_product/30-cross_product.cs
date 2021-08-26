using System;


///<summary>Initialize class.</summary>
class VectorMath
{
	///<summary>Calculates the Cross Product of two 3D vectors.</summary>
	///<param name="vector1"> first Vector.</param>
	///<param name="vector2"> second Vector.</param>
	///<returns> the cross product.</returns>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length != 3 || vector2.Length != 3)
			return new double[] { -1 };

		double[] crossVector = new double[vector1.Length];

		crossVector[0] = Math.Round(Multiply(vector1[1], vector2[2]) - Multiply(vector1[2], vector2[1]), 2);
		crossVector[1] = Math.Round(Multiply(vector1[0], vector2[2]) - Multiply(vector1[2], vector2[0]), 2);
		crossVector[2] = Math.Round(Multiply(vector1[0], vector2[1]) - Multiply(vector1[1], vector2[0]), 2);

		return crossVector;
	}

	///<summary>Multiply 2 doubles.</summary>
	///<param name="v1">first double</param>
	///<param name="v2"> second double</param>
	///<returns>product of 2 doubles</returns>
	public static double Multiply(double v1, double v2)
	{
		return Math.Round(v1 * v2, 2);
	}
}
