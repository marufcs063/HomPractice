using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;

namespace HomePractice9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array again

            int[,] array = new int[3, 2]
            {
                { 1,2},
                { 3,4},
                { 5,6}             
            };
            //Console.WriteLine(array[0,1]);
            #endregion
           
            #region aagain 2
            string[,] array2d = new string[3, 2]
            {
                {"a","b" },
                { "c","d"},
                {"e","f" }
            };
           // Console.WriteLine(array2d[2,1]);



            #endregion

             #region 3d
            int[,,] array3Da = new int[2, 2, 3] 
            
            {
                { { 1, 2, 3 }, { 4, 5, 6 } },

                { { 7, 8, 9 }, { 10, 11, 12 } } 
            };

            int[,,] array3D = new int[2, 3, 2]
            {
                {{1,2 },{3,4 },{5,6 } },
                { { 7,8},{9,0 },{11,22 } }
            };
            #endregion

            #region user input mulidimentional array
            //var n = int.Parse(Console.ReadLine());
            //var m = int.Parse(Console.ReadLine());


            //Console.WriteLine("\n");
            //int[,] matrix1 = new int[n,m];
            //for (int i=0; i<n; i++)
            //{
            //    for(int j=0;j <m; j++)
            //    {
            //        matrix1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for(int i=0; i<n;i++)
            //{
            //    Console.WriteLine();
            //    for(int j=0; j<m;j++)
            //    {
            //        Console.Write(matrix1[i,j]);
            //    }
            //}
            //Console.WriteLine("\n");
            #endregion

            #region fan with user input 3D array

            var p = int.Parse(Console.ReadLine());
            var q = int.Parse(Console.ReadLine());
            var r = int.Parse(Console.ReadLine());


            Console.WriteLine("\n");
            int[,,] matrix2 = new int[p,q,r];
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    for (int k=0; k < r; k++)
                    {
                        matrix2[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < q; j++)
                {
                    Console.WriteLine();
                    for(int k=0; k < r; k++)
                    {
                        Console.Write(matrix2[i,j,k]);
                    }
                }
            }

            #endregion

            int[][,] jaggedArray4 = new int[3][,]
          {
                new int[2,2] { {1,3}, {5,7} },
                new int[3,2] { {0,2}, {4,6}, {8,10} },
                new int[3,3] { {11,22,33}, {99,88,10}, {1,0,9} }
          };
        }
    }
}
