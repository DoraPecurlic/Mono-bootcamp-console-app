using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerAsistent
{
    internal class Rose : Plant, ILightRequirement
    {


        public Rose(string specie, string color) : base(specie, color)
        {

        }

        public override void Watering()
        {
            Console.WriteLine("Water your roses 2-3 times a week. Amount of water per watering: 10-20 liters\n");
        }
        public override void PesticideSpraying()
        {
            Console.WriteLine("Spray your roses with pesticides once every 2 weeks.!\n");
        }

        public void RequireSunLight()
        {
            Console.WriteLine("Roses require DIRECT sun light (6 to 8 hours of day)\n");
        }

        public void CanGrowUnderArtificialLight()
        {
            Console.WriteLine("Roses can grow indoors using artificial lighting. Intensity of: 200-1000 micromols\n");
        }

        public void DisplayInstructions()
        {
            Watering();
            PesticideSpraying();
            RequireSunLight();
            CanGrowUnderArtificialLight();
            Console.WriteLine($"Good luck with taking care of your {Color} {Specie} rose!");

        }


    }
}
