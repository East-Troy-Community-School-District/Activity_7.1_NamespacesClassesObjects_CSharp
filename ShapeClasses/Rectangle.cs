using System;

namespace Shape
{
    /// <summary>
    /// Represents a rectangle.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Gets the length of the rectangle.
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// Gets the width of the rectangle.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Constructs a Rectangle object.
        /// </summary>
        /// <param name="length">The length of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }
}