using System;

namespace Dev_7
{
    /// <summary>
    /// Triangle class with  any two equal sides.
    /// </summary>
    public class IsosceleTriangle: Triangle
    {
        const string ISOSCELE_TYPE = "The triangle is isoscele.";
        public IsosceleTriangle (double[] sides) : base(sides) {}
        public override string GetTrType()
        {
            return ISOSCELE_TYPE;
        }
    }
}
