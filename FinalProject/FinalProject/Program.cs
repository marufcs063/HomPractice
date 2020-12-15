using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region randomization part
            string[] colors = { "R", "G", "B" };
            colors.Randomizer();
                                            
            Stack<string> tower1 = new Stack<string>();
            tower1.Push(colors[0]);
            tower1.Push(colors[1]);
            tower1.Push(colors[2]);

            Stack<string> tower2 = new Stack<string>();
            tower2.Push(colors[2]);
            tower2.Push(colors[1]);
            tower2.Push(colors[0]);
          
            Stack<string> tower3 = new Stack<string>();
            tower3.Push(colors[1]);
            tower3.Push(colors[0]);
            tower3.Push(colors[2]);
            Stack<string> comp1 = new Stack<string>();
            comp1.Push("R");
            comp1.Push("R");
            comp1.Push("R");
            Stack<string> comp2 = new Stack<string>();
            comp2.Push("G");
            comp2.Push("G");
            comp2.Push("G");
            Stack<string> comp3 = new Stack<string>();
            comp3.Push("B");
            comp3.Push("B");
            comp3.Push("B");
            Console.WriteLine("Given towers>>>: \n");
            Console.Write("1 top =>   ");
            foreach (string s in tower1)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");

            Console.WriteLine();
            Console.Write("2 top =>   ");
            foreach (string s in tower2)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");
            Console.WriteLine();
            Console.Write("3 top =>   ");
            foreach (string s in tower3)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");

            Console.WriteLine("\n\nYou Have to make like this!");
            Console.Write("1 top =>   ");
            foreach (string s in comp1)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");

            Console.WriteLine();
            Console.Write("2 top =>   ");
            foreach (string s in comp2)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");
            Console.WriteLine();
            Console.Write("3 top =>   ");
            foreach (string s in comp3)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");


            Console.WriteLine("\n\nPlease enter source and destination value as like '1  2': \n Note: please Match 1 then 2 then 3... ");
            #endregion
            


            #region from to
            var Try = 0;
            start:
            Console.WriteLine("\n");
            var input = Console.ReadLine().Split(' ');
            var from = int.Parse(input[0]);
            var to = int.Parse(input[1]);
            
            string[] hold =new string[1];
            if (from==1)
            {
                hold[0]= tower1.Peek();
                tower1.Pop();
                
            }
            else if(from==2)
            {
                hold[0] = tower2.Peek();
                tower2.Pop();
            }
            else if(from==3)
            {
                hold[0] = tower3.Peek();
                tower3.Pop();
            }
            else
            {
                Console.WriteLine("Pleae enter the source to destination value");
            }
            
            if (to == 1)
            {
                tower1.Push(hold[0]);
                
            }
            else if (to== 2)
            {
                tower2.Push(hold[0]);
            }
            else if (to == 3)
            {
                tower3.Push(hold[0]);
            }
                

            else
            {
                Console.WriteLine("Pleae enter the source to destination value");
            }



            Console.Write("1 top =>   ");
            foreach (string s in tower1)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");

            Console.WriteLine();
            Console.Write("2 top =>   ");
            foreach (string s in tower2)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");
            Console.WriteLine();
            Console.Write("3 top =>   ");
            foreach (string s in tower3)
            {
                Console.Write($"{s} ");
            }
            Console.Write("||");
            #endregion

            #region compare 

            Compare compare = new Compare();
            if (compare.isSame3(tower3, comp3))
            {
                if( compare.isSame2(tower2, comp2) )
                {
                    if ( compare.isSame1(tower1, comp1))
                    {
                        Console.WriteLine("\nCongratulations! You have matched all the towers!.\n");
                    }

                }

            }
            else
            {
                Try+= 1;
                Console.WriteLine($"\n\nYou have tried for {Try} times.\nPlease Try again!..." );
                goto start;
            }
            #endregion

            Console.WriteLine($"\n\nYour attempt number is: {Try} ");

        }
    }
}
