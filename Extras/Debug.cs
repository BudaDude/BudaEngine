using System;
using BudaEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Extras
{
	static class Debug
	{
		private static Boolean isToggled;


		public static void Update(){

			if (Input.WasKeyPressed (Keys.OemTilde))
				isToggled = !isToggled;
		}

		public static void Draw(SpriteBatch spriteBatch){
			if (isToggled) {
				int frameRate = (int)Math.Round(1 / (float)BudaGame.GameTime.ElapsedGameTime.TotalSeconds);
				string ouput = String.Format ("FPS: {0}", frameRate);
				spriteBatch.DrawString (DebugContent.Font, ouput, new Vector2 (BudaGame.ScreenSize.X - 200, 40), Color.Lime);
			}

		}
	}

}

