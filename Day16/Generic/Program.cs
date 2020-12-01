using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Peek at next item to dequeue: {0}",
           numbers.Peek());
           Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
