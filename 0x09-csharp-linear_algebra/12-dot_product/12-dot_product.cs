using System;


///<summary>Initialize class.</summary>
class VectorMath
{
	///<summary>Calculate the dot product of two vectors.</summary>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length != vector2.Length || vector1.Length < 2 ||
			vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
			return -1;
		
		double result = 0, aux = 0;
		for (int i = 0; i < vector1.Length; i++)
		{
			aux = vector1[i] * vector2[i];
			result += aux;
		}

		return result;
	}
}