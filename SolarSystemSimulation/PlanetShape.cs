using System;
using System.Collections.Generic;
using System.Text;
using SFML;
using SFML.Window;
using SFML.Graphics;
using SFML.System;


namespace SolarSystemSimulation
{
    class PlanetShape : CircleShape
    {
        Planet planet;

        public PlanetShape(float circle_radius,Planet planet,Color color) : base(circle_radius)
        {
            FillColor = color;
            this.planet = planet;
        }
        public void UpdateShapePosition()
        {
            this.Position = new Vector2f(planet.position.X - Radius, planet.position.Y - Radius);
        
        }
    }
}
