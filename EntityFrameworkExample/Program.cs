using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EntityFrameworkExample
{
    class Program
    {
        private static Random random;

        static void Main(string[] args)
        {
            //random = new Random((int)DateTime.Now.Ticks);

            //for(var i = 0; i< 3; i++)
            //    Add();

            //Update(1);
            //Delete(1);

            //var result = GetAll();
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Id} - {item.Name} - {item.Address} - {item.Age}");
            //}

            //AddProduct("Electronics", "Camera", 20000);
            var camera = GetProduct("Camera");

            Console.WriteLine($"{camera.Price} - {camera.Categories[0].Category.Name}");
        }

        static void Add()
        {
            using var context = new PersonContext();

            context.Persons.Add(new Person
            {
                Name = "jalaluddin " + random.Next(3000, 900000),
                Address = "Dhaka",
                Age = 39
            });

            context.SaveChanges();

            Console.WriteLine("Added successfuly");
        }

        static void Update(int id)
        {
            using var context = new PersonContext();

            var person = context.Persons.Where(x => x.Id == id).FirstOrDefault();

            person.Name = "Tareq Ahmed";
            person.Age = 23;
            person.Address = "Sylhet";

            context.SaveChanges();

            Console.WriteLine("Updated successfuly");
        }

        static void Delete(int id)
        {
            using var context = new PersonContext();

            var person = context.Persons.Where(x => x.Id == id).FirstOrDefault();

            context.Persons.Remove(person);

            context.SaveChanges();

            Console.WriteLine("Deleted successfuly");
        }

        static Person GetById(int id)
        {
            using var context = new PersonContext();

            return context.Persons.Where(x => x.Id == id).FirstOrDefault();
        }

        static IList<Person> GetAll()
        {
            using var context = new PersonContext();

            return context.Persons.ToList();
        }

        static void AddCategory()
        {
            using var shoppingContext = new ShoppingContext();
            shoppingContext.Category.Add(new Category
            {
                 Name = "Electronics"
            });

            shoppingContext.Category.Add(new Category
            {
                Name = "Equipments"
            });

            shoppingContext.SaveChanges();
        }

        static void AddProduct(string categoryName, string productName, double price)
        {
            using var shoppingContext = new ShoppingContext();

            var category = shoppingContext.Category.Where(x => x.Name == categoryName).FirstOrDefault();

            var product = new Product
            {
                Name = productName,
                Price = price,
                Categories = new List<ProductCategory>() { new ProductCategory() { Category = category } }
            };
            shoppingContext.Products.Add(product);
            shoppingContext.SaveChanges();
        }

        static Product GetProduct(string productName)
        {
            using var shoppingContext = new ShoppingContext();
            
            return shoppingContext.Products.Where(x => x.Name == productName)
                .Include("Categories").Include("Categories.Category").FirstOrDefault();
        }
    }
}
