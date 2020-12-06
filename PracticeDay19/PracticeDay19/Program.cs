using System;

namespace PracticeDay19
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = GetAnimal();
            animal.Eat();
            animal.Move();

            
        
        }

        private static IAnimal GetAnimal()
        {
            throw new NotImplementedException();
        }
        //#region practice of generic
        //public void Test<T>(T item) where T: Item
        //{
        //    var x = item.X + item.Y+item.Z ;
        //}

        //public interface IItem
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //}
        //public class Item : IItem
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //    public int Z { get; set; }
        //}
        //#endregion
    }
}
