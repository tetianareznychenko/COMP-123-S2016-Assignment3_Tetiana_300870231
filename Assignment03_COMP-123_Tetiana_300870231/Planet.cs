using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment03_COMP_123_Tetiana_300870231
{
    /**
      * <summary>
      * This is an abstract class for assignment 03
      * </summary>
      * @class Planet
      * @field {double} _diameter 
      * @field {double} _mass 
      * @field {int} _moonCount 
      * @field {string} _name
      * @field {double} _orbitalPeriod
      * @field {int} _ring count
      * @field {double} _rotationPeriod
      * 
      */
    public abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass; 
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount; 
            }

            set
            {
                this._moonCount = value; 
            }
        }

        public string Name
        {
            get
            {
                return this._name; 
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod; 
            }
            set
            {
                this._orbitalPeriod = value; 
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount; 
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod; 
            }
            set
            {
                this._rotationPeriod = value; 
            }
        }

        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
         * This is the constructor that takes name, diameter and mass as local variables an 
         * set the related instance variables (_name, _diameter and _mass) to their values 
         * </summary>
         * 
         * @constructor Planet
         * @param {double} diameter
         * @param {double} mass
         * @param {string} name
         * 
         */
        public Planet(double diameter, double mass, string name, int moonCount, int ringCount)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass= mass;
            this._moonCount = moonCount;
            this._ringCount = ringCount;
        }
        /**<summary>
         * This is the public override string ToString() method that outputs Name, Diameter and
         * Mass to the Console 
         * </summary>
         */

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Diameter (km): " + this.Diameter);
            Console.WriteLine("Mass (*10^22 kg): " + this.Mass);
            Console.WriteLine("******************************");
            string returnString = "******************************";

            return returnString;
        }
    }
}