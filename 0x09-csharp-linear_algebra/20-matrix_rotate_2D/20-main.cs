using System;

class Program
{
	static void Main(string[] args)
	{
		double ang = -1.57;
		double[,] m1 = new double[,] {
			{ 1, 2 },
			{ 3, 4}
		};
		
		double[,] res = MatrixMath.Rotate2D(m1, ang);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			for (int j = 0; j < res.GetLength(1); j++)
				System.Console.Write(res[i, j] + " ");
			System.Console.WriteLine();
		}
	}
}