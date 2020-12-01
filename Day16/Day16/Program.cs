using System;
using System.Collections.Generic;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now;
            var name = "Abdullah";
            var person = (name, 22, married: false, 23, time);

            Console.WriteLine($"Name= {person.name}");
            Console.WriteLine($"Age = {person.Item2}");
            Console.WriteLine($"Married = {person.married}");
            Console.WriteLine($"Weight = {person.Item4}");
            Console.WriteLine($"Time = {person.time}");


            var lifeOfPerson = new List<(int age, string name, double weight)>();
            for(int i=0; i<10;i++)
            {
                lifeOfPerson.Add((i + 2, $"Mr.{i}", 1 * 5));
            }

            foreach(var item in lifeOfPerson)
            {
                Console.WriteLine($"Name: {item.name}, Age: {item.age}, Weight: {item.weight}      ");
            }
            var result = GetPersonResult();
            Console.WriteLine($"Name: {result.name}, Age: {result.age}, Subject: {result.result.Subject}, Grade: {result.result.Grade} ");
 
        }
        static (string name, int age,  Result result )GetPersonResult()
        {
            return ("Abdullah", 22, new Result { Subject = "C#", Grade = 3.8 });
        }
    }
}
