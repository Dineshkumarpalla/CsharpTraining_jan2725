using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class MoveZeros
    {
        public void moveZeros()
        {
            int n;
            Console.WriteLine("Enter arrray size");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter arrray elements");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            int j = 0; int k = 0;
            while (j < arr.Length)
            {
                if (arr[j] == 0)
                {
                    j++;
                }
                else
                {
                    arr[k] = arr[j];
                    j++;
                    k++;
                }
            }

            while (k < arr.Length)
            {
                arr[k] = 0;
                k++;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            
        }
    }
}
