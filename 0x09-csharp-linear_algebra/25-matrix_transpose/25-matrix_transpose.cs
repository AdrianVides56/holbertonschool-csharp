///<summary>Initialize class.</summary>
class MatrixMath
{
	/// <summary>Transposes a matrix.</summary>
	/// <param name="matirx">The matrix.</param>
	/// <returns>The transposed matrix.</returns>
	public static double[,] Transpose(double[,] matrix)
	{
		if (matrix.Length == 0)
			return new double[,] {};

		double[,] trans = new double[matrix.GetLength(1), matrix.GetLength(0)];

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				trans[j, i] = matrix[i, j];
		}

		return trans;
	}
}
