using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dev_11
{
    // Class gets original data from file.
    class FileReader
    {
        const string FILENAME = @"D:\Git\TAT_tasks\Dev-11\InputData.txt";
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
            StringBuilder sb = new StringBuilder(TextFile.Count);
            for (int i = 0; i < TextFile.Count; i++)
            {
                sb.Append(TextFile[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

