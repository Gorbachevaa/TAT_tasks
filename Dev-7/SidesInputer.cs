using System;

namespace Dev_7
{
    /// <summary>
    /// Class enters tthe triangle's sides.
    /// </summary>
    class SidesInputer
    {
        const string SIDEAPROMPT = "Please, enter triangle's side: ";
        const string BADVALUE = "Bad value. Please, enter again.";
        const int SIDESAMOUNT = 3;
        double[] Sides { get; set; }
        /// <summary>
        /// Enters one side.
        /// </summary>
        /// <returns> String value which is gotten from keybord.</returns>
        public string SideInput()
        {
            Console.WriteLine(SIDEAPROMPT);
            return Console.ReadLine();
        }
        /// <summary>
        /// Enters 3 sides of the triangle.
        /// </summary>
        /// <returns> Double array with the triangle's sides.</returns>
        public double[] SidesInput()
        {
            Sides = new double[SIDESAMOUNT];
            int i = 0;
            while (i < SIDESAMOUNT)
            {
                if (double.TryParse(SideInput(), out Sides[i]))
                {
                    i++;
                    continue;
                }
            }
            return Sides;
        }
    }
}
