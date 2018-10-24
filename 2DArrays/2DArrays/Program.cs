using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1d array
            int[] oneD = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //2d arrays
            //Not populated
            int[,] testarray = new int[2, 2];

            //Maually input data into a multi dimensional array [row,column]
            testarray[0, 0] = 0;
            testarray[0, 1] = 1;
            testarray[1, 0] = 2;
            testarray[1, 1] = 3;
            //Display this array
            Console.WriteLine("Test array:");
            Display(testarray);

            //Irregular array
            int[,] testarray2 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("\nTest array2:");
            Display(testarray2);

            //Populated
            int[,] twoD1 = new int[4, 4] { { 1, 2, 3, 4}, { 5, 6, 7, 8}, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int[,] twoD2 = new int[4, 4] { { 16, 15, 14, 13 }, { 12, 11, 10, 9 }, { 8, 7, 6, 5  } , { 4, 3, 2, 1} };

            //What the length property returns
            Console.WriteLine("\nWhat the length property returns: " + twoD1.Length);

            //Displaying a 2d array.
            Console.WriteLine("\nArray 1:");
            Display(twoD1);
            Console.WriteLine("\nArray 2:");
            Display(twoD2);

            //Adding two 2d arrays together
            Console.WriteLine("\nArrays added together:");
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write(twoD1[i, j] + twoD2[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        //
        public static void Display(int[,] arr)
        {
            //for loop using the GetLength method.
            for (int i = 0; i < arr.GetLength(0); i++)//Row
            {
                for (int j = 0; j < arr.GetLength(1); j++)//Column
                {
                    //gets the coordinates by using the counters from the external and internal loops.
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
