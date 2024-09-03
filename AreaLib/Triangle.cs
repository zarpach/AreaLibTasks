using System;
using Microsoft.VisualBasic;

namespace AreaLib
{
    /// <summary>
    /// Represents a triangle and provides functionality to calculate its area using Heron's formula.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Gets the length of side A.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Gets the length of side B.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Gets the length of side C.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
        /// </summary>
        /// <param name="sideA">The length of side A.</param>
        /// <param name="sideB">The length of side B.</param>
        /// <param name="sideC">The length of side C.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("All sides must be greater than zero.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The sum of any two sides must be greater than the remaining side.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public override double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            return area;
        }

        /// <summary>
        /// Checks whether the triangle is right angled or not
        /// </summary>
        /// <returns>The bool result</returns>
        public bool IsRightAngled()
        {
            double[] Sides = {SideA, SideB, SideC};
            Array.Sort(Sides);
            Array.Reverse(Sides);
            return Math.Pow(Sides[0], 2) == Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2);
        }
    }
}
