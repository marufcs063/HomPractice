using System;
using System.Transactions;

namespace HomePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers: " ); 
            var num1 = Convert.ToInt32(Console.ReadLine()); 
           
            var num2 = Convert.ToInt32(Console.ReadLine());


            // var num4 = 4;
            //var num5 = 5;
            // var num6 = 6;

            //var average = Average(num1, num2, num3);
            // var average2 = Average(num4, num5, num6);
            var Addition = addition(num1, num2);
            var Multiplication = multiplication(num1, num2);
            var Subtraction = subtraction(num1, num2);
            var Divition = divition(num1, num2);
            Console.WriteLine("Results are: " + "add is: " + Addition + " Sub is: " + Subtraction + " Mul is: " + Multiplication + " Div is:  " + Divition  );
        }
        //static int Average(int a, int b, int c)

        //{
        //    int result = (a + b + c) / 3;
        //    return result;
        //}

        static int addition(int x, int y)
        {
            int addResult = x + y;
            return addResult;
        }
        static int subtraction(int x, int y)
        {
            int subResult = x - y;
            return subResult;
        }
        static int multiplication(int x, int y)
        {
            int mulResult = x * y;
            return mulResult;
        }
        static int divition(int x, int y)
        {
            int divResult = x / y;
            return divResult;
        }
    }
}
