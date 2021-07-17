using System;
using System.Collections.Generic;

class Matrix
{
	public static int[,] Square(int[,] myMatrix)
	{
		int[,] square = (int[,])myMatrix.Clone();

		for (int i = 0; i < Math.Sqrt(square.Length); i++)
			for (int j = 0; j < Math.Sqrt(square.Length); j++)
				{
					square[i, j] = (int)Math.Pow(square[i, j], 2);
				}
		return square;
	}
}