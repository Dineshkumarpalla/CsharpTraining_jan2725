using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class ArrayProg
    {
        // Single Dimension Array 
        //public void find()
        //{
        //    // Single Dimension Array 

        //    //int? a = null;
        //    //Console.WriteLine(a);

        //    // for user input for array size
        //    int n;
        //    Console.WriteLine("Enter Array Size :");
        //    n = Convert.ToInt32(Console.ReadLine());

        //    //how to decalre array by user itself
        //    int[] arr = new int[n];

        //    Console.WriteLine("Enter array elemnts");
        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }


        //    // Another Way of initializing array elements

        //    //int x = 0;
        //    //for (int i = 0; i < arr.Length; i++)
        //    //{
        //    //    bool f = int.TryParse(Console.ReadLine(),out x);
        //    //    if (f!)
        //    //    {
        //    //        arr[i] = x;
        //    //    }
        //    //    else
        //    //    {
        //    //        arr[i] = x;
        //    //    }
        //    //}

        //    //how to display array values
        //    Console.WriteLine("**********");
        //    Console.WriteLine("Displayint array elments");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

        // for MultiDimensional array 

        //public void Multidimenstional()
        //{
        //    // array Declaration  by user input
        //    int m, n;
        //    Console.WriteLine("Enter row size");
        //    m = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter column size");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    int[,] marr = new int[m, n];

        //    // initializing array values

        //    Console.WriteLine("Enter array elements");

        //    //marr[0, 0] = 1;
        //    //marr[0, 1] = 2;
        //    //marr[0,2] = 3;

        //    //marr[1, 0] = 4;
        //    //marr[1, 1] = 5;
        //    //marr[1, 2] = 6;

        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            marr[i, j] = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }

        //    // Displaying array elements

        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            Console.Write(marr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        // Jagged Array

        //public void JoggedArray()
        //    {
        //        // Array Declaration
        //        int[][] joggedarr = new int[3][];

        //        //customization and intialization

        //        joggedarr[0] = new int[2] {5,9 };
        //        joggedarr[1] = new int[5] { 12,43,78,8,5};
        //        joggedarr[2] = new int[4] { 26,99,11,2};

        //        //initialization of array

        //        //joggedarr[0][0] = 1;
        //        //joggedarr[0][1] = 2;


        //        //joggedarr[1][0] = 3;
        //        //joggedarr[1][1] = 4;
        //        //joggedarr[1][2] = 5;
        //        //joggedarr[1][3] = 6;
        //        //joggedarr[1][4] = 7;

        //        //joggedarr[2][0] = 8;
        //        //joggedarr[2][1] = 9;
        //        //joggedarr[2][2] = 10;
        //        //joggedarr[2][3] = 11;

        //        // For Displaying array elements

        //        for(int i = 0; i < joggedarr.Length; i ++)
        //        {
        //            for(int j = 0; j < joggedarr[i].Length; j++)
        //            {
        //                Console.Write(joggedarr[i][j]+" ");
        //            }
        //            Console.WriteLine();
        //        }
        //    }

        //JoggedStringArray
        //public void joggedString()
        //{
        //    // Declaration and Initialization

        //    String[][] Members = new string[4][] {
        //    new String[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" },
        //    new String[] { "January", "February", "March" },
        //    new String[] { "Dinesh", "Narasimha" },
        //    new String[] { "Btm", "Marathahalli", "hsr", "yeswanthpur", "bengaluru" }};

        //    // Displaying of Elemets


        //    for(int i = 0; i < Members.Length; i++)
        //    {
        //        Console.Write("Name List ({0}): " + i + 1);
        //        for (int j = 0; j < Members[i].Length; j++)
        //        {
        //            Console.WriteLine(Members[i][j]+" ");
        //        }
        //        Console.WriteLine();
        //    }
        //}



     //jogged MultidimenstionalArray
        public void joggedMultidimenstionalArray()
        {

            // Declaration and Initialization 

            int[][,] joggedMultidimArr = new int[3][,]{
            new int[,]{{11,23},{ 33,22} },
            new int[,]{{34,52 },{1,3},{53,67} },
            new int[,]{{14,16} } };

            // Displaying array elements

            for (int i = 0; i < joggedMultidimArr.Length; i++)
            {
                int[,] innerArray = joggedMultidimArr[i];

                for (int row = 0; row < innerArray.GetLength(0); row++)
                {
                    for (int col = 0; col < innerArray.GetLength(1); col++)
                    {
                        Console.Write(innerArray[row, col] + " ");
                    }
                    Console.WriteLine(); //new line after each row
                }
                Console.WriteLine(); // seperate arrays
            }
        }



    }
}
