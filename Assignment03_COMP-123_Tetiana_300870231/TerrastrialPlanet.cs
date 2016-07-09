using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment03_COMP_123_Tetiana_300870231
{
    public class TerrastrialPlanet : Planet, IHabitable, IHasMoons
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;
        
        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public TerrastrialPlanet (double diameter, double mass, string name, int moonCount, int ringCount, bool oxygen)
            : base (diameter, mass, name, moonCount, ringCount)
        {
            this._oxygen = oxygen;
            
        }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * Habitable method that returns a bool data type
         * </summary>
         * 
         * @method Habitable
         * @return {bool}
         */
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return (true);
            }

            return false;
        }
        /**
         * <summary>
         * HasMoons method that will return true if the MoonCount property is greater than zero
         * </summary>
         * 
         * @method HasMoons
         * @return {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return (true);
            }

            return false;
        }
    }
    }