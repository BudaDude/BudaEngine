using System;
using BudaEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
	class Plane : DrawableGameObject
    {
		Transform transform;
        public Plane()
        {
			transform = (Transform)Components.AddComponent(new Transform());
            transform.Position = new Vector2(100,300);
			Active = true;
			transform.Velocity.Y = 8;
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

		#region implemented abstract members of DrawableGameObject

		public override void LoadContent ()
		{
			throw new NotImplementedException ();
		}

		public override void Draw (SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (Art.Plane, transform.Position);
		}

		#endregion
    }
}
