using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class EvenOdd
    {
        public void evenOdd()
        {
            // for user input
            // Declaration
            int n;
            Console.WriteLine("Input the number of elements to be stored in the array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Input "+n+" elements in the array");

            // Initialization of array
            Console.WriteLine("Enter array Elements");

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("element-"+i+":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Declaration of jogged array
            int[][] joggedarr = new int[2][];

            int oddCount = 0;
            int evenCount = 0;

            
            //find even and odd numbers count

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            joggedarr[0] = new int[evenCount];
            joggedarr[1] = new int[oddCount];

            int evenindex = 0;
            int oddIndex = 0;
             
            for(int i=0;i<n;i++)
            {
                if (arr[i]%2==0 && evenindex < evenCount)
                {
                    joggedarr[0][evenindex++] = arr[i];
                }
                else if (arr[i]%2!=0 && oddIndex < oddCount)
                {
                    joggedarr[1][oddIndex++] = arr[i];
                }
            }

            //Array.Sort(joggedarr[0]);
            //Array.Sort(joggedarr[1]);

            Console.WriteLine("The even elements are:");
            foreach(int i in joggedarr[0])
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("The odd elements are:");
            foreach (int i in joggedarr[1])
            {
                Console.Write(i+" ");
            }

        }
    }
}
