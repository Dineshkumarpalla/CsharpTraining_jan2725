using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class SecondLargestElementArray
    {
        public int findSecondLargest(int[] arr)
        {
            // user defined type

            //Console.WriteLine("Enter array size");
            //int size = Convert.ToInt32(Console.ReadLine());

            //if(size <2)
            //{
            //    Console.WriteLine("Array size must be atleast 2.");
            //    return -1;
            //}

            //int[] arr = new int[size];

            //Console.WriteLine("Enter array elements");
            //for(int i=0;i<arr.Length;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach(int num in arr)
            {
                if (num > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = num;
                }
                else if (num > secondLargest && num < firstLargest)
                {
                    secondLargest = num;
                }
            }
            if (secondLargest == int.MinValue)
            {
               // Console.WriteLine("There is no secondLargst element.");
                return -1;
            }

            return secondLargest;
        }
    }
}
