using System;

namespace HomePractice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region jagged array practice again 1

            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1,2,3,4,5,77};
            jaggedArray[1] = new int[4] { 5,6,3,4};
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[2] { 1,2};

            //Console.WriteLine(jaggedArray[0][5]);


            #endregion

            #region 2

            int[][] jaggedArray2 = new int[][]
            {
                new int[]{1,2,3,4,5,6,7},
                new int[]{0,8,9,00},
                new int[]{11,22}
            };
            jaggedArray2[0][0] = 10;
            //Console.WriteLine(jaggedArray2[2][1]);

            #endregion

            #region 3
            int[][,] jaggedArray3 = new int[3][,]
            {
                new int[,]{ { 1,2},{3,4 } },
                new int[,]{ { 0,2},{4,6},{ 10,20} },
                new int[,]{ { 111,22},{99,88 },{ 0,9} }
            };
           // Console.WriteLine(jaggedArray3[2][1,1]);
            #endregion
        }
    }
}
