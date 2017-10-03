using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace Dev_9 
{
    // Class checks file and defines sequences.
    class FileReader
    {
        public List<string> SequencesFromFile { get; set; }
        // The amount of sequences in file.
        public int Amount { get; set; }
        // Method reads data from file, returns an array of original sequences.
        public List<string> Read(string filename)
        {
            using (StreamReader fs = new StreamReader(filename))
            {
                SequencesFromFile = new List<string>();
                int i = 0;
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null)
                    {
                        break;
                    }
                    SequencesFromFile.Add(temp);
                    i++;
                }
            }
            return SequencesFromFile;
        }
    }
}

