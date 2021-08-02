using System;

/// <summary>Represents an object.</summary>
class Obj
{
	/// <summary>Checks if the specified object is an instance of class that inherited from Array.</summary>
	public static bool IsInstanceOfArray(object obj)
	{
		/* if (obj is Array)
			return true;
		return false */
		return obj is Array;
	}
}