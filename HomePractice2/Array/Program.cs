using System;
using System.Threading;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1

            int[,] array = new int[4, 2];
            array[2, 1] = 5;
            int x = array[2, 1];
       

            #endregion

            #region Example 2

            int[,,] array1 = new int[4, 2, 3];
            array1[1, 1, 1] = 9;


            #endregion

            #region example 3
            //two-dimentional array

            int[,] array2D = new int[,]
            {
                {1,2 },
                {3,4 },
                {5,6 },
                {7,8 }
            };

            //twoD wid string ellements.
            string[,] array2Ds = new string[3,2 ]
            {
                {"one","two" },
                {"three","four" },
                {"five","six" }

            };

            //threeD array.
            int[,,] array3D = new int[3,3,3]
            {
                {
                    {1,2,3 },{4,5,6},{7,8,9}
                },
                {
                    {10,11,12 },{13,14,15},{16,17,18}
                },
                {
                    {19,20,21 },{22,23,24},{25,26,27}
                },

            };

            #endregion 
        }
    }
}
