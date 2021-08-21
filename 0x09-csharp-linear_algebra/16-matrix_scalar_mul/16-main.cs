class Program
{
	static void Main(string[] args)
	{
		double[,] m = new double[,] {
			{ -13, 10, 8 },
			{ 2, 0, 14 },
			{ -4, -5, 2 }
		};
		double num = 4;
		double[,] res = MatrixMath.MultiplyScalar(m, num);

		for (int i = 0; i < res.GetLength(0); i++)
		{
			for (int j = 0; j < res.GetLength(1); j++)
				System.Console.Write(res[i, j] + " ");
			System.Console.WriteLine();
		}
	}
}