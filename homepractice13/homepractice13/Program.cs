using System;

namespace homepractice13
{
    class Program
    {
        static void Main(string[] args)
        {

            var box1 = new Box<int>();
            var box2 = new Box<double>();
            box1.Width = 22;
            box2.Width = 33.4;

            var storage = new Storage<string>(5);
            storage.PutItem(1, "Alhamdulillah");
            storage.PutItem(2, "Allahuakbar");

            var storage2 = new Storage<int>(9);

            storage2.PutItem(1, 1);
            storage2.PutItem(2, 42);
            storage2.PutItem(3, 55);
            storage2.PutItem(4, 13);
            storage2.PutItem(5, 25);
            storage2.PutItem(6, 24);

            var storage3 = new Storage<bool>(3);
            storage3.PutItem(1, true);
            storage3.PutItem(2, false);

            Console.WriteLine(storage2.GetItem(5));




        }
    }
}
