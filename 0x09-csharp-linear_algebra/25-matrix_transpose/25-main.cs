class Program
{
	static void Main(string[] args)
	{
		double[,] m = new double[,] {
			{ 1, 2, 3 },
			{ 4, 5, 6 },
			{ 7, 8, 9 }
		};

		double[,] res = MatrixMath.Transpose(m);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			System.Console.Write("( ");
			for (int j = 0; j < res.GetLength(1); j++)
				System.Console.Write(res[i, j] + " ");
			System.Console.WriteLine(")");
		}
	}
}