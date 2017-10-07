using System;
using System.Text;

namespace Dev_10
{
    // Class works with an array of double values.
    class ArrayMaker
    {
        const int MINVALUE = 2;
        const int MAXVALUE = 10;
        const int MINAMOUNTOFELEMENTS = 1;
        const double EPS = 1e-3;
        const int NUMBAFTERCOMMA = 3;
        const string TEXTFORZEROREPEATINGS = "There are no repeatings in the N arrays.";
        public double[] RepeatingElementsArray { get; set; }
        public double[][] DoubleValuesArray { get; set; }
        public int AmountOfArrays { get; set; }
        public int AmountOfDoubleValues { get; set; }

        //Creates array with repeating elements.
        //Return true if there are repeating elements, else - false.
        public bool CheckIfElementsEquals()
        {
            bool isMaken = true;
            double[] repeatElementsArray = new double[MINVALUE];

            BuildNArraysOfRandomDoubleValues();
            OutputOriginalData(DoubleValuesArray);

            int length = 0;
            for (int n = 0; n < AmountOfArrays; n++)
            {
                for (int i = n + 1; i < AmountOfArrays; i++)
                {
                    for (int k = 0; k < AmountOfDoubleValues; k++)
                    {
                        // The amount of repeating elements.
                        int repeatedElementsNumber = 0;
                        for (int j = 0; j < AmountOfDoubleValues; j++)
                        {
                            if (Math.Abs(DoubleValuesArray[i][j] - DoubleValuesArray[n][k]) <= EPS)
                            {
                                repeatedElementsNumber++;
                                if ((repeatedElementsNumber == MINAMOUNTOFELEMENTS) &&
                                    !(Contains(repeatElementsArray, DoubleValuesArray[i][j])))
                                {
                                    repeatElementsArray[length] = DoubleValuesArray[i][j];
                                    length++;
                                    Array.Resize(ref repeatElementsArray, length + 1);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            RepeatingElementsArray = repeatElementsArray;
            if (length == 0)
            {
                Console.WriteLine(TEXTFORZEROREPEATINGS);

                isMaken = false;
            }
            return isMaken;
        }
        // Method creates N arrays of random double values.
        public void BuildNArraysOfRandomDoubleValues()
        {
            Random rand = new Random();
            AmountOfArrays = rand.Next(MINVALUE, MAXVALUE);
            DoubleValuesArray = new double[AmountOfArrays][];
            AmountOfDoubleValues = rand.Next(MINVALUE, MAXVALUE);
            for (int i = 0; i < AmountOfArrays; i++)
            {
                DoubleValuesArray[i] = new double[AmountOfDoubleValues];
            }
            for (int i = 0; i < AmountOfArrays; i++)
            {
                for (int j = 0; j < AmountOfDoubleValues; j++)
                {
                    DoubleValuesArray[i][j] = Math.Round(rand.NextDouble(), NUMBAFTERCOMMA);
                }
            }
        }
        // Outputs original array that is generated randomly.
        public void OutputOriginalData(double[][] ArrayOfDoubleValues)
        {
            StringBuilder sb = new StringBuilder(ArrayOfDoubleValues.Length);
            for (int i = 0; i < AmountOfArrays; i++)
            {
                for (int j = 0; j < AmountOfDoubleValues; j++)
                {
                    sb.Append(ArrayOfDoubleValues[i][j]);
                    sb.Append(" ");
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }
        // Outputs array with elements, that have entered at least two subarray in original array.
        public void Output()
        {
            for (int i = 0; i < RepeatingElementsArray.Length - 1; i++)
            {
                Console.Write(RepeatingElementsArray[i] + " ");
            }
        }
        // Method checks if the values already are included in an array.
        // Returns true if array contains the double value.
        public bool Contains(double[] repeatElementsArray, double value)
        {
            bool isRepeatedValue = false;
            for (int i = 0; i < repeatElementsArray.Length; i++)
            {
                if (repeatElementsArray[i] == value)
                {
                    return true;
                }
            }
            return isRepeatedValue;
        }
    }
}
