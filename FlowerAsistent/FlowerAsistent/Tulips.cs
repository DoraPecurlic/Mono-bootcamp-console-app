using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerAsistent
{
    internal class Tulips : Plant, ILightRequirement, IPlantCareInstructions
    {
        public Tulips(string specie= "Tulip Gesneriana", string color ="yellow") : base(specie, color)
        {
        }

        public override void Watering()
        {
            Console.WriteLine("Watering:   \n   Water your tulips once a week. Amount of water per watering: 500 ml\n");
        }
        public override void PesticideSpraying()
        {
            Console.WriteLine("Pesticide spraying:   \n   Spray your tulips with pesticides once every 5 weeks.!\n");
        }

        public void RequireSunLight()
        {
            Console.WriteLine("Sun Light:   \n   Tulips require direct sun light (4 to 6 hours of day is enough)\n");
        }

        public void CanGrowUnderArtificialLight()
        {
            Console.WriteLine("Artificial light:   \n   Tulips can grow indoors using artificial lighting. Use T5 i T8 fluorescent lamps for 16 hours a day\n");
        }

        public void DisplayInstructions()
        {
            Watering();
            PesticideSpraying();
            RequireSunLight();
            CanGrowUnderArtificialLight();
            Console.WriteLine($"Good luck with taking care of your {Color} {Specie} tulips!");
        }
    }
}
