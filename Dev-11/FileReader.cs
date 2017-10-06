using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dev_11
{
    // Get original data from file.
    class FileReader
    {
        const string FILENAME = @"D:\Microsoft.Visual.Studio.Ultimate.2013-KOPiE[rarbg]\Projects\ConsoleApplication5\Dev-11_1\InputData.txt";
        public List<string> TextFile { get; set; }
        // Read data from file.
        public List<string> Read(string filename)
        {
            TextFile = new List<string>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string temp;
                while ((temp = sr.ReadLine()) != null)
                {
                    TextFile.Add(temp.ToLower());
                }
            }
            return TextFile;
        }
        // Displays data.
        public void Output()
        {
            TextFile = Read(FILENAME);
            for (int i = 0; i < TextFile.Count; i++)
            {
                Console.WriteLine(TextFile[i]);
            }
        }
    }
}

