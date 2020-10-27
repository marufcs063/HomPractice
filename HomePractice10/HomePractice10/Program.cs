using System;

namespace HomePractice10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region function overloading constructor overloading
            //Person ab = new Person();
            //ab.Name = "Abul Basar";
            //ab.weight = 60; 
            //ab.height = 5.3;
            //ab.walk();


            //Person abm = new Person("Maksuda Basar");
            //abm.height = 4.11;
            //abm.weight = 65;
            //abm.walk(55,60);
            #endregion

            var aBook = new Books();
            aBook.Name = "Al Qur'an";
            aBook.Description = "The words of Allah";
            aBook.Price = 700.00;
            aBook.Author = "Allah";
            aBook.feature = "Can change ones heart.";

            var anElectronics = new Electronics();
            anElectronics.Name = "Camera";
            anElectronics.Description = "Smart Digital SLR";
            anElectronics.Price = 50000.00;
            anElectronics.BrandName = "Cannon";
            anElectronics.feature = "Mirorless camerah..";

            var smartPhone = new SmartPhones();
            smartPhone.Name = "Smart Phone";
            smartPhone.Description = "A 2019 best phone";
            smartPhone.Price = 40000.00;
            smartPhone.feature = "90 hz display. good camerah..";
            smartPhone.BrandName = "One plus";
            smartPhone.ModelNumber = "7 pro";

            var products = new Product[10];
            products[0] = aBook;
            products[1] = anElectronics;
            products[2] = smartPhone;

            print(aBook);
            Console.WriteLine("\n");
            print(anElectronics);
            Console.WriteLine("\n");
            print(smartPhone);
         }

        static void print(Product product)
        {
            Console.WriteLine($"Name = {product.Name}");
            Console.WriteLine($"Descriptions = {product.Description}");
            Console.WriteLine($"Feature = {product.feature}");
            Console.WriteLine($"Price = {product.PriceFormate()}");
            Console.WriteLine($"Discount = {product.CalculateDiscunt()}");

            if (product is Books)
            {
                var book = product as Books;
                Console.WriteLine($"Author = {book.Author}");

            }
            else if (product is SmartPhones)
            {
                var smart = product as SmartPhones;
                Console.WriteLine($"Brand name is = {smart.BrandName }");
                Console.WriteLine($"Model number  is = {smart.ModelNumber} ");
            }
            else if( product is Electronics)
            {
                var electro = product as Electronics;
                Console.WriteLine($"Brand name is = {electro.BrandName}");

            }
          
        }
    }
}
