using System;
using System.Collections.Generic;

namespace HomePractceDay14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<string> dinosaurs = new List<string>();
            Console.WriteLine("\nCapacity: {0}",dinosaurs.Capacity);
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
           
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine($"Capacity: {dinosaurs.Capacity} ");
            Console.WriteLine($"Count: {dinosaurs.Count}");
            Console.WriteLine($"Contain (\"Deinonychus\") {dinosaurs.Contains("Deinonychus")}");
            
            dinosaurs.Insert(3, "BD Dinosaurs");
            dinosaurs.Insert(4, "Afg Dinosaurs");
            dinosaurs.Insert(5, "Pak Dinosaurs");
            Console.WriteLine();

            foreach(string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            
            Console.WriteLine("\ndinosaurs[3]: {0}",dinosaurs[3]);
            Console.WriteLine("\nRemove (\"Compsognathus\")");

            dinosaurs.Remove("Compsognathus");
            Console.WriteLine();

            foreach(string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            dinosaurs.TrimExcess();
            Console.WriteLine("\nTrimExcess()");

            Console.WriteLine("\n Capacity: {0}",dinosaurs.Capacity);
            Console.WriteLine("\nCount: {0}",dinosaurs.Count);

            dinosaurs.Sort();
            Console.WriteLine(dinosaurs.BinarySearch("Deinonychus"));
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nBinarySearch and Insert \"Coelophysis\":");
            int index = dinosaurs.BinarySearch("Coelophysis");
            if (index < 0)
            {
                dinosaurs.Insert(~index, "Coelophysis");
            }

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine();
           

            Console.WriteLine("\nAddRange(dinosaurs)");
            dinosaurs.AddRange(dinosaurs);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            
            Console.WriteLine("\nRemoveRange(2, 2)");
            dinosaurs.RemoveRange(0, 8);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.Reverse();

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.Reverse(1, 4);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }


            dinosaurs.Clear();
            Console.WriteLine("\nClear");
            Console.WriteLine("Capacity: {0}",dinosaurs.Capacity);
            Console.WriteLine("Count: {0}",dinosaurs.Count);

            #endregion

            #region sortedlist generics


            #endregion






        }
    }
}
