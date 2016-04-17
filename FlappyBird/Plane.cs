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
            transform.Position = new Vector2(100,300);
            Sprite.Texture = Art.Plane;
			Active = true;
			transform.Position.Y = 8;
        }
        public override void Update()
        {
			transform.Rotation+= 0.02f;
			if (Input.WasKeyPressed(Keys.Space))
            {
				transform.Position.Y -= 250;
				transform.Rotation = -45;
				ScoreManager.AddScore ();
            }

			if (transform.Position.Y > BudaGame.ScreenSize.Y || transform.Position.Y < 0) {
				SceneManager.ChangeScene ("Menu");
			}
            base.Update();
        }
    }
}
