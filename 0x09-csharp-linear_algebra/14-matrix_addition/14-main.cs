class Program
{
	static void Main(string[] args)
	{
		double[,] m1 = new double[,] {
			{ 14, -3, 0 },
			{ -11, -5, 3 },
			{ 2, -9, 13 }
		};
		double[,] m2 = new double[,] {
			{ 6, 16, 21 },
			{ 5, 2, 0 },
			{ 1, 3, 7 }
		};

		double[,] res = MatrixMath.Add(m1, m2);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			for (int j = 0; j < res.GetLength(1); j++)
			{
				System.Console.Write(res[i, j] + " ");
			}
			System.Console.WriteLine();
		}
	}
}