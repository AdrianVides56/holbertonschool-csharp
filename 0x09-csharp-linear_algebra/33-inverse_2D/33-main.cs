class Program
{
	static void Main(string[] args)
	{
		double[,] m = new double[,] { 
			{ 4, 7 },
			{ 2, 6 }
		};
		double[,] res = MatrixMath.Inverse2D(m);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			for (int j = 0; j < res.GetLength(1); j++)
				System.Console.Write(res[i, j] + " ");
			System.Console.WriteLine();
		}

		m = new double[,] { 
			{ 4, 6 },
			{ 4, 6 }
		};
		res = MatrixMath.Inverse2D(m);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			for (int j = 0; j < res.GetLength(1); j++)
				System.Console.Write(res[i, j] + " ");
			System.Console.WriteLine();
		}
	}
}