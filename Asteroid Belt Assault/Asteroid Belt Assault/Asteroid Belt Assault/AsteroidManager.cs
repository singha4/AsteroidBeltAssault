using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroid_Belt_Assault
{
    class AsteroidManager
    {
        private int screenWidth = 800;
        private int screenHeight = 600;
        private int screenPadding = 10;
        private Rectangle initialFrame;
        private int asteroidFrames;
        private Texture2D texture;
        public List<Sprite> Asteroids = new List<Sprite>();
        private int minSpeed = 60;
        private int maxSpeed = 120;
        private Random rand = new Random();

        public void AddAsteroid()
        {
            Sprite newAsteroid = new Sprite(new Vector2(-500, -500), texture, initialFrame, Vector2.Zero);
            for (int x = 1; x < asteroidFrames; x++)
            {
                newAsteroid.AddFrame(new Rectangle(initialFrame.X + (initialFrame.Width * x),initialFrame.Y,initialFrame.Width,initialFrame.Height));
            }
            newAsteroid.Rotation = MathHelper.ToRadians((float)rand.Next(0, 360));
            newAsteroid.CollisionRadius = 15;
            Asteroids.Add(newAsteroid);
        }

    }
}
