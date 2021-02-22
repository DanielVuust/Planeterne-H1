using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Planeterne
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet merkur = new Planet();
            merkur.Name = "Merkur";
            merkur.Diameter = 4879;
            merkur.Density = 5427;
            merkur.MoonNumber = 0;
            merkur.LengthOfDay = 1407.6;
            merkur.MeanTemperature = 167;

            Planet jorden = new Planet();
            jorden.Name = "Jorden";
            jorden.Diameter = 12756;
            jorden.Density = 5514;
            jorden.MoonNumber = 1;
            jorden.LengthOfDay = 24;
            jorden.MeanTemperature = 15;

            Planet mars = new Planet();
            mars.Name = "Mars";
            mars.Diameter = 6792;
            mars.Density = 3933;
            mars.MoonNumber = 2;
            mars.LengthOfDay = 24.7;
            mars.MeanTemperature = -65;

            Planet jupiter= new Planet();
            jupiter.Name = "Jupiter";
            jupiter.Diameter = 142984;
            jupiter.Density = 1326;
            jupiter.MoonNumber = 67;
            jupiter.LengthOfDay = 9.9;
            jupiter.MeanTemperature =-110 ;

            Planet saturn = new Planet();
            saturn.Name = "Saturn";
            saturn.Diameter =120536 ;
            saturn.Density = 684;
            saturn.MoonNumber = 62;
            saturn.LengthOfDay = 10.7;
            saturn.MeanTemperature = -140;

            Planet uranus= new Planet();
            uranus.Name = "Uranus";
            uranus.Diameter = 51118;
            uranus.Density = 1271;
            uranus.MoonNumber = 27;
            uranus.LengthOfDay = 17.2;
            uranus.MeanTemperature = -195;

            Planet neptun = new Planet();
            neptun.Name = "Neptun";
            neptun.Diameter = 49528;
            neptun.Density = 1638;
            neptun.MoonNumber = 14;
            neptun.LengthOfDay = 16.1;
            neptun.MeanTemperature = -200;

            Planet pluto = new Planet();
            pluto.Name = "Pluto";
            pluto.Diameter = 2370;
            pluto.Density = 2095;
            pluto.MoonNumber = 5;
            pluto.LengthOfDay = 153.3;
            pluto.MeanTemperature = -225;

           

            List<Planet> planets = new List<Planet>();

            planets.Add(merkur);
            planets.Add(jorden);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptun);
            planets.Add(pluto);

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();

            Planet venus = new Planet();
            venus.Name = "Venus";
            venus.Diameter = 12104;
            venus.Density = 5243;
            venus.MoonNumber = 0;
            venus.LengthOfDay = 2802;
            venus.MeanTemperature = 464;

            planets.Insert(1, venus);


            foreach (Planet planet in planets){
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();

            for (int i = 0; i <= planets.Count; i++)
            {
                if (planets[i].Name == "Pluto")
                    planets.RemoveAt(i);
            }

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();

            planets.Add(pluto);
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();

            Console.WriteLine(planets.Count);

            List<Planet> planets2 = new List<Planet>();
            planets2.AddRange( planets.Where(planets => planets.MeanTemperature < 0));

            foreach (Planet planet in planets2)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();

            List<Planet> planets3 = new List<Planet>();
            planets3.AddRange(planets.Where(planets => planets.Diameter < 50000 && planets.Diameter >10000));

            foreach (Planet planet in planets2)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine();

            planets.Clear();
        }
    }
}
