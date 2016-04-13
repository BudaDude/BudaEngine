using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FlappyBird
{
	public class Rock : GameObject
	{
		GameObject topRock;
		GameObject bottomRock;
		Random random = new Random();
		public Rock (float distance)
		{
			Position = new Vector2 (BudaGame.ScreenSize.X / 2, BudaGame.ScreenSize.Y / 2);
			topRock = new GameObject ();
			bottomRock = new GameObject ();
			topRock.Sprite.Texture = Art.Rock;
			topRock.Sprite.SpriteEffects = SpriteEffects.FlipVertically;
			bottomRock.Sprite.Texture = Art.Rock;
			SetDistance (random.Next(50)+10);


		}

		private void SetDistance(float distance){
			topRock.Position = new Vector2 (Position.X, - (distance / 2));
			bottomRock.Position = new Vector2 (Position.X, BudaGame.ScreenSize.Y + (distance / 2));
		}

		public override void Update ()
		{ 
			Position.X+=-2;
			topRock.Position.X = Position.X;
			bottomRock.Position.X = Position.X; 

			if (Position.X < -100) {
				Position.X = BudaGame.ScreenSize.X+100;
				SetDistance (random.Next(25)+10);
			}
			base.Update ();
		}

		public override void Draw (Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
		{
			topRock.Draw (spriteBatch);
			bottomRock.Draw (spriteBatch);
			base.Draw (spriteBatch);
		}
			
	}
}

