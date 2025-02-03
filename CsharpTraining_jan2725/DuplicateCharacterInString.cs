using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public  class DuplicateCharacterInString
    {
        public void findDuplicate(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            HashSet<char> duplicates = new HashSet<char>();

            //count occurances of each character



            foreach(char ch in input)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                    duplicates.Add(ch);  //add to duplicates set when count > 1
                }
                else
                {
                    charCount[ch] = 1;
                }
            }

            //duplicate characters
            foreach (char ch in duplicates)
            {
                Console.Write(ch);
            }
            Console.WriteLine();   
        }
    }
}
