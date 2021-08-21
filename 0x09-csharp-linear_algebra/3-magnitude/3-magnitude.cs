using System;

///<summary>Initialize class.</summary>
class VectorMath
{
	///<summary>Calculates the length of a given vector.</summary>
	public static double Magnitude(double[] vector)
	{
		double sum = 0;
		if (vector.Length < 2.0)
			return -1;
		foreach (var i in vector)
			sum += Math.Pow(i, 2);
		sum = Math.Sqrt(sum);

		return Math.Round(sum, 2);
	}
}