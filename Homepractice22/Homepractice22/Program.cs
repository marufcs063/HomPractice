using System;
using System.Collections;
using System.Collections.Generic;

namespace Homepractice22
{
    class Program
    {
        static Stack A = new Stack();
        static Stack B = new Stack();
        static Stack C = new Stack();
        static void Main(string[] args)
        {
           
            //var rand = new Random();

            
            A.Push(3);
            B.Push(2);
            C.Push(1);
            PrintStacks();
            Move(3, A, C, B);
            
            Console.ReadLine();


        }
        public static void Move(int numberofDisk, Stack from, Stack to, Stack interchange)
        {
            if(numberofDisk>0)
            {
                Move(numberofDisk - 1, from, interchange, to);
                MoveDisk(from, to);
                Move(numberofDisk - 1, interchange, to, from);
                

            }
        }
        public static void MoveDisk(Stack from,Stack to)
        {
            var temp = from.Pop();
            to.Push(temp);
            PrintStacks();

        }

        public static void PrintStacks()
        {
            Console.Write("A: ");
            foreach( var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("B: ");
            foreach(var item in B)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("C: ");
            foreach(var item in C)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");


            
        }
    }
}
