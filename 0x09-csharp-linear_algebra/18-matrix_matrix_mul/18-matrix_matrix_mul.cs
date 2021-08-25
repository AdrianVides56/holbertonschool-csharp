///<summary>Initializes class.</summary>
class MatrixMath
{
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
					aux += matrix1[row, idx] * matrix2[idx, col];
				res[row, col] = aux;
			}
		}

		return res;
	}
}
