using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_COMP_123_Tetiana_300870231
{
    /**
     * Tetiana Reznychenko 
     * 300870231
     * 07/07/2016
     * Assignment 03 - Abstract Planets
     */

    class Program
    {
        static void Main(string[] args)
        {
            //New GiantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet(142800, 189890, "Jupiter", 67, 4, "Gas");
            //67, 11.86, 4, 0.41,
            giantPlanet.ToString();
            Console.WriteLine("Does the Planet has moons? " + giantPlanet.HasMoons());
            Console.WriteLine("Does the Planet has rings? " + giantPlanet.HasRings());
            
            Console.WriteLine();
            Console.WriteLine();
            TerrastrialPlanet terrastrialPlanet = new TerrastrialPlanet(12756, 597.36, "Earth", 1, 0, true);
            terrastrialPlanet.ToString();
            Console.WriteLine("Does the Planet has moons? " + terrastrialPlanet.HasMoons());
            Console.WriteLine("Does the Planet has oxygen and is Habitable? " + terrastrialPlanet.Habitable());
                          

            WaitForAnyKey();
        }
        /**
         * <summary>
         * Utility method to wait for a console key press for user
         * </summary>
         * 
         * @method WaitForAnyKey
         * @return {void}
         */
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
