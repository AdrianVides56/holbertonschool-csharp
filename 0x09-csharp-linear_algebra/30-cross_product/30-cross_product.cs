///<summary>Initialize class.</summary>
class VectorMath
{
	///<summary>Calculates the Cross Product of two 3D vectors.</summary>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length != 3 || vector2.Length != 3)
			return new double[] { -1 };

		double[] crossVector = new double[vector1.Length];

		crossVector[0] = Multiply(vector1[1], vector2[2]) - Multiply(vector1[2], vector2[1]);
		crossVector[1] = Multiply(vector1[0], vector2[2]) - Multiply(vector1[2], vector2[0]);
		crossVector[2] = Multiply(vector1[0], vector2[1]) - Multiply(vector1[1], vector2[0]);

		return crossVector;
	}

	public static double Multiply(double v1, double v2)
	{
		return v1 * v2;
	}
}