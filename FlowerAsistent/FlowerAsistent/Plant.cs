using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerAsistent
{
    public abstract class Plant
    {
        public string Specie { get; set; }

        public string Color { get; set; }

        public Plant(string specie, string color)
        {
            this.Specie = specie;
            this.Color = color;
        }


        public abstract void Watering();

        public abstract void PesticideSpraying();



    }
}
