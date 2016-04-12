using System;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace BudaEngine.Core
{
	public class Input
	{
		private static KeyboardState currentKeyboardState, lastKeyboardState;

		public Input ()
		{
		}

		public static void Update(){
			lastKeyboardState = currentKeyboardState;
			currentKeyboardState = Keyboard.GetState ();
		}

		public static bool WasKeyPressed(Keys key){
			return lastKeyboardState.IsKeyUp (key) && currentKeyboardState.IsKeyDown (key);
		}
	}
}

