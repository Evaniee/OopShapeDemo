using System;

namespace OopShapeDemo
{
    /// <summary>
    /// _length refers to the diameter.
    /// </summary>
    public class Circle: Regular2DShape
    {
        /// <summary>
        /// The circle radius, half the diameter
        /// </summary>
        readonly double _radius;

        /// <summary>
        /// Represents a circle
        /// </summary>
        /// <param name="diameter">The diameter of the circle</param>
        public Circle(double diameter) : base(diameter)
        {
            _radius = diameter / 2d;
        }
        
        /// <summary>
        /// Forumla: A = pi*r^2
        /// </summary>
        /// <returns>The area of the circle</returns>
        public override double Area()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}