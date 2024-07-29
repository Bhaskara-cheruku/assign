using System;

namespace FindSubstringPositions
{
    class Program
    {
        /// <summary>
        /// Entry point for project
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //inputs taking from USer directly
            Console.WriteLine("Enter the first string (S1):");
            string S1 = Console.ReadLine();

            Console.WriteLine("Enter the second string (S2):");
            string S2 = Console.ReadLine();
            validation valid = new validation();
            bool Isvalid = valid.Isvalid(S1,S2);
            if (Isvalid)
            {
                //calling SubstringPosition to find positions where sunstrign occurs
                SubstringPositions SubstringPositions = new SubstringPositions();
                //List to store positions
                List<int> Positions = SubstringPositions.PositionsFinder(S1, S2);

                Console.WriteLine("No. of times occurred = " + Positions.Count);
                Console.Write("Index positions = ");

                foreach (int position in Positions)
                {
                    Console.Write(position + " ");
                }
            }
            else
            {
                Console.WriteLine("Please enter the correct string(should contain only characters)");
            }
        }

    }
}
