using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment03_COMP_123_Tetiana_300870231
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;

        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(double diameter, double mass, string name, int moonCount, int ringCount, string type)
            : base (diameter, mass, name, moonCount, ringCount)
        {
            
        }
        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string ypeT
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
            
            if (MoonCount > 0 )
            {
                return (true);
            }

            return false;
        }
        /**
         * <summary>
         * HasRings method that will return true if the RingCount property is greater than zero
         * </summary>
         * 
         * @method HasRings
         * @return {bool}
         */
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }

            return false;
        }
        }
    }


