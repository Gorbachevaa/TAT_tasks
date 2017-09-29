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
            SymbolsReplacement symbolReplacement = new SymbolsReplacement();
            symbolReplacement.Replacer();
            Console.Write(TEXTFORFIRSTSTRING);
            symbolReplacement.Outputer(symbolReplacement.NotChangingSequence);
            Console.Write(TEXTFORCHANGINGSTRING);
            symbolReplacement.Outputer(symbolReplacement.ChangingSequence);
            Console.Write(TEXTFORCHANGEDSTRING);
            symbolReplacement.Outputer(symbolReplacement.ChangedSequence);
            Console.ReadKey();
        }
    }
}
