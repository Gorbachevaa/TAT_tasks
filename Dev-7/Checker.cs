using System;

namespace Dev_7
{
    /// <summary>
    /// Class checks side's validity and existance of the triangle.
    /// </summary>
    public class Checker
    {
        /// <summary>
        /// Checks triangle's existance.
        /// </summary>
        /// <param name="sides">A double array of three triangle's sides.</param>
        /// <returns>Bool value. True if triangle exists, false if it's not.</returns>
        public bool IsTriangle(double[] sides)
        {
            return ((sides[0] + sides[1] >= sides[2]) && (sides[1] + sides[2] >= sides[0]) &&
            (sides[0] + sides[2] >= sides[1]));
        }
        /// <summary>
        /// Checks side's validity.
        /// </summary>
        /// <param name="sides">A double array of three triangle's sides.</param>
        /// <returns>Bool value. True if sides are valid, false if it's not.</returns>
        public bool IsValidSides(double[] sides)
        {
            return ((sides[0] > 0) && (sides[1]) > 0 && (sides[2] > 0));
            
        }
    }
}
