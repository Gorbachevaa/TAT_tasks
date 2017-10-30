using System;

namespace Dev_7
{
    enum TriangleType
    {
        Equaliteral,
        Isosceles,
        Simple
    }
    /// <summary>
    /// Class build triangle according to rules. e.g. 
    /// If the sides are equal builder creates Equaliteral triangle.
    /// </summary>
    class Builder
    {
        const double EPS = double.Epsilon;
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Builder(double[] sides)
        {
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }
        /// <summary>
        /// Defines which triangle's type is needed.
        /// </summary>
        /// <param name="sides">Triagle's sides</param>
        /// <returns>/New object of Determined Type.</returns>
        public Triangle Build (double[] sides)
        {
            switch(DetermineType())
            {
                case TriangleType.Equaliteral:
                    {
                        return new EqualiteralTriangle(sides);
                    }
                case TriangleType.Isosceles:
                    {
                        return new IsosceleTriangle(sides);
                    }
                case TriangleType.Simple:
                    {
                        return new SimpleTriangle(sides);
                    }
                default:
                    {
                        throw new InvalidOperationException();
                    }
            }
        }
        /// <summary>
        /// Determines triangle's type.
        /// </summary>
        /// <returns>Triangle type that is enum type.</returns>
        public TriangleType DetermineType()
        {
            TriangleType triangleType = TriangleType.Simple;
            if ((Math.Abs(SideA - SideB) < EPS) 
                && (Math.Abs(SideB - SideC) < EPS)
                && (Math.Abs(SideA - SideC) < EPS))
            {
                triangleType = TriangleType.Equaliteral;
            }
            else
                if ((Math.Abs(SideA - SideB) < EPS)
                || (Math.Abs(SideB - SideC) < EPS)
                || (Math.Abs(SideA - SideC) < EPS))
                {
                    triangleType = TriangleType.Isosceles;
                }
            return triangleType;
        }
    }
}
