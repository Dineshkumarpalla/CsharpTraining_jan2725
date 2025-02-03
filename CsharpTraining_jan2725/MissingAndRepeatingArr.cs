using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public  class MissingAndRepeatingArr
    {
        public void findMisssingAndRepeating(int[] arr, int n) 
        {
            //Console.WriteLine("Enter array size");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];

            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int maxElement = arr[0];
            //int minElement = arr[0];

            // for finding max and min elements
            //foreach (int num in arr) // for(int i=0;i<arr.Length;i++)  if you want this you can use
            //{
            //    if (arr[num] > maxElement)
            //        maxElement = arr[num];
            //    if (arr[num] < minElement)
            //        minElement = arr[num];
            //}
            //Console.WriteLine($"maxElement:{maxElement}");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > maxElement)
            //        maxElement = arr[i];
            //    if (arr[i] < minElement)
            //        minElement = arr[i];
            //}



            int repeating = -1, missing = -1;
            int[] count = new int[n+1];

            foreach(int num in arr)
            {
                count[num]++;
            }

            for(int i=1;i<=arr.Length;i++)
            {
                if (count[i] == 2)
                    repeating = i;
                else if (count[i] == 0)
                    missing = i;
            }
            Console.WriteLine($"Repeating:{repeating}, missing:{missing}");
        }
    }

}


