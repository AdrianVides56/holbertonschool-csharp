///<summary>Initialize class.</summary>
class MatrixMath
{
	///<summary>Multyplies a matrix by a number.</summary>
	///<param name="matrix">The matrix.</param>
	///<param name="scalar">The multiplier.</param>
	///<returns>The new multiplied matrix.</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		if (Check(matrix))
			return new double[,] { { -1 } };

		double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				result[i, j] = matrix[i, j] * scalar;
		}

		return result;
	}

	///<summary>Checks if the matrix is 2D or 3D.</summary>
	///<param name="matrix">The matrix to check.</param>
	///<returns>False if the matrix is 2D or 3D, True otherwise.</returns>
	public static bool Check(double[,] matrix)
	{
		if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
			return true;
		if (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
			return true;
		return false;
	}
}
