using System;

namespace Dev_10
{
    // Task :  there are N arrays of double values. 
    // Create an array that includes elements that entered at least two arrays.
    class EntryPoint
    {
          const string ERRORMESSAGE = "Error!";
        const string TEXTFORREPEATINGVALUES = "Values are included in two arrays: ";
        static void Main(string[] args)
        {
            try
            {
                ArrayMaker arrayMaker = new ArrayMaker();
                if (arrayMaker.Create())
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
