using System;

namespace Dev_7
{
    /// <summary>
    /// Abstract class Triangle which represents all the triangles.
    /// </summary>
     public abstract class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle (double[] sides)
        {
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }
         /// <summary>
         /// Method gets the triangle's type.
         /// </summary>
         /// <returns> String value of the triangle's type. </returns>
        public abstract string GetTrType();
    }
}
