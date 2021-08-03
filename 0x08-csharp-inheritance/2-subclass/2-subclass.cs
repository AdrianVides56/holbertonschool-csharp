using System;

/// <summary>Represents an object.</summary>
class Obj
{
	/// <summary>Checks if the specified object is just an instance of the derived type.</summary>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		return baseType != derivedType && baseType.IsAssignableFrom(derivedType);
	}
}
