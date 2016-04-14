using System;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace BudaEngine.Core
{
	public class Input
	{
		private static KeyboardState currentKeyboardState, lastKeyboardState;

		public static void Update(){
			lastKeyboardState = currentKeyboardState;
			currentKeyboardState = Keyboard.GetState ();
		}

		/// <summary>
		/// Was the key pressed.
		/// </summary>
		/// <returns><c>true</c>, if key pressed was pressed, <c>false</c> otherwise.</returns>
		/// <param name="key">Key.</param>
		public static bool WasKeyPressed(Keys key){
			return lastKeyboardState.IsKeyUp (key) && currentKeyboardState.IsKeyDown (key);
		}
	}
}

