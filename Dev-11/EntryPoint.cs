using System;
using System.Collections.Generic;
namespace Dev_11
{
    // A programm that converts a string has written in Cyrillic to a line written in Latin, and vice versa.
    // Transformation according to transliteration rules.
    class EntryPoint
    {
        const string ERRORMESSAGE = "Error!";
        static void Main(string[] args)
        {
            try
            {
                FileReader fr = new FileReader();
                fr.Output();
                List<string> str = fr.TextFile;
                AlphabetTypeChanger atc = new AlphabetTypeChanger();
                Console.WriteLine(atc.CyrToLat(str[0]).ToLower());
                Console.WriteLine(atc.LatToCyr());
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

