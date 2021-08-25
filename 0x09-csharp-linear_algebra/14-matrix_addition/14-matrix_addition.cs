///<summary>Initialize class.</summary>
class MatrixMath
{
	///<summary>Adds two matrices.</summary>
	///<param name="matrix1">First matrix.</param>
	///<param name="matrix2">Second matrix.</param>
	///<returns>A new matrix.</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.Length != matrix2.Length || matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3 ||
			matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3)
			return new double[,] { { -1 } };
		double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

		for (int i = 0; i < matrix1.GetLength(0); i++)
		{
			for (int j = 0; j < matrix1.GetLength(1); j++)
				result[i, j] = matrix1[i, j] + matrix2[i, j];
		}

		return result;
	}
}
