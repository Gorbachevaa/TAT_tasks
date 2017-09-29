using System;
using System.IO;
using System.Text;
namespace Dev_9
{
    // Class checks file and defines sequences.
    class FileChecker
    {
        public string[] SequencesFromFile { get; set; }
        // The amount of sequences in file.
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        // Method reads data from file, returns an array of original sequences.
        public string[] Read(string filename)
        {
            StreamReader fs = new StreamReader(filename);
            Amount = 2;
            SequencesFromFile = new string[Amount];
            int i = 0;
            while (true)
            {
                string temp = fs.ReadLine();
                if (temp == null)
                {
                    break;
                }
                SequencesFromFile[i] = temp;
                i++;
            }
            return SequencesFromFile;
        }
    }
}

