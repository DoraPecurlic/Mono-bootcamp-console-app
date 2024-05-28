using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerAsistent
{
    internal class Cactus : Plant, ILightRequirement, IPlantCareInstructions
    {
        public Cactus(string specie= "Opuntia ficus-indica", string color="green") : base(specie, color)
        {
        }

        public override void Watering()
        {
            Console.WriteLine("Watering:   \n   Water your cactus only once a month. Cactuses does not need a lot of water.\n");
        }
        public override void PesticideSpraying()
        {
            Console.WriteLine("Pesticide spraying:   \n   You dont need to spray them.\n");
        }

        public void RequireSunLight()
        {
            Console.WriteLine("Sun Light:   \n   Do not need direct Sun light.\n");
        }

        public void CanGrowUnderArtificialLight()
        {
            Console.WriteLine("Artificial light:   \n   Cactuses can grow indoors.\n");
        }

        public void DisplayInstructions()
        {
            Watering();
            PesticideSpraying();
            RequireSunLight();
            CanGrowUnderArtificialLight();
            Console.WriteLine($"Good luck with taking care of your  {Specie} cactus!");

        }

    }
}
