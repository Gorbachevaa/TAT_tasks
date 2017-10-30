using System;

namespace Dev_7
{
    /// <summary>
    /// Triangle class with all equal sides.
    /// </summary>
    class EqualiteralTriangle : Triangle
    {
        const string EQUALITERAL_TYPE = "The triangle is equaliteral.";
        public EqualiteralTriangle(double[] sides) : base(sides) { }
        public override string GetTrType()
        {
            return EQUALITERAL_TYPE;
        }
    }
}
