using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework;

namespace FlappyBird
{
	public class MainMenuScene : Scene
	{
		
		public MainMenuScene ()
		{
			
		}
		public override void BeginScene ()
		{
			base.BeginScene ();
		}

		public override void Update ()
		{
			if (Input.WasKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space)){
				SceneManager.ChangeScene("Game");
			}
			base.Update ();
		}
		public override void Draw (Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (Art.Background,
				new Rectangle (0, 0, BudaGame.ViewPort.Width, BudaGame.ViewPort.Height), Color.White);
			spriteBatch.DrawString (Art.Font, "Crazy Plane Game", new Vector2 (BudaGame.ScreenSize.X/2-200, BudaGame.ScreenSize.Y/2), Color.Black);

			spriteBatch.DrawString (Art.Font, "Space to play", new Vector2 (BudaGame.ScreenSize.X/2-100, BudaGame.ScreenSize.Y/2+50), Color.Black);
			base.Draw (spriteBatch);
		}
	}
}

