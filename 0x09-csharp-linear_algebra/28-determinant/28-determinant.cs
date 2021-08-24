///<summary>Initialize class.</summary>
class MatrixMath
{
	///<summary>Caluclates the determinant of a 2D or 3D matrix.</summary>
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
			matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
			return -1;

		double[,] sarMatrix = sarrusMatrix(matrix);
		double det = 0, aux = 1;

		for (int i = 0; i < matrix.GetLength(0); i++, aux = 1)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				aux *= sarMatrix[i + j, j];
			det += aux;
		}
		for (int i = 0, tmp = 0; i < matrix.GetLength(0); i++, aux = 1, tmp = i)
		{
			for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
				aux *= sarMatrix[tmp++, j];
			det -= aux;
		}

		return det;

	}

	///<summary>Set the matrix to be use the Sarrus method.</summary>
	public static double[,] sarrusMatrix(double[,] matrix)
	{
		double[,] sarr = new double[matrix.GetLength(0) + 2, matrix.GetLength(1)];

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				sarr[i, j] = matrix[i, j];
		}

		for (int i = 1; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				sarr[i + 2, j] = matrix[i - 1, j];
		}

		return sarr;
	}
}