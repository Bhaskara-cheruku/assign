namespace FindSubstringPositions
{
    class validation
    {
        public bool Isvalid(string mainString, string subString)
        {
            int Count = 0;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] < 65 || (mainString[i] > 90 && mainString[i] < 97) || mainString[i] > 122)
                {
                    Count++;
                }
                else if (subString[i] < 65 || (subString[i] > 90 && subString[i] < 97) || subString[i] > 122)
                {
                    Count++;
                }
            }
            if(Count==0){ return true; }
            else
            {
                return false;
            }
            
        }
    }
}