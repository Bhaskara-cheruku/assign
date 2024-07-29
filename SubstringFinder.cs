using System;

namespace FindSubstringPositions
{
    class SubstringPositions
    {
        /// <summary>
        /// This Method is used to find the positions of substring occurance
        /// </summary>
        /// <param name="S1">This variable contains the main string which we need to find the substring in it</param>
        /// <param name="S2"> This is the substring we need to find it's occurance</param>
        /// <returns>A List will be returned contains Positions of substring</returns>
        public static List<int> PositionsFinder(string S1, string S2)
        {
            //Position is declared to store the position values of substring occurance
            List<int> positions = new List<int>();
            for (int i = 0; i <= S1.Length - S2.Length; i++)
            {
                //inner loop to check weather the substring is existed in main method or not
                for (int j = 0; j < S2.Length; j++)
                {
                    if (S1[i + j] != S2[j])
                    {
                        break;
                    }
                    //Adding positions into List(positions)
                    if (j == S2.Length - 1)
                        positions.Add(i);
                }
            }

            return positions;
        }
    }
}