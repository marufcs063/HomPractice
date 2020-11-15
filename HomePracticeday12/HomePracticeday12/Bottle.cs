using System;
using System.Collections.Generic;
using System.Text;

namespace HomePracticeday12
{
    public abstract class Bottle
    {
        public int Capacity { get; }
        public string Color { get; }
        public int CurrentAmount { get; protected set; }

        public Bottle()
        {

        }
        public Bottle(int capacity, string color, int currentAmount)
        {
            Capacity = capacity;
            Color = color;
            CurrentAmount = currentAmount;
        }
        public Bottle (int capacity, string color)
        {
            Capacity = capacity;
            Color = color;
            CurrentAmount = 0;
        }
        public void AddItem(int amount, int threshhold)
        {
            if (amount > Capacity)
                CurrentAmount = Capacity - threshhold;
            else
                CurrentAmount = amount - threshhold;
        }

        public void RemoveItem(int amount, int threshhold)
        {
            if (amount > CurrentAmount)
                CurrentAmount = 0;
            else
                CurrentAmount = CurrentAmount-(amount + threshhold);
        }





    }
}
