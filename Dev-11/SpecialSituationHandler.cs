using System;
using System.Collections.Generic;
using System.Linq;

namespace Dev_11
{
    // Handles special situation with transliteration.
    class SpecialSituationHandler
    {
        const string SPECIALLETTERS = "аеёиоуъыьэюя";
        const string LATSCPECIALLETTERS = "aue";
        public string InputLine { get; set; }
        // Case with Cyrillic "e". Returns  "ye" if "e" in the beggining of the line.
        // And after vowels and "ъ", "ь". Othervise returns Latin "e".
        public string RightCombinationForEToReturn(char symbol, string[] returnedSymbols, int i)
        {
            if ((LineBegins(symbol)))
            {
                return returnedSymbols[0];
            }
            if (IsAfterSpecialLetters(symbol, i))
                return returnedSymbols[0];
            else
            {
                return returnedSymbols[1].ToString();
            }
        }

        // Case when two symbols in Latin are one in Cyrillic. (Example: zh,kh, iy, ia)
        public string RightCombinationToReturn(char symbol, string[] returnedSymbols, char ch, int i)
        {
            if (IsBeforeSpecialLetter(symbol, ch, i))
            {
                return returnedSymbols[0];
            }
            else
            {
                return returnedSymbols[1];
            }
        }
        // Case for "c" and "ch". Returns "ч" if "ch", emptystring if "ch" is a part of "shch" 
        // and "ц" in usual case.
        public string RightCombinationForCToReturn(char symbol, string[] returnedSymbols, char ch, int i)
        {
            if (IsAfterLetter(symbol, ch.ToString(), i))
            {
                return returnedSymbols[0];
            }
            if (IsBeforeSpecialLetter(symbol, ch, i))
            {
                return returnedSymbols[1];
            }
            else
            {
                return returnedSymbols[2];
            }
        }
        // Case for second letters in combination("й" in "ий"). Returns empty string if symbol 
        //a part of combination.
        public string RightCombinationToReturn(char symbol, string[] returnedSymbols, string str, int i)
        {
            if (IsAfterLetter(symbol, str, i))
            {
                return returnedSymbols[0];
            }
            else
            {
                return returnedSymbols[1];
            }
        }
        // Case for latin "y".
        public string RightCombinationToReturn(char symbol, string[] returnedSymbols, char[] nextSymbs, int i)
        {
            for (int j = 0; j < nextSymbs.Length; j++)
            {
                if (IsBeforeSpecialLetter(symbol, nextSymbs[j], i))
                {
                    return returnedSymbols[j];
                }
            }
            if (!IsBeforeSpecialLetter(symbol, i))
                return returnedSymbols[3];
            else
                return "";
        }
        // Case with Latin "s". Returns "щ" if ater "s" - "hch", "ш" after "h", cyrillic "с" if
        // it is simple "s".
        public string RightCombinationToReturn(char symbol, string[] returnedSymbols, string[] nextSymbs, int i)
        {
            for (int j = 0; j < nextSymbs.Length; j++)
            {
                if (IsBeforeSpecialLetter(symbol, nextSymbs[j], i))
                {
                    return returnedSymbols[j];
                }
            }
            if (!IsBeforeSpecialLetter(symbol, i))
                return returnedSymbols[2];
            else
                return "";
        }
        // Return true if line starts with "symbol".
        public bool LineBegins(char symbol)
        {
            bool isBeginning = false;
            if (InputLine.StartsWith(symbol.ToString()))
            {
                isBeginning = true;
            }
            return isBeginning;
        }
        // Return true if line ends with "symbol".
        public bool LineEnds(char symbol)
        {
            bool isEnding = false;
            if (InputLine.EndsWith(symbol.ToString()))
            {
                isEnding = true;
            }
            return isEnding;
        }
        public bool IsAfterSpecialLetters(char symbol, int i)
        {

            bool isAfterSpecialLetters = false;
            if (!(LineBegins(symbol)) && SPECIALLETTERS.Contains(InputLine[i - 1].ToString()))
            {
                isAfterSpecialLetters = true;
            }
            return isAfterSpecialLetters;
        }
        public bool IsBeforeSpecialLetter(char symbol, int i)
        {
            bool isBeforeSpeciaLatlLetters = false;
            if (!(LineEnds(symbol)) && LATSCPECIALLETTERS.Contains(InputLine[i + 1].ToString()))
            {
                isBeforeSpeciaLatlLetters = true;
            }
            return isBeforeSpeciaLatlLetters;
        }
        public bool IsBeforeSpecialLetter(char symbol, char ch, int i)
        {
            bool isBeforeSpecialLetter = false;
            if (!(LineEnds(symbol)) && (InputLine[i + 1] == ch))
            {
                isBeforeSpecialLetter = true;
            }
            return isBeforeSpecialLetter;
        }
        public bool IsBeforeSpecialLetter(char symbol, string str, int i)
        {
            bool isBeforeSpecialLetter = false;
            if (!(LineEnds(symbol)) && InputLine.Contains(str))
            {
                isBeforeSpecialLetter = true;
            }
            return isBeforeSpecialLetter;
        }
        public bool IsAfterLetter(char symbol, string ch, int i)
        {
            bool isAfterYLetters = false;
            if (!(LineBegins(symbol)) && ch.Contains(InputLine[i - 1].ToString()))
            {
                isAfterYLetters = true;
            }
            return isAfterYLetters;
        }
    }
}
