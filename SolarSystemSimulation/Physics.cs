using System;
using System.Collections.Generic;
using System.Text;
using SFML.System;

namespace SolarSystemSimulation
{
   static class Physics
    {
        public static List<Planet> Planets = new List<Planet>();
        public static Planet Sun;

        public static void PhysicsUpdate()
        {

            foreach (Planet planet in Planets)
            {
                double force = GravityForce(planet, Sun);
                double acceleration = force / planet.mass;
                planet.velocity += (float)acceleration * Normalized(Sun.position - planet.position);
                planet.Update();
                Sun.Update();
                
            }

        }

        public static double GravityForce(Planet planet1, Planet planet2)
        {

            return (1 * planet1.mass * planet2.mass / Math.Pow(VectorLenght(planet1.position - planet2.position), 2));
        
        }

        public static double VectorLenght(Vector2f vector)
        {
            return Math.Sqrt(Math.Pow(vector.X,2) + Math.Pow(vector.Y,2));
        }

        public static Vector2f Normalized(Vector2f vector)
        {
            return vector  / (float)VectorLenght(vector);
        }
    }

}
