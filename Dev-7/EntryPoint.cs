using System;

namespace Dev_7
{
    /// <summary>
    /// Class contains the entry point of rhe programm.
    /// </summary>
    class EntryPoint
    {
        const string INVALID_SIDES = "Triangle's sides should be positive.Try enter valid numbers.";
        const string TRIANGLE_EXISTANCE = "Triangle doesn't exist.Try enter right numbers.";
        const string FORMAT_ESCEPTION = "Only numbers are needed. Please enter them.";
        const string EXITPROMPT = "Press any key to exit.";
        /// <summary>
        /// First sides of a triangle is inputed.
        /// Then Checker method is called. It checks if sides is valid(> 0) and if sides form the triangle.
        /// Then class Builder is appeared. It determines the type of the triangle and return the type.
        /// And the end of the program the type is outputed to the console.
        /// If the sides is invalid, sides don't form the triangle or the user wants to check another
        /// triangle, then the program is continued.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    double[] sides = new SidesInputer().SidesInput();
                    Checker checker = new Checker();
                    if (!checker.IsValidSides(sides))
                    {
                        Console.WriteLine(INVALID_SIDES);
                        continue;
                    }
                    if (!checker.IsTriangle(sides))
                    {
                        Console.WriteLine(TRIANGLE_EXISTANCE);
                        continue;
                    }
                    Builder builder = new Builder(sides);
                    Triangle triangle = builder.Build(sides);
                    Console.WriteLine(triangle.GetTrType());
                    Console.WriteLine(EXITPROMPT);
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine(FORMAT_ESCEPTION);
                    continue;
                }
                continueProgram = false;
            }
        }
    }
}
