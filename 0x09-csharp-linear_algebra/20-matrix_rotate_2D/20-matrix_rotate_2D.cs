using System;


///<summary>Initialize class.</summary>
class MatrixMath
{
	///<summary>Rotates a 2D matrix.</summary>
	///<param name="matrix">The matrix to rotate.</param>
	///<param name="angle">Angle to rotate.</param>
	///<returns>New rotated matrix.</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] {{ -1 }};

		double[,] mRotation = new double[,] {
			{ Math.Cos(angle), Math.Sin(angle) },
			{ Math.Sin(angle * -1), Math.Cos(angle) },
		};

		return Multiply(matrix, mRotation);
	}

	///<summary>Multiplies two matrices.</summary>
	///<param name="matrix1">First matrix.</param>
	///<param name="matrix2">Second matrix.</param>
	///<returns>The new multiplied matrix.</returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		double rowsA = matrix1.GetLength(0), colsA = matrix1.GetLength(1);
		double rowsB = matrix2.GetLength(0), colsB = matrix2.GetLength(1);
		double[,] res = new double[(int)rowsA, (int)colsB];
		double aux = 0;

		if (colsA != rowsB) // checks if the matrices can be multiplied
			return new double[,] {{ -1 }};

		for (int row = 0; row < rowsA; row++)
		{
			for (int col= 0; col < colsB; col++)
			{
				aux = 0;
				for (int idx = 0; idx < rowsB; idx++)
					aux += Math.Round(matrix1[row, idx] * matrix2[idx, col], 2);
				res[row, col] = Math.Round(aux, 2);
			}
		}

		return res;
	}
}