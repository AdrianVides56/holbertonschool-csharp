class Program
{
	static void Main(string[] args)
	{
		double[] v1 = new double[] { 2, -2, 1 };
		double[] v2 = new double[] { -8, 8, -4 };
		double[] crossVector = VectorMath.CrossProduct(v1, v2);

		foreach (double v in crossVector)
			System.Console.Write(v.ToString() + " ");
		System.Console.WriteLine();
	}
}