class Program
{
	static void Main(string[] args)
	{
		double[] v1 = new double[] { 0, -16, 31 };
		double num = 4;
		double[] res = VectorMath.Multiply(v1, num);

		foreach (var i in res)
		{
			System.Console.Write(i.ToString() + " ");
		}
	}
}