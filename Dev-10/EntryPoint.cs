using System;

namespace Dev_10
{
    // Main method of this class creates N arrays of double values.  
    // Creates an array, consists of elements that included at least in 2 arrays.
    // Result is displayed in the Console.
    class EntryPoint
    {
        const string ERRORMESSAGE = "Error!";
        const string TEXTFORREPEATINGVALUES = "Values are included in two arrays: ";
        static void Main(string[] args)
        {
            try
            {
                ArrayMaker arrayMaker = new ArrayMaker();
                if (arrayMaker.CheckIfElementsEquals())
                {
                    Console.WriteLine(TEXTFORREPEATINGVALUES);
                    arrayMaker.Output();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ERRORMESSAGE, ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
