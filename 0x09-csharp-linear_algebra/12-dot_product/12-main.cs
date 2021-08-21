class Program
{
	static void Main(string[] args)
	{
		double[] v1 = new double[] { -4, 0, 10 };
		double[] v2 = new double[] { 3, 7, -9 };
		System.Console.WriteLine(VectorMath.DotProduct(v1, v2));
	}
}
