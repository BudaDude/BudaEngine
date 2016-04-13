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
            Position = new Vector2(100,50);
            Sprite.Texture = Art.Plane;
			Active = true;

        }
        public override void Update()
        {
            Position.Y+=4;
			Rotation+= 0.02f;
			if (Input.WasKeyPressed(Keys.Space))
            {
                Position.Y -= 80;
				Rotation = -45;
				ScoreManager.AddScore ();
            }

			if (Position.Y > BudaGame.ScreenSize.Y || Position.Y < 0) {
				SceneManager.ResetScene ();
			}
            base.Update();
        }
    }
}
