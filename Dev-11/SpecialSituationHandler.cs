using System;
using System.Collections.Generic;
using System.Linq;

namespace Dev_11
{
    // Class handles special situation with transliteration when one symbol converts to 2 symbols(or more). 
    class SpecialSituationHandler
    {
        const string SPECIALLETTERS = "аеёиоуъыьэюя";
        const string LATSCPECIALLETTERS = "aue";
        public string InputLine { get; set; }

        // Method handles case with Cyrillic "e". Returns  "ye" if "e" in the beggining of the line.
        // And after vowels and "ъ", "ь". Othervise returns Latin "e".
        // The method takes "symbol", returnSymbols and index of "symbol" - i.
        public string CheckPresenseOfSpecialSymbolForE(char checkSymbol, string[] returnSymbols, int i)
        {
            if ((LineBegins(checkSymbol)))
            {
                return returnSymbols[0];
            }
            if (IsAfterSpecialLetters(checkSymbol, i))
            {
                return returnSymbols[0];
            }
            else
            {
                return returnSymbols[1].ToString();
            }
        }
        // Method checks for the presense of the special symbol after "symbol". 
        // If it has - this symbols form combination that transliterates in special way.
        // (Example:  "zh" - "ж" , "kh" - "х", "ий" - "iy", "ья" - "ia")
        // ReturnSymbols contain value for special combination and for just symbol.
        // Char ch - special symbol.
        public string CheckPresenseOfSpecialSymbol(char checkSymbol, string[] returnSymbols, char nextSymb, int i)
        {
            if (IsBeforeSpecialLetter(checkSymbol, nextSymb, i))
            {
                return returnSymbols[0];
            }
            else
            {
                return returnSymbols[1];
            }
        }
        // Case for "c" and "ch". Returns "ч" if "ch", emptystring if "ch" is a part of "shch" 
        // and "ц" in usual case.
        public string CheckPresenceOfSpecialSymbolForC(char checkSymbol, string[] returnSymbols, char nextSymb, int i)
        {
            if (IsAfterLetter(checkSymbol, nextSymb.ToString(), i) && (IsBeforeSpecialLetter(checkSymbol, nextSymb, i)))
            {
                return returnSymbols[0];
            }
            if (IsBeforeSpecialLetter(checkSymbol, nextSymb, i))
            {
                return returnSymbols[1];
            }
            else
            {
                return returnSymbols[2];
            }
        }
        // Method that checks for the presense of the special symbol before "symbol".
        // Returns empty string if special symbol exists, otherwise - transliterates according to the rules.
        public string CheckPresenseOfSpecialSymbol(char checkSymb, string[] returnSymbs, string nextS, int i)
        {
            if (IsAfterLetter(checkSymb, nextS, i))
            {
                return returnSymbs[0];
            }
            else
            {
                return returnSymbs[1];
            }
        }
        // Method handles case with Latin "y". ("ye" - "е", "yu" - "ю", "ya" - "я").
        // The diffrence is that after "symbol" can be more than one special symbol.
        // Method takes an array of special symbols - nextSymbs.
        public string CheckPresenseOfSpecialSymbol(char checkSymb, string[] returnSymbs, char[] nextSymbs, int i)
        {
            int j;
            for (j = 0; j < nextSymbs.Length; j++)
            {
                if (IsBeforeSpecialLetter(checkSymb, nextSymbs[j], i))
                {
                    return returnSymbs[j];
                }
            }
            if (!IsBeforeSpecialLetter(checkSymb, i))
            {
                return returnSymbs[j++];
            }
            else
            {
                return "";
            }
        }
        // Method handles case with Latin "s".
        // Returns "щ" if symbol "s" is after  - "hch", "ш" - if after "h", 
        //cyrillic "с" if "s" doesn't form special combination with next symbols.
        public string CheckPresenseOfSpecialSymbol(char checkSymb, string[] returnSymbs, string[] nextSymbs, int i)
        {
            if (IsBeforeSpecialLetter(checkSymb, nextSymbs[0], i))
            {
                if (IsBeforeSpecialLetter('h', nextSymbs[1], i + 1))
                {
                    //if ()
                    return returnSymbs[0];
                }
                   
                else
                {
                    return returnSymbs[1];
                }
            }
            if (!IsBeforeSpecialLetter(checkSymb, 'h', i))
            {
                return returnSymbs[2];
            }
            else
            {
                return "";
            }
        }
        // Method defines if the line is started with the "symbol".
        // In this case returns true, otherwise - false.
        public bool LineBegins(char checkSymbol)
        {
            bool isBeginning = false;
            if (InputLine.StartsWith(checkSymbol.ToString()))
            {
                isBeginning = true;
            }
            return isBeginning;
        }
        // Method defines if the line is finished with the "symbol".
        // In this case returns true, otherwise - false.
        public bool LineEnds(char checkSymbol)
        {
            bool isEnding = false;
            if (InputLine.EndsWith(checkSymbol.ToString()))
            {
                isEnding = true;
            }
            return isEnding;
        }
        // Method checks if "symbol" is situated after special letters(like vowels and etc.)
        // Returns true if it does, otherwise - false. 
        public bool IsAfterSpecialLetters(char checkSymbol, int i)
        {
            bool isAfterSpecialLetters = false;
            if (!(LineBegins(checkSymbol)) && SPECIALLETTERS.Contains(InputLine[i - 1].ToString()))
            {
                isAfterSpecialLetters = true;
            }
            return isAfterSpecialLetters;
        }
        // Method checks if "checkSymbol" is situated before special Letters.
        //If it does returns true, otherwise - false.
        public bool IsBeforeSpecialLetter(char checkSymbol, int i)
        {
            bool isBeforeSpeciaLatlLetters = false;
            if (!(LineEnds(checkSymbol)) && LATSCPECIALLETTERS.Contains(InputLine[i + 1].ToString()))
            {
                isBeforeSpeciaLatlLetters = true;
            }
            return isBeforeSpeciaLatlLetters;
        }
        // Method checks if "checkSymbol" is situated before special Letter.
        //If it does returns true, otherwise - false.
        public bool IsBeforeSpecialLetter(char checkSymbol, char ch, int i)
        {
            bool isBeforeSpecialLetter = false;
            if (!(LineEnds(checkSymbol)) && (InputLine[i + 1] == ch))
            {
                isBeforeSpecialLetter = true;
            }
            return isBeforeSpecialLetter;
        }
        // Method checks if "checkSymbol" is situated before special Letters.
        // If it does returns true, otherwise - false.
        public bool IsBeforeSpecialLetter(char checkSymbol, string specLetters, int i)
        {
            bool isBeforeSpecialLetter = false;
            if (( i != InputLine.Length) && (specLetters.Contains(InputLine[i + 1])))
            {
                isBeforeSpecialLetter = true;
            }
            return isBeforeSpecialLetter;
        }
        // Method checks if "checkSymbol" is situated after special Letters.
        // If it does returns true, otherwise - false.
        public bool IsAfterLetter(char checkSymbol, string specLetter, int i)
        {
            bool isAfterYLetters = false;
            if (!(LineBegins(checkSymbol)) && specLetter.Contains(InputLine[i - 1].ToString()))
            {
                isAfterYLetters = true;
            }
            return isAfterYLetters;
        }
    }
}
