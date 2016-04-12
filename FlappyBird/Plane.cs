using System;
using BudaDude.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    class Plane : GameObject
    {
        public Plane()
        {
            Position = new Vector2(5,5);
            Sprite.Texture = Art.Plane;


        }


        public override void Update()
        {
            KeyboardState state = new KeyboardState();
            Position.Y+=5;

            if (state.IsKeyDown(Keys.Space))
            {
                Position.Y -= 25;
            }

            if (Position.X > BudaGame.ScreenSize.X) Position.X = 0-Sprite.Texture.Width;
            base.Update();
        }
    }
}
