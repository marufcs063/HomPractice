using System;
using System.Security.Cryptography;

namespace HomePractice6
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Students[10];
            
            var s1 = new Academic();
            s1.name = "Ab Maruf";
            s1.Id = "CSE 06307404";
            s1.Payment = 350000;
            s1.Result = 3.79;
            s1.codingMarks = 3.00;

            var s2 = new Accounts();
            s2.name = "Radon Stark";
            s2.Id = "CSE 06307397";
            s2.Payment = 370000;
            s2.Result = 3.50;
            s2.due = 50000;

            var s3 = new Accounts();
            s3.name = "Nazim uddin";
            s3.Id = "CSE 06307429";
            s3.Payment = 380000;
            s3.Result = 4.00;
            s3.due = 5000;


            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            view(s1);
            Console.WriteLine("\n ");
            view(s2);
            Console.WriteLine("\n");
            view(s3);
        }

        static void view(Students students)
        {
            Console.WriteLine($"Name : {students.name}");
            Console.WriteLine($"ID : {students.Id}");
            Console.WriteLine($"Payment: {students.payable()}");
            Console.WriteLine($"Result: {students.Hidden()}");

            if(students is Academic)
            {
                var marks = students as Academic;
                Console.WriteLine($"Marks of coding is: {marks.codingMarks} ");
            }

            else if(students is Accounts)
            {
                var Ditehobe = students as Accounts;
                Console.WriteLine($"Your due is: {Ditehobe.due} ");
            }
        }
    }
}
