class Program
{
	static void Main(string[] args)
	{
		double[,] m = new double[,] {
			{ -4, 9, 0 },
			{ 1, -2, 1 },
			{ 3, -4, 2}
		};

		double res = MatrixMath.Determinant(m);

		System.Console.WriteLine(res);
	}
}