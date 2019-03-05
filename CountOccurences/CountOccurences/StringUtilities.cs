using System.Linq;

namespace CountOccurences
{
    public class StringUtilities
    {
        public int CountOccurences(string stringToCheck, char charToFind)
        {
            if (stringToCheck == null)
            {
                return -1;
            }
            else
            {
                return stringToCheck.ToUpper().ToLower().Count(s => s == charToFind);
            }
        }
    }
}