using System;
using System.Collections.Generic;
using System.Text;
using SFML;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace SolarSystemSimulation
{
    public class Planet 
    {
        public Vector2f velocity;
        public Vector2f position;
        string name;
        public float mass;
        
       public Planet()
        {
           

        }
       public Planet(string name, float mass,Vector2f position,Vector2f velocity) 
       {
            this.velocity = velocity;
            this.position = position;
            this.name = name;
            this.mass = mass;

       }

        public void Update()
        {   
            
            position += velocity;

        }

    }
}
