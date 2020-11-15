using System;

namespace HomePracticeday12
{
    class Program
    {
        static void Main(string[] args)
        {
            JuceBottle juceBottle = new JuceBottle(200, "Green",100);
            juceBottle.AddItem(300, 10);
            juceBottle.RemoveItem(180, 10);

            //Console.WriteLine(juceBottle.CurrentAmount);

            WaterBottle waterBottle = new WaterBottle(10, "White");
            waterBottle.AddItem(20,1);
            waterBottle.RemoveItem(5, 1);
            Console.WriteLine(waterBottle.CurrentAmount);

        }
    }
}
