using System;
namespace Dev_9
{
    // Class that replaces one subsequence by another.
    class SymbolsReplacement
    {
        const string SEQUENCEROMFILE = @"D:\Git\TAT_tasks\Dev-9\InputData.txt";
        public char[] ChangedSequence { get; set; }
        public char[] NotChangingSequence { get; set; }
        public char[] ChangingSequence { get; set; }
        // Method replaces subsequences and defines modified sequence.
        public void Replacer()
        {
            FileChecker fileChecker = new FileChecker();
            string[] stringArray = fileChecker.Read(SEQUENCEROMFILE);
            NotChangingSequence = stringArray[0].ToCharArray();
            ChangingSequence = stringArray[1].ToCharArray();

            int randPosFirst;
            int lengthSubseqFirst;
            int randPosSecond;
            int lengthSubseqSecond;
            char[] firstSubsequence = SubsequenceDefiner(NotChangingSequence, out randPosFirst, out lengthSubseqFirst);
            char[] secondSubsequnce = SubsequenceDefiner(ChangingSequence, out randPosSecond, out lengthSubseqSecond);

            ChangedSequence = new char[ChangingSequence.Length - lengthSubseqSecond + lengthSubseqFirst];

            for (int i = 0; i < randPosSecond; i++)
            {
                ChangedSequence[i] = ChangingSequence[i];
            }
            int j = 0;
            for (int i = randPosSecond; i < randPosSecond + lengthSubseqFirst; i++)
            {
                ChangedSequence[i] = firstSubsequence[j];
                j++;
            }
            j = randPosSecond + lengthSubseqFirst;
            for (int i = randPosSecond + lengthSubseqSecond; i < ChangingSequence.Length; i++)
            {
                ChangedSequence[j] = ChangingSequence[i];
                j++;
            }
        }
        // Method that generates a ramdom position and a random length for a subsequence.
        // Returns an array of this numbers.
        public int[] RandNumbGenerater(char[] sequence)
        {
            Random rand = new Random();
            int randPosition = rand.Next(0, sequence.Length - 1);
            int lengthSubsequence = rand.Next(1, sequence.Length - randPosition - 1);
            return new[] { randPosition, lengthSubsequence };
        }
        // Method that defines a random subsequence for a sequence. 
        // Returns the subsequence.
        public char[] SubsequenceDefiner(char[] sequence, out int randPos, out int lengthSubseq)
        {
            int[] dataSequence = RandNumbGenerater(sequence);
            randPos = dataSequence[0];
            lengthSubseq = dataSequence[1];
            char[] subsequence = new char[lengthSubseq];
            for (int i = 0; i < lengthSubseq; i++)
            {
                subsequence[i] = sequence[i + randPos];
            }
            return subsequence;
        }
        // Method outputs a sequence.
        public void Outputer(char[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i]);
            }
            Console.WriteLine();
        }
    }
}
