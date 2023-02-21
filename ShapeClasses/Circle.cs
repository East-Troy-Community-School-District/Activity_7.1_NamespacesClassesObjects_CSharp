using System;

namespace Shape
{
    /// <summary>
    /// Represents a circle.
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Gets the length of the radius.
        /// </summary>
        public int Radius { get; }

        /// <summary>
        /// Constructs a Circle object.
        /// </summary>
        /// <param name="length">The radius of the circle.</param>
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}