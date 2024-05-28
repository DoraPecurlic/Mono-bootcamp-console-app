using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerAsistent
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pickedFlower;
            Console.WriteLine("Hello!\nI am your flowerAsistent!\n  ");

            List<string> list = new List<string>()
            {
                "1. Rose",
                "2. Tulips",
                "3. Cactus"
            };

            Console.WriteLine("This is the list of flowers i can help you with:\n");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            do
            {
                Console.WriteLine("\nPlease enter number in front of flower so i can give you instructions on how to take care of it:\n");
                pickedFlower = Console.ReadLine();
            } while (pickedFlower != "1" && pickedFlower != "2" && pickedFlower != "3");



            switch (pickedFlower)
            {
                case "1":
                    Rose rose = new Rose("Rugosa", "white");
                    rose.DisplayInstructions();
                    break;
                case "2":
                    Tulips tulips = new Tulips();
                    tulips.DisplayInstructions();
                    break;
                case "3":
                    Cactus cactus = new Cactus();
                    cactus.DisplayInstructions();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }





            Console.ReadLine();
        }
    }
}
