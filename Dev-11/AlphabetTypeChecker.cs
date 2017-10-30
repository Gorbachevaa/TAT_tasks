using System;

namespace Dev_11
{
    class AlphabetTypeChecker
    {
        const int MINVALUEOFLATIN_IN_ASCICODE = 97;
        const int MAXVALUEOFLATIN_IN_ASCICODE = 122;
        public string InputLine { get; set; }
        public AlphabetTypeChecker(string str)
        {
            InputLine = str;
        }
        public bool Check()
        {
            bool isLatinAlphabet = true;
            InputLine = InputLine.ToLower();
            foreach (char ch in InputLine)
            {
                isLatinAlphabet = false;
                if ((int)ch >= MINVALUEOFLATIN_IN_ASCICODE && (int)ch <= MAXVALUEOFLATIN_IN_ASCICODE)
                {
                    isLatinAlphabet = true;
                }
            }
            return isLatinAlphabet;
        }
    }
}

