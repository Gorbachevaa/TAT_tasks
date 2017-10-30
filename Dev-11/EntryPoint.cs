using System;
using System.Collections.Generic;
namespace Dev_11
{
    // Main method of the class converts a string has written in Cyrillic to a line written in Latin,
    // and vice versa. Transformation according to the transliteration rules.
    // Results displays in the console.
    class EntryPoint
    {
        const string ERRORMESSAGE = "Error!";
        const string LATINLETTERS = "Wrong data! Letters should be Cyrillic only!";
        static void Main(string[] args)
        {
            try
            {
                FileReader fr = new FileReader();
                fr.Output();
                List<string> str = fr.TextFile;
                if (!(new AlphabetTypeChecker(str[0]).Check()))
                {
                    AlphabetTypeChanger atc = new AlphabetTypeChanger();
                    Console.WriteLine(atc.CyrToLat(str[0]));
                    Console.WriteLine(atc.LatToCyr());
                }
                else
                {
                    Console.WriteLine(LATINLETTERS);
                }
            }
            catch (Exception ex)
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