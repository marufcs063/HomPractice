using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example 1

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            //OR
            jaggedArray[0] = new int[] { 1,2,3,4,5};
            jaggedArray[1] = new int[] {6,7,8,9 };
            jaggedArray[2] = new int[] { 0,11};



            #endregion
        }
    }
}
