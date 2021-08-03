using System;

///<summary>Defines a Shape.</summary>
class Shape
{
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

/// <summary>Defines a Rectangle.</summary>
class Rectangle : Shape
{
	///<summary>Width of the rectangle.</summary>
	private int width;
	///<summary>Height of the rectangle.</summary>
	private int height;
	///<summary>Gets or sets the width of the rectangle.</summary>
	public int Width
	{
		get { return width; }
		set
		{
			if (value < 0)
				throw new ArgumentException("Width must be greater than or equal to 0");
			else
				width = value;
		}
	}
	///<summary>Gets or sets the height of the rectangle.</summary>
	public int Height
	{
		get { return height; }
		set
		{
			if (value < 0)
				throw new ArgumentException("Height must be greater than or equal to 0");
			else
				height = value;
		}
	}

}
