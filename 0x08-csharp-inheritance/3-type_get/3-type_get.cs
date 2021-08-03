using System;

/// <summary>Represents an object.</summary>
class Obj
{
	/// <summary>Prints the methods and properties of the object.</summary>
	public static void Print(object myObj)
	{
		Type type = myObj.GetType();

		Console.WriteLine(type.Name + " Properties:");
		foreach (var property in type.GetProperties())
			Console.WriteLine(property.Name);

		Console.WriteLine(type.Name + " Methods:");
		foreach (var method in type.GetMethods())
			Console.WriteLine(method.Name);
	}
}
