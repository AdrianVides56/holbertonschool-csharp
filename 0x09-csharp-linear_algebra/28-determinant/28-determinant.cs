using System;


///<summary>Initialize class.</summary>
class MatrixMath
{
	///<summary>Caluclates the determinant of a 2D or 3D matrix.</summary>
	///<param name="matrix">The matrix.</param>
	///<returns>The determinant, or -1 if the matrix don't have a determinant or is not neither 2D nor 3D.</returns>
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
			matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3 ||
			matrix.GetLength(0) != matrix.GetLength(1))
			return -1;

		double[,] sarMatrix = sarrusMatrix(matrix);
		double det = 0, aux = 1;

		for (int i = 0; i < matrix.GetLength(0); i++, aux = 1)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				aux *= Math.Round(sarMatrix[i + j, j], 2);
			det += aux;
		}
		for (int i = 0, tmp = 0; i < matrix.GetLength(0); i++, aux = 1, tmp = i)
		{
			for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
				aux *= Math.Round(sarMatrix[tmp++, j], 2);
			det -= aux;
		}

		return Math.Round(det, 2);

	}

	///<summary>Set the matrix to use the Sarrus method.</summary>
	///<param name="matrix">The matrix.</param>
	///<returns>The matrix with 2 aditionnal rows.</returns>
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
