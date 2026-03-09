using System;

/// <summary>Shape class</summary>
class Shape
{
    /// <summary>Calculates the area</summary>
    /// <returns>The area</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Rectangle class that inherits from Shape</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Gets or sets the width</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>Gets or sets the height</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>Calculates the area of the rectangle</summary>
    /// <returns>The area</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>Returns string representation of the rectangle</summary>
    /// <returns>String representation</returns>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

/// <summary>Square class that inherits from Rectangle</summary>
class Square : Rectangle
{
    private int size;

    /// <summary>Gets or sets the size</summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Width = value;
            Height = value;
        }
    }

    /// <summary>Returns string representation of the square</summary>
    /// <returns>String representation</returns>
    public override string ToString()
    {
        return string.Format("[Square] {0} / {1}", size, size);
    }
}
