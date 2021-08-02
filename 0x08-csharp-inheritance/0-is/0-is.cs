using System;

/// <summary>Represents an object.</summary>
class Obj
{
	/// <summary>Checks if the specified object is of int type.</summary>
	public static bool IsOfTypeInt(object obj)
	{
		return obj.GetType() == typeof(int);
	}
}
