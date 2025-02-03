using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class UniqueCharInStr
    {
        public void GetUniqueCharacters(string input)
        {
            HashSet<char> seen = new HashSet<char>(); // to trach already seen characters
            List<char> uniqueChars = new List<char>(); // to store unique charecters
            foreach(char ch in input)
            {
                // iterate through each character in the  string
                if (!seen.Contains(ch))
                {
                    seen.Add(ch);
                    uniqueChars.Add(ch);
                }
            }

            foreach(char ch in uniqueChars)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
