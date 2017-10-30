using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_11
{
    // Converts Cyrillic letters to Latin letters and vise versa.
    class AlphabetTypeChanger
    {
        // These values for handling special combination.
        const string LETTERS_BEFORE_IY = "иы";
        const char LETTER_BEFORE_Y = 'й';
        const char LETTER_BEFORE__ = 'я';
        public string[] COMB_FOR_I_LETTER = { "y", "i" };
        public string[] COMB_FOR_Y_LETTER = { "iy", "y" };
        public string[] COMB_FOR__LETTER = { "ia", "'" };
        public string[] COMB_FOR_IY_LETTER = { "", "y" };
        public string[] COMB_FOR_YA_LETTER = { "", "ya" };
        public string[] COMB_FOR_E_LETTER = { "ye", "e" };

        const char LETTER_H = 'h';
        const string LETTER_Y = "y";
        public string[] COMB_FOR_C_LETTER = { "", "ч", "ц" };
        public string[] COMB_FOR_K_LETTER = { "х", "к" };
        public string[] COMB_FOR_A_LETTER = { "", "a" };
        public string[] COMB_FOR_U_LETTER = { "", "у" };
        public string[] COMB_FOR_EE_LETTER = { "", "е" };
        public string[] COMB_FOR_LAT_Y_LETTER = { "е", "ю", "я", "й" };
        public string[] COMB_FOR_SH_LETTER = { "щ", "ш", "с" };
        public string[] COMB_FOR_ZH_LETTER = { "ж", "з" };
        public char[] LETTERS_BEFORE_Y = { 'e', 'u', 'a' };
        public string[] LETTERS_BEFORE_SH = { "h", "c" };

        public string InputLine { get; set; }
        public string ChangedLine { get; set; }
        // Returns coverted letter from Cyrillic to Latin.
        public string CyrToLat(char ch, int i)
        {
            SpecialSituationHandler ssh = new SpecialSituationHandler();
            ssh.InputLine = InputLine;
            switch (ch)
            {
                case 'а':
                    {
                        return "a";
                    }
                case 'б':
                    {
                        return "b";
                    }
                case 'в':
                    {
                        return "v";
                    }
                case 'г':
                    {
                        return "g";
                    }
                case 'д':
                    {
                        return "d";
                    }
                case 'е':
                    {
                        return ssh.CheckPresenseOfSpecialSymbolForE('е', COMB_FOR_E_LETTER, i);
                    }
                case 'ё':
                    {
                        return ssh.CheckPresenseOfSpecialSymbolForE('ё', COMB_FOR_E_LETTER, i);
                    }
                case 'ж':
                    {
                        return "zh";
                    }
                case 'з':
                    {
                        return "z";
                    }
                case 'и':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('и', COMB_FOR_I_LETTER, LETTER_BEFORE_Y, i);
                    }
                case 'й':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('й', COMB_FOR_IY_LETTER, LETTERS_BEFORE_IY, i);
                    }
                case 'к':
                    {

                        return "k";
                    }
                case 'л':
                    {
                        return "l";
                    }
                case 'м':
                    {
                        return "m";
                    }
                case 'н':
                    {
                        return "n";
                    }
                case 'о':
                    {
                        return "o";
                    }
                case 'п':
                    {
                        return "p";
                    }
                case 'р':
                    {
                        return "r";
                    }
                case 'с':
                    {
                        return "s";
                    }
                case 'т':
                    {
                        return "t";
                    }
                case 'у':
                    {
                        return "u";
                    }
                case 'ф':
                    {
                        return "f";
                    }
                case 'х':
                    {
                        return "kh";
                    }
                case 'ц':
                    {
                        return "c";
                    }
                case 'ч':
                    {
                        return "ch";
                    }
                case 'ш':
                    {
                        return "sh";
                    }
                case 'щ':
                    {
                        return "shch";
                    }
                case 'ъ':
                    {
                        return " ";
                    }
                case 'ы':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('ы', COMB_FOR_Y_LETTER, LETTER_BEFORE_Y, i);
                    }
                case 'ь':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('ь', COMB_FOR__LETTER, LETTER_BEFORE__, i);
                    }
                case 'э':
                    {
                        return "e";
                    }
                case 'ю':
                    {
                        return "yu";
                    }
                case 'я':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('я', COMB_FOR_YA_LETTER, "ь", i);
                    }
                default: return ch.ToString();
            }
        }
        // Returns converted string from Cyrillic to Latin.
        public string CyrToLat(string str)
        {
            InputLine = str;
            StringBuilder sb = new StringBuilder(InputLine.Length * 2);
            int i = 0;
            foreach (char ch in InputLine.ToCharArray())
            {
                sb.Append(CyrToLat(ch, i));
                i++;
            }
            ChangedLine = sb.ToString();
            return ChangedLine;
        }
        // Returns coverted letter from Latin to Cyrillic.
        public string LatToCyr(char ch, int i)
        {
            SpecialSituationHandler ssh = new SpecialSituationHandler();
            ssh.InputLine = ChangedLine;
            switch (ch)
            {
                case 'a':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('a', COMB_FOR_A_LETTER, LETTER_Y, i);
                    }
                case 'b':
                    {
                        return "б";
                    }
                case 'c':
                    {
                        return ssh.CheckPresenceOfSpecialSymbolForC('c', COMB_FOR_C_LETTER, LETTER_H, i);
                    }
                case 'd':
                    {
                        return "д";
                    }
                case 'e':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('e', COMB_FOR_EE_LETTER, LETTER_Y, i);
                    }
                case 'f':
                    {
                        return "ф";
                    }
                case 'g':
                    {
                        return "г";
                    }
                case 'i':
                    {
                        return "и";
                    }
                case 'h':
                    {
                        return "";
                    }
                case 'k':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('k', COMB_FOR_K_LETTER, LETTER_H, i);
                    }
                case 'l':
                    {
                        return "л";
                    }
                case 'm':
                    {

                        return "м";
                    }
                case 'n':
                    {
                        return "н";
                    }
                case 'o':
                    {
                        return "о";
                    }
                case 'p':
                    {
                        return "п";
                    }
                case 'r':
                    {
                        return "р";
                    }
                case 's':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('s', COMB_FOR_SH_LETTER, LETTERS_BEFORE_SH, i);
                    }
                case 't':
                    {
                        return "т";
                    }
                case 'u':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('u', COMB_FOR_U_LETTER, LETTER_Y, i);
                    }
                case 'v':
                    {
                        return "в";
                    }
                case 'y':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('y', COMB_FOR_LAT_Y_LETTER, LETTERS_BEFORE_Y, i);
                    }
                case 'z':
                    {
                        return ssh.CheckPresenseOfSpecialSymbol('z', COMB_FOR_ZH_LETTER, LETTER_H, i); ;
                    }
                default: return ch.ToString();
            }
        }
        //Returns coverted letter from Latin to Cyrillic. 
        public string LatToCyr()
        {
            //Console.WriteLine(ChangedLine);
            StringBuilder sb = new StringBuilder(ChangedLine.Length * 2);
            int i = 0;
            foreach (char ch in ChangedLine.ToCharArray())
            {
                sb.Append(LatToCyr(ch, i));
                i++;
            }
            return sb.ToString();
        }
    }
}

