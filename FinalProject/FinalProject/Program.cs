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

            foreach (string s in tower1)
            {
                Console.Write($"{s} ");                       
            }
            Console.WriteLine();
            foreach (string s in tower2)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
            foreach (string s in tower3)
            {
                Console.Write($"{s} ");
            }
            #endregion

            #region from to
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
            string[] keep = new string[1];
            if (to == 1)
            {
                keep[0] = tower1.Push(hold[0]);
                
            }
            else if (to== 2)
            {
                keep[0] = tower2.Push(hold[0]);
            }
            else if (to == 3)
            {
                keep[0] = tower3.Push(hold[0]);
            }
                

            else
            {
                Console.WriteLine("Pleae enter the source to destination value");
            }

            #endregion
        }
    }
}
