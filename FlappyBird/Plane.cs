using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    class Plane : GameObject
    {
        public Plane()
        {
            Position = new Vector2(50,5);
            Sprite.Texture = Art.Plane;
			Sprite.Origin = new Vector2 (Sprite.Texture.Width / 2, Sprite.Texture.Height / 2);

        }


        public override void Update()
        {
            Position.Y+=5;
			Rotation+= 0.02f;
			if (Input.WasKeyPressed(Keys.Space))
            {
                Position.Y -= 100;
				Rotation = -45;
            }

            if (Position.X > BudaGame.ScreenSize.X) Position.X = 0-Sprite.Texture.Width;
            base.Update();
        }
    }
}
