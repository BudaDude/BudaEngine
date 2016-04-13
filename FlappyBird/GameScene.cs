using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework.Graphics;

namespace FlappyBird
{
	public class GameScene : Scene
	{
		private int score;
		Plane plane;


		public override void BeginScene ()
		{
			plane = new Plane ();
			score = 0;
			ObjectManager.Add (plane);
	
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
			base.Draw (spriteBatch);
		}
			


	}
}


