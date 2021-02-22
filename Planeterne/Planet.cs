using System;
using System.Collections.Generic;
using System.Text;

namespace Planeterne
{
    class Planet
    {
        private string _Name;
        private int _Diameter;
        private int _Density;
        private int _MoonNumber;
        private double _LengthOfDay;
        private int _MeanTemperature;

        public string Name { 
            get { return this._Name; }
            set { _Name = value; } }
        public int Diameter
        {
            get { return this._Diameter; }
            set { _Diameter = value; }
        }
            public int Density
        {
            get { return this._Density; }
            set { _Density = value; }
        }
            public int MoonNumber
        {
            get { return this._MoonNumber; }
            set { _MoonNumber = value; }
        }
        public double LengthOfDay
        {
            get { return this._LengthOfDay; }
            set { _LengthOfDay = value; }
        }
        public int MeanTemperature
        {
            get { return this._MeanTemperature; }
            set { _MeanTemperature = value; }
        }
        public Planet()
        {

        }

    }
    
}
