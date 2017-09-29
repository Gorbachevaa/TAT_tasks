using System;

namespace Dev_9
{
    // A programm that replace random subsequence in one line
    // by random subsequence from the other.
    // The console displays original strings and the modified. 
    class EntryPoint
    {
        const string TEXTFORFIRSTSTRING = "First original string: ";
        const string TEXTFORCHANGINGSTRING = "Second original string: ";
        const string TEXTFORCHANGEDSTRING = "Changed string: ";
        static void Main(string[] args)
        {
            try
            {
                SymbolsReplacer symbolReplacer = new SymbolsReplacer();
                symbolReplacer.Replace();
                Console.Write(TEXTFORFIRSTSTRING);
                symbolReplacer.Output(symbolReplacer.NotChangingSequence);
                Console.Write(TEXTFORCHANGINGSTRING);
                symbolReplacer.Output(symbolReplacer.ChangingSequence);
                Console.Write(TEXTFORCHANGEDSTRING);
                symbolReplacer.Output(symbolReplacer.ChangedSequence);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
