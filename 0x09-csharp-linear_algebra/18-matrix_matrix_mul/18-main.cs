class Program
{
	static void Main(string[] args)
	{
		double[,] m1 = new double[,] {
			{ 1, 3, -2 }
		};
		double[,] m2 = new double[,] {
			{ 4, 5 },
			{ -2, 1 },
			{ 3, 6 }
		};

		double[,] res = MatrixMath.Multiply(m1, m2);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			for (int j = 0; j < res.GetLength(1); j++)
				System.Console.Write(res[i, j] + " ");
			System.Console.WriteLine();
		}
	}
}