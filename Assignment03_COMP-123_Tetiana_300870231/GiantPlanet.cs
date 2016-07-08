using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment03_COMP_123_Tetiana_300870231
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(double diameter, double mass, string name, int moonCount, double orbitalPeriod, int ringCount, 
            double rotationPeriod,  string type)
            : base (diameter, mass, name)
        {
            this._type = type;
        }

        public void HasMoons()
        {
            if (MoonCount > 0)
            {
                Console.WriteLine("{0} has moons", this.Name);
            }
            else
            {
                Console.WriteLine("{0} does not have moons", this.Name);
            }
        }

        public void HasRings()
        {
            if (RingCount > 0)
            {
                Console.WriteLine("{0} has rings", this.Name);
            }
            else
            {
                Console.WriteLine("{0} does not have rings", this.Name);
            }
        }
    }

}
