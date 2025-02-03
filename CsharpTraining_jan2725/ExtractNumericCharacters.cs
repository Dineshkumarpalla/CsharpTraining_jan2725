using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class ExtractNumericCharacters
    {
        public void extractNumberFromString(string[] arr)
        {
            // concatenate all elements into a single String
            string concatenated = string.Join("", arr);

            //Extract numeric characters from the concatenated string
            string numericChars = new string(concatenated.Where(char.IsDigit).ToArray());

            // find max and min numbers formed from numeric characters
            if(numericChars.Length==0)
            {
                Console.WriteLine("No numeric characters found.");
                return;
            }

            char[] digits = numericChars.ToCharArray();
            Array.Sort(digits);
            int minNumber = Convert.ToInt32(new string(digits));

            Array.Reverse(digits);
            int maxNumber = Convert.ToInt32(new string(digits));

            int difference = maxNumber - minNumber;

            Console.WriteLine($"Concatenated String: {concatenated}");
            Console.WriteLine($"Extracted Numbers: {numericChars}");
            Console.WriteLine($"Minimum Number: {minNumber}");
            Console.WriteLine($"Maximum Number: {maxNumber}");
            Console.WriteLine($"Difference: {difference}");
        }
    }
}
