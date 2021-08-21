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
			sum += Math.Round(Math.Pow(i, 2), 2);
		sum = Math.Round(Math.Sqrt(sum), 2);

		return Math.Round(sum, 2);
	}
}