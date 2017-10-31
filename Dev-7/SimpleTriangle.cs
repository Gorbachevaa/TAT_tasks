using System;


namespace Dev_7
{
    public class SimpleTriangle : Triangle
    {
        /// <summary>
        /// Triangle class with different sides.
        /// </summary>
        const string SIMPLE_TYPE = "The triagle is simple";
        public SimpleTriangle(double[] sides) : base(sides) {}
        public override string GetTrType()
        {
            return SIMPLE_TYPE;
        }
    }
}
