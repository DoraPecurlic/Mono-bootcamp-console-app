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

            Console.WriteLine("Hello!\nI am your flowerAsistent!\n  ");

            Console.WriteLine("This is list of flowers in our store:\n  ");
           

            DisplayFlowers();

            Console.WriteLine("I can give you instructions on how to take care of chosen flower or you can buy flowers:\n  ");


            string option;
            do
            {
                Console.WriteLine("Please choose option: 1 or 2:\n");
                Console.WriteLine("   1. give me instructions\n");
                Console.WriteLine("   2. buy flowers\n");
                option = Console.ReadLine();
            } while(option != "1" && option != "2");


            if (option == "1")
            {
                GiveInstructions();
            }else
            {
                BuyFlowers();
            }
            
            Console.ReadLine();

            
        }


        static void GiveInstructions()
        {
            string pickedFlower;

            DisplayFlowers();

            do
            {
                Console.WriteLine("\nPlease enter number in front of flower so i can give you instructions on how to take care of it:\n");
                pickedFlower = Console.ReadLine();
            } while (pickedFlower != "1" && pickedFlower != "2" && pickedFlower != "3");


            switch (pickedFlower)
            {
                case "1":
                    Rose roseInstructions = new Rose("Rugosa rose", "white");
                    roseInstructions.DisplayInstructions();
                    break;
                case "2":
                    Tulips tulipsInstructions = new Tulips();
                    tulipsInstructions.DisplayInstructions();
                    break;
                case "3":
                    Cactus cactusInstructions = new Cactus();
                    cactusInstructions.DisplayInstructions();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void BuyFlowers()
        {
            string color;
            string specie;

            Console.WriteLine("FLOWER CART\n");
            Cart flowerCart = new Cart();

            DisplayFlowers();
            Console.WriteLine("Enter number of flowers you want to buy\n");

            int numberOfFlowers;
            while (!int.TryParse(Console.ReadLine(), out numberOfFlowers))
            {
                Console.WriteLine("Invalid input. Please enter number:");
            }



            for (int i = 0; i < numberOfFlowers; i++)
            {


                do
                {
                    Console.WriteLine($"Enter specie of {i + 1}. plant you want to buy from our store:\n");
                    specie = Console.ReadLine();
                } while (specie != "rose" && specie != "tulips" && specie != "cactus");



                Console.WriteLine($"Enter color of {specie} you want to buy:\n");
                color = Console.ReadLine();


                if (specie == "rose")
                {
                    Rose rose = new Rose(specie, color);
                    flowerCart.AddFlower(rose);
                }
                else if (specie == "tulips")
                {
                    Tulips tulips = new Tulips(specie, color);
                    flowerCart.AddFlower(tulips);
                }
                else
                {
                    Cactus cactus = new Cactus(specie, color);
                    flowerCart.AddFlower(cactus);
                }


            }

            Console.WriteLine("Your cart:\n");
            flowerCart.DisplayCart();

            Console.WriteLine("Do you want to remove flower (Y/N)?");
            string choice = Console.ReadLine();
            if(choice == "Y")
            {
                Console.WriteLine("Enter index nuber of flower you want to remove:\n");
                int removeIndex;
                while (!int.TryParse(Console.ReadLine(), out removeIndex) || removeIndex < 1 || removeIndex > flowerCart.flowers.Count())
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                flowerCart.RemoveFlowerByIndex(removeIndex - 1);

                Console.WriteLine("Updated Shopping List:");
                flowerCart.DisplayCart();
                
            }
           
        }

        static void DisplayFlowers()
        {
            List<string> flowers = new List<string>()
            {
                "1. Rose",
                "2. Tulips",
                "3. Cactus"
            };

            foreach (string item in flowers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
