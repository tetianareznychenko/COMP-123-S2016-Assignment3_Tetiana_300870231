using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment03_COMP_123_Tetiana_300870231
{
    public class TerrastrialPlanet : Planet, IHabitable, IHasMoons
    {
        private bool _oxygen;

        public TerrastrialPlanet (double diameter, double mass, string name, int moonCount, double orbitalPeriod, int ringCount,
            double rotationPeriod, string type, bool oxygen)
            : base (diameter, mass, name)
        {
            this._oxygen = oxygen;
        }

        public void Habitable()
        {
            if (_oxygen == true)
            {
                Console.WriteLine("{0} is Habitable", this.Name);
            }
            else
            {
                Console.WriteLine("{0} is not Habitable", this.Name);
            }
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
    }
}