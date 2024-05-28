using System;
using System.Collections.Generic;


namespace FlowerAsistent
{
    public class Cart
    {
        public List<Plant> flowers = new List<Plant>();

        public void AddFlower(Plant plant)
        {
            this.flowers.Add(plant);
        }

        public void RemoveFlowerByIndex(int index)
        {
            if (index >= 0 && index < flowers.Count)
            {
                flowers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
        }

        public void DisplayCart()
        {
            for (int i = 0; i < flowers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {flowers[i].Color} {flowers[i].Specie}");
            }
        }
    }
}
