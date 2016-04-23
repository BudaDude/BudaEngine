using System;
using BudaEngine;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace FlappyBird
{
	public class GameScene : Scene
	{
		private int score;


		public override void BeginScene ()
		{
			score = 0;
			Plane plane = new Plane ();
			Objects.Add (plane);
			base.BeginScene ();
		}

		public override void EndScene ()
		{
			ScoreManager.ResetScore ();
			base.EndScene ();
		}

		public override void Update ()
		{
			base.Update ();
		}
		public override void Draw (SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (Art.Background,
				new Rectangle (0, 0, BudaGame.ViewPort.Width, BudaGame.ViewPort.Height), Color.White);
			spriteBatch.DrawString (Art.Font, "Score: " + ScoreManager.Score, new Vector2 (500, 20), Color.Tomato);
			base.Draw (spriteBatch);
		}
			


	}
}


