using System;

namespace HomePractice5
{
    class Program
    {
        static void Main(string[] args)
        {
            fruit f1 = new fruit();
            f1.name = "Mango";
            f1.type = "Ripe";
            f1.season = "Summer";
            f1.Amount = 5;
            Console.WriteLine("Fruit is: "+f1.name+"\nType is: "+f1.type +"\nSeoson is: "+f1.season+ "\nAmounk is: "+ f1.Amount+" kg\n");

            fruit f2 = new fruit();
            f2.name = "Apple";
            f2.type = "Green";
            f2.season = "All Seasonal";
            f2.Amount = 2;
            Console.WriteLine("Fruit is: " + f2.name + "\nType is: " + f2.type + "\nSeoson is: " + f2.season + "\nAmounk is: " + f2.Amount + " kg\n");

        }
    }
    public class fruit
    {
        public string type;
        public string name;
        public string season;
        private double amount;

        public double Amount
            {
              get { return amount; }
             
              set
            {
                if (amount > 0)
                    value = 0;
                else
                    amount = value;

            }
               
            }
        public fruit()
        {
           

        }
        
    }
}
