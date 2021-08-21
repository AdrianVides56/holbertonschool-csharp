class Program
{
	static void Main(string[] args)
	{
		double[] vector1 = new double[]{ 14, -2, 0 };
		double[] vector2 = new double[]{ -3, 23 };
		double[] res = VectorMath.Add(vector1, vector2);

		foreach (var i in res)
			System.Console.Write(i.ToString() + " ");
	}
}