using System;
using SFML;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using System.Threading;
using System.Collections.Generic;



namespace SolarSystemSimulation
{
    class Program
    {
        public static List<PlanetShape> PlanetShapes = new List<PlanetShape>();
        public static RenderWindow window;

        static void Main(string[] args)
        {
            
            uint widht = 1280; //szerokosc
            uint height = 720; //wysokosc

            Planet Sun = new Planet("Sun", 3000 ,new Vector2f(400,400),new Vector2f(0.09f,0.09f));
            PlanetShape SunShape = new PlanetShape(40f, Sun, Color.Yellow);
            //Physics.Planets.Add(Sun);
            Physics.Sun = Sun;
            PlanetShapes.Add(SunShape);

            Planet Earth = new Planet("Earth", 100, new Vector2f(400, 300), new Vector2f(-5.567764362830022f, 0f));
            PlanetShape EarthShape = new PlanetShape(20f, Earth, Color.Blue);
            Physics.Planets.Add(Earth);
            PlanetShapes.Add(EarthShape);

            Planet Uranus = new Planet("Uranus", 300, new Vector2f(400, 200), new Vector2f(-4.06f, 0f));
            PlanetShape UranusShape = new PlanetShape(30f, Uranus, Color.Red);
            Physics.Planets.Add(Uranus);
            PlanetShapes.Add(UranusShape);


            window = new RenderWindow(new VideoMode(widht, height), "Solar System Simulation");
            window.Closed += (_, __) => Environment.Exit(0);

           

            while (window.IsOpen)
            {
                window.DispatchEvents();

                Physics.PhysicsUpdate();
                UpdatePositions();
                window.Clear(Color.Black);

                DrawShapes();



                window.Display();

                Thread.Sleep(16);
            }


           
        }

        static void UpdatePositions()
        {
            foreach (PlanetShape planetshape in PlanetShapes)
            {
                planetshape.UpdateShapePosition();
            }
        }
        static void DrawShapes()
        {
            foreach (PlanetShape planetshape in PlanetShapes)
            {
                window.Draw(planetshape);
            }

        }
    }
}
